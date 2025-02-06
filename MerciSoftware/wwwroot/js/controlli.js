document.addEventListener('DOMContentLoaded', function () {
    const modificaForm = document.getElementById('modificaControlloForm');

    modificaForm.addEventListener('submit', function (e) {
        e.preventDefault();
        let isValid = true;

        // Controllo validità campi
        const puntoControllo = document.getElementById('puntoControllo').value;
        const addetto = document.getElementById('addetto').value;
        const dataOraInizio = document.getElementById('dataOraInizio').value;
        const dataOraFine = document.getElementById('dataOraFine').value;
        const esito = document.getElementById('esito').value;
        const dazioDoganale = document.getElementById('dazioDoganale').value;
        const note = document.getElementById('note').value;

        if (puntoControllo === "") {
            document.getElementById('puntoControlloError').textContent = "Seleziona un punto di controllo.";
            document.getElementById('puntoControlloError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('puntoControlloError').classList.remove('visible');
        }

        if (addetto === "") {
            document.getElementById('addettoError').textContent = "Seleziona un addetto.";
            document.getElementById('addettoError').classList.add('visible');
            isValid = false;
        } else {
            document.getElementById('addettoError').classList.remove('visible');
        }

        if (isValid) {
            alert("Controllo modificato con successo!");
            modificaForm.reset();
            document.getElementById('modificaControlloSection').style.display = 'none';
        }
    });
});

function modificaControllo(idControllo) {
    // Simula il caricamento dei dati del controllo
    const controllo = {
        puntoControllo: "1",
        addetto: "1",
        dataOraInizio: "2023-10-01T10:00",
        dataOraFine: "2023-10-01T10:15",
        esito: "Nessuna segnalazione",
        dazioDoganale: "0.00",
        note: "Tutto in regola"
    };

    // Popola il form con i dati del controllo
    document.getElementById('puntoControllo').value = controllo.puntoControllo;
    document.getElementById('addetto').value = controllo.addetto;
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