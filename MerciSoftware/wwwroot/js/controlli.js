document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('controlloForm');

    form.addEventListener('submit', function (e) {
        e.preventDefault();
        let isValid = true;

        // Controllo Punto Controllo
        const puntoControllo = document.getElementById('puntoControllo').value.trim();
        if (puntoControllo === "") {
            document.getElementById('puntoControlloError').textContent = "Inserisci un punto di controllo valido.";
            document.getElementById('puntoControlloError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('puntoControlloError').classList.remove('visible');
        }

        // Controllo Data e Ora Inizio
        const dataOraInizio = document.getElementById('dataOraInizio').value;
        if (dataOraInizio === "") {
            document.getElementById('dataOraInizioError').textContent = "Inserisci una data e ora valida.";
            document.getElementById('dataOraInizioError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('dataOraInizioError').classList.remove('visible');
        }

        // Controllo Data e Ora Fine
        const dataOraFine = document.getElementById('dataOraFine').value;
        if (dataOraFine === "") {
            document.getElementById('dataOraFineError').textContent = "Inserisci una data e ora valida.";
            document.getElementById('dataOraFineError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('dataOraFineError').classList.remove('visible');
        }

        // Controllo Esito
        const esito = document.getElementById('esito').value;
        if (esito === "") {
            document.getElementById('esitoError').textContent = "Seleziona un esito.";
            document.getElementById('esitoError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('esitoError').classList.remove('visible');
        }

        // Controllo Dazio Doganale
        const dazioDoganale = document.getElementById('dazioDoganale').value;
        if (dazioDoganale === "" || isNaN(dazioDoganale)) {
            document.getElementById('dazioDoganaleError').textContent = "Inserisci un importo valido.";
            document.getElementById('dazioDoganaleError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('dazioDoganaleError').classList.remove('visible');
        }

        // Controllo Note
        const note = document.getElementById('note').value.trim();
        if (note === "") {
            document.getElementById('noteError').textContent = "Inserisci delle note.";
            document.getElementById('noteError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('noteError').classList.remove('visible');
        }

        // Se tutto è valido, invia il form
        if (isValid) {
            alert("Controllo modificato con successo!");
            form.reset();
            document.getElementById('modificaControlloSection').style.display = 'none';
        }
    });
});

function modificaControllo(idControllo) {
    // Simula il caricamento dei dati del controllo
    const controllo = {
        puntoControllo: "Punto 1",
        dataOraInizio: "2023-10-01T10:00",
        dataOraFine: "2023-10-01T10:15",
        esito: "Nessuna segnalazione",
        dazioDoganale: "0.00",
        note: "Tutto in regola"
    };

    // Popola il form con i dati del controllo
    document.getElementById('puntoControllo').value = controllo.puntoControllo;
    document.getElementById('dataOraInizio').value = controllo.dataOraInizio;
    document.getElementById('dataOraFine').value = controllo.dataOraFine;
    document.getElementById('esito').value = controllo.esito;
    document.getElementById('dazioDoganale').value = controllo.dazioDoganale;
    document.getElementById('note').value = controllo.note;

    // Mostra la sezione di modifica
    document.getElementById('modificaControlloSection').style.display = 'block';
}

function annullaModifica() {
    document.getElementById('modificaControlloSection').style.display = 'none';
}