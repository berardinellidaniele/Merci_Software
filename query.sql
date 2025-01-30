CREATE TABLE Passeggero
(
    ID_Passeggero INT PRIMARY KEY IDENTITY NOT NULL,
    nome VARCHAR(50) NOT NULL,
    cognome VARCHAR(50) NOT NULL,
    nazionalita VARCHAR(50) NOT NULL,
    num_documento VARCHAR(50) NOT NULL,
    aeroporto_provenienza VARCHAR(50) NOT NULL,
    aeroporto_destinazione VARCHAR(50) NOT NULL,
    motivo_viaggio VARCHAR(25) NOT NULL
);


CREATE TABLE Aeroporto
(
    ID_Aeroporto INT PRIMARY KEY IDENTITY NOT NULL,
    nome VARCHAR(50) NOT NULL,
    localizzazione VARCHAR(100) NOT NULL
);

CREATE TABLE PuntoControllo
(
    ID_PuntoControllo INT PRIMARY KEY IDENTITY NOT NULL,
    nome VARCHAR(50) NOT NULL,
    descrizione VARCHAR(255) NOT NULL,
    localizzazione VARCHAR(100) NOT NULL,
    ID_Aeroporto INT NOT NULL,
    FOREIGN KEY (ID_Aeroporto) REFERENCES Aeroporto(ID_Aeroporto)
);



CREATE TABLE Addetto
(
    ID_Addetto INT PRIMARY KEY IDENTITY NOT NULL,
    nome VARCHAR(50) NOT NULL,
    cognome VARCHAR(50) NOT NULL,
    data_nascita DATE NOT NULL,
    ID_PuntoControllo INT NOT NULL,
    FOREIGN KEY (ID_PuntoControllo) REFERENCES PuntoControllo(ID_PuntoControllo)
);

CREATE TABLE Merce
(
    ID_Merce INT PRIMARY KEY IDENTITY NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    descrizione VARCHAR(255) NOT NULL,
    quantita INT NOT NULL,
    ID_Passeggero INT NOT NULL,
    FOREIGN KEY (ID_Passeggero) REFERENCES Passeggero(ID_Passeggero)
);


CREATE TABLE Controllo
(
    ID_Controllo INT PRIMARY KEY IDENTITY NOT NULL,
    punto_controllo INT NOT NULL,
    dataora_inizio DATETIME NOT NULL,
    dataora_fine DATETIME NOT NULL,
    esito VARCHAR(50) NOT NULL,
    note VARCHAR(255) NOT NULL,
    dazio_doganale FLOAT NOT NULL,
    ID_Addetto INT NOT NULL,
    ID_Passeggero INT NOT NULL,
    ID_PuntoControllo INT NOT NULL,
    FOREIGN KEY (ID_Addetto) REFERENCES Addetto(ID_Addetto),
    FOREIGN KEY (ID_Passeggero) REFERENCES Passeggero(ID_Passeggero),
    FOREIGN KEY (ID_PuntoControllo) REFERENCES PuntoControllo(ID_PuntoControllo)
);

CREATE TABLE Segnalazione
(
    ID_Segnalazione INT PRIMARY KEY IDENTITY NOT NULL,
    tipologia VARCHAR(50) NOT NULL,
    data_ora_segnalazione DATETIME NOT NULL,
    stato VARCHAR(50) NOT NULL,
    ID_Controllo INT NOT NULL,
    FOREIGN KEY (ID_Controllo) REFERENCES Controllo(ID_Controllo)
);

CREATE TABLE FermoPasseggero
(
    ID_Fermo INT PRIMARY KEY IDENTITY NOT NULL,
    data_ora_fermo DATETIME NOT NULL,
    motivo VARCHAR(255) NOT NULL,
    stato VARCHAR(50) NOT NULL,
    ID_Controllo INT NOT NULL,
    ID_Passeggero INT NOT NULL,
    FOREIGN KEY (ID_Controllo) REFERENCES Controllo(ID_Controllo),
    FOREIGN KEY (ID_Passeggero) REFERENCES Passeggero(ID_Passeggero)
);

CREATE TABLE SequestroMerce
(
    ID_Sequestro INT PRIMARY KEY IDENTITY NOT NULL,
    data_ora_sequestro DATETIME NOT NULL,
    motivo VARCHAR(255) NOT NULL,
    stato VARCHAR(50) NOT NULL,
    ID_Controllo INT NOT NULL,
    ID_Merce INT NOT NULL,
    FOREIGN KEY (ID_Controllo) REFERENCES Controllo(ID_Controllo),
    FOREIGN KEY (ID_Merce) REFERENCES Merce(ID_Merce)
);

CREATE TABLE Contestazione
(
    ID_Contestazione INT PRIMARY KEY IDENTITY NOT NULL,
    data_ora_contestazione DATETIME NOT NULL,
    motivo VARCHAR(255) NOT NULL,
    stato VARCHAR(50) NOT NULL,
    ID_Controllo INT NOT NULL,
    FOREIGN KEY (ID_Controllo) REFERENCES Controllo(ID_Controllo)
);
