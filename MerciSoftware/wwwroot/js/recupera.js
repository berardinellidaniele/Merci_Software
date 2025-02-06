document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector("form");
    const emailInput = document.getElementById("email");

    form.addEventListener("submit", function (e) {
        const emailValue = emailInput.value.trim();

        if (!validateEmail(emailValue)) {
            e.preventDefault();
            alert("Inserisci un'email valida.");
        }
    });

    function validateEmail(email) {
        return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email);
    }
});
