$(document).ready(function () {
    $('#passeggeroForm').on('submit', function (e) {
        let isValid = true;

        let nome = $('#nome').val().trim();
        let cognome = $('#cognome').val().trim();
        let nazionalita = $('#nazionalita').val().trim();
        let numDocumento = $('#numDocumento').val().trim();
        let aeroportoProvenienza = $('#aeroportoProvenienza').val().trim();
        let aeroportoDestinazione = $('#aeroportoDestinazione').val().trim();
        let motivoViaggio = $('#motivoViaggio').val().trim();

        console.log("📡 Dati inviati:", {
            nome, cognome, nazionalita, numDocumento, aeroportoProvenienza, aeroportoDestinazione, motivoViaggio
        });

        // Controllo Nome
        if (nome === "" || !/^[A-Za-z ]+$/.test(nome)) {
            $('#nomeError').text("Inserisci un nome valido (solo lettere).").addClass('visible');
            isValid = false;
        } else {
            $('#nomeError').removeClass('visible');
        }

        // Controllo Cognome
        if (cognome === "" || !/^[A-Za-z ]+$/.test(cognome)) {
            $('#cognomeError').text("Inserisci un cognome valido (solo lettere).").addClass('visible');
            isValid = false;
        } else {
            $('#cognomeError').removeClass('visible');
        }

        // Controllo Numero Documento
        if (numDocumento === "" || !/^[A-Za-z0-9]{6,12}$/.test(numDocumento)) {
            $('#numDocumentoError').text("Inserisci un numero documento valido (6-12 caratteri alfanumerici).").addClass('visible');
            isValid = false;
        } else {
            $('#numDocumentoError').removeClass('visible');
        }

        // Se i dati non sono validi, blocca l'invio del form
        if (!isValid) {
            console.log("❌ Dati non validi, invio annullato.");
            e.preventDefault(); // Evita che il form venga inviato
        } else {
            console.log("✅ Dati validi, invio del form...");
        }
    });
});
