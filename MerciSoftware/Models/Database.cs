using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MerciSoftware.Models
{
    public class Database
    {
        private readonly string _conn;

        public Database()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _conn = configuration.GetConnectionString("Default");
        }

        private SqlConnection CreaConnessione()
        {
            return new SqlConnection(_conn);
        }

        public List<Passeggero> GetAllPasseggeri()
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM Passeggero";
            return conn.Query<Passeggero>(sql).ToList();
        }

        public Funzionario? VerificaCredenzialiFunzionario(string email, string password)
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM Funzionario WHERE Email = @Email AND Password = @Password";

            return conn.Query<Funzionario>(sql, new { Email = email, Password = password }).FirstOrDefault();
        }

        public void AggiungiPasseggero(Passeggero nuovoPasseggero)
        {
            using var conn = CreaConnessione();
            string sql = @"
        INSERT INTO Passeggero (nome, cognome, nazionalita, num_documento, aeroporto_provenienza, aeroporto_destinazione, motivo_viaggio) 
        VALUES (@nome, @cognome, @nazionalita, @num_documento, @aeroporto_provenienza, @aeroporto_destinazione, @motivo_viaggio)";

            conn.Execute(sql, new
            {
                nome = nuovoPasseggero.nome,
                cognome = nuovoPasseggero.cognome,
                nazionalita = nuovoPasseggero.nazionalita,
                num_documento = nuovoPasseggero.num_documento,
                aeroporto_provenienza = nuovoPasseggero.aeroporto_provenienza,
                aeroporto_destinazione = nuovoPasseggero.aeroporto_destinazione,
                motivo_viaggio = nuovoPasseggero.motivo_viaggio
            });
        }

        public List<Merce> GetAllMerci()
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM Merce";
            return conn.Query<Merce>(sql).ToList();
        }

        public void AggiungiMerce(Merce nuovaMerce)
        {
            using var conn = CreaConnessione();
            string sql = @"
        INSERT INTO Merce (ID_Passeggero, categoria, descrizione, quantita) 
        VALUES (@ID_Passeggero, @categoria, @descrizione, @quantita)";

            conn.Execute(sql, new
            {
                ID_Passeggero = nuovaMerce.ID_Passeggero, 
                categoria = nuovaMerce.categoria,
                descrizione = nuovaMerce.descrizione,
                quantita = nuovaMerce.quantita
            });
        }

        public List<SequestroMerce> GetAllSequestriMerce()
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM SequestroMerce";
            return conn.Query<SequestroMerce>(sql).ToList();
        }

        public void AggiungiSequestro(SequestroMerce nuovoSequestro)
        {
            using var conn = CreaConnessione();
            string sql = @"
    INSERT INTO SequestroMerce (ID_Controllo, ID_Merce, motivo, stato) 
    VALUES (@ID_Controllo, @ID_Merce, @motivo, @stato)";

            conn.Execute(sql, new
            {
                ID_Controllo = nuovoSequestro.ID_Controllo,
                ID_Merce = nuovoSequestro.ID_Merce,
                motivo = nuovoSequestro.motivo,
                stato = nuovoSequestro.stato
            });
        }

        public List<Segnalazione> GetAllSegnalazioni()
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM Segnalazione";
            return conn.Query<Segnalazione>(sql).ToList();
        }

        public void AggiungiSegnalazione(Segnalazione nuovaSegnalazione)
        {
            using var conn = CreaConnessione();
            string sql = @"
        INSERT INTO Segnalazione (ID_Controllo, tipologia, stato) 
        VALUES (@ID_Controllo, @tipologia, @stato)";

            conn.Execute(sql, new
            {
                ID_Controllo = nuovaSegnalazione.ID_Controllo,
                tipologia = nuovaSegnalazione.tipologia,
                stato = nuovaSegnalazione.stato
            });
        }

        public List<Controllo> GetAllControlli()
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM Controllo";
            return conn.Query<Controllo>(sql).ToList();
        }

        public List<Addetto> GetAllAddetti()
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM Addetto";
            return conn.Query<Addetto>(sql).ToList();
        }

        public List<PuntoControllo> GetAllPuntiControllo()
        {
            using var conn = CreaConnessione();
            string sql = "SELECT * FROM PuntoControllo";
            return conn.Query<PuntoControllo>(sql).ToList();
        }

    }
}
