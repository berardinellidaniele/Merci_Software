document.addEventListener('DOMContentLoaded', function () {
    const merceForm = document.getElementById('merceForm');
    const sequestroForm = document.getElementById('sequestroForm');

    // Validazione Aggiungi Merce
    merceForm.addEventListener('submit', function (e) {
            let isValid = true;

        // Controllo Categoria
        const categoria = document.getElementById('categoria').value;
        if (categoria === "") {
            document.getElementById('categoriaError').textContent = "Seleziona una categoria.";
            document.getElementById('categoriaError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('categoriaError').classList.remove('visible');
        }

        // Controllo Descrizione
        const descrizione = document.getElementById('descrizione').value.trim();
        if (descrizione === "") {
            document.getElementById('descrizioneError').textContent = "Inserisci una descrizione.";
            document.getElementById('descrizioneError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('descrizioneError').classList.remove('visible');
        }

        // Controllo Quantità
        const quantita = document.getElementById('quantita').value;
        if (quantita === "" || isNaN(quantita) || quantita <= 0) {
            document.getElementById('quantitaError').textContent = "Inserisci una quantità valida.";
            document.getElementById('quantitaError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('quantitaError').classList.remove('visible');
        }

        // Controllo ID Passeggero
        const idPasseggero = document.getElementById('idPasseggero').value.trim();
        if (idPasseggero === "" || !/^\d+$/.test(idPasseggero)) {
            document.getElementById('idPasseggeroError').textContent = "Inserisci un ID passeggero valido (solo numeri).";
            document.getElementById('idPasseggeroError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('idPasseggeroError').classList.remove('visible');
        }

        // Se tutto è valido, invia il form
        if (isValid) {
            alert("Merce aggiunta con successo!");
            merceForm.reset();
        }
    });

    // Validazione Segnala Sequestro
    sequestroForm.addEventListener('submit', function (e) {
        e.preventDefault();
        let isValid = true;

        // Controllo Data e Ora Sequestro
        const dataOraSequestro = document.getElementById('dataOraSequestro').value;
        if (dataOraSequestro === "") {
            document.getElementById('dataOraSequestroError').textContent = "Inserisci una data e ora valida.";
            document.getElementById('dataOraSequestroError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('dataOraSequestroError').classList.remove('visible');
        }

        // Controllo Motivo
        const motivo = document.getElementById('motivo').value.trim();
        if (motivo === "") {
            document.getElementById('motivoError').textContent = "Inserisci un motivo.";
            document.getElementById('motivoError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('motivoError').classList.remove('visible');
        }

        // Controllo Stato
        const stato = document.getElementById('stato').value;
        if (stato === "") {
            document.getElementById('statoError').textContent = "Seleziona uno stato.";
            document.getElementById('statoError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('statoError').classList.remove('visible');
        }

        // Controllo ID Controllo
        const idControllo = document.getElementById('idControllo').value.trim();
        if (idControllo === "" || !/^\d+$/.test(idControllo)) {
            document.getElementById('idControlloError').textContent = "Inserisci un ID controllo valido (solo numeri).";
            document.getElementById('idControlloError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('idControlloError').classList.remove('visible');
        }

        // Controllo ID Merce
        const idMerce = document.getElementById('idMerce').value.trim();
        if (idMerce === "" || !/^\d+$/.test(idMerce)) {
            document.getElementById('idMerceError').textContent = "Inserisci un ID merce valido (solo numeri).";
            document.getElementById('idMerceError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('idMerceError').classList.remove('visible');
        }

        // Se tutto è valido, invia il form
        if (isValid) {
            alert("Sequestro segnalato con successo!");
            sequestroForm.reset();
        }
    });
});