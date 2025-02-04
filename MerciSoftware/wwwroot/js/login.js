const signUpButton = document.getElementById('signUp');
const signInButton = document.getElementById('signIn');
const container = document.getElementById('container');


function activateSignUp() {
    container.classList.add("right-panel-active");
    history.pushState(null, '', '/register'); 
}


function activateSignIn() {
    container.classList.remove("right-panel-active");
    history.pushState(null, '', '/login'); 
}

signUpButton.addEventListener('click', () => {
    activateSignUp();
});

// Gestisci il click sul pulsante "Log In"
signInButton.addEventListener('click', () => {
    activateSignIn();
});

// Gestisci il submit del form di registrazione
document.getElementById('registerForm').addEventListener('submit', function (e) {
    e.preventDefault();

    const nome = document.getElementById('nome').value;
    const email = document.getElementById('email').value;
    const confirmEmail = document.getElementById('confirmEmail').value;

    if (email !== confirmEmail) {
        alert('Le email non coincidono');
        return;
    }

    fetch('/Account/Register', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'X-Requested-With': 'XMLHttpRequest'
        },
        body: JSON.stringify({ nome, email })
    })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                activateSignUp(); 
            } else {
                alert(data.message);
            }
        })
        .catch(error => {
            console.error('Errore:', error);
        });
});

window.addEventListener('popstate', () => {
    if (window.location.pathname === '/register') {
        container.classList.add("right-panel-active");
    } else {
        container.classList.remove("right-panel-active");
    }
});