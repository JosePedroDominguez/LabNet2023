let numeroSecreto = Math.floor(Math.random() * 21);
let puntaje = 20;
let puntajeMaximo = 0;
let juegoActivo = true;

const inputAdivinar = document.getElementById("adivinar");
const botonVerificar = document.getElementById("verificar");
const botonReiniciar = document.getElementById("reiniciar");
const mensaje = document.getElementById("mensaje");
const mensajeGanador = document.getElementById("mensaje-ganador");
const puntajeMostrado = document.getElementById("puntaje");
const puntajeMaximoMostrado = document.getElementById("puntajeMaximo");

function reiniciarJuego() {
    numeroSecreto = Math.floor(Math.random() * 21);
    puntaje = 20;
    juegoActivo = true;
    mensaje.textContent = "Adivina un número entre 0 y 20:";
    mensajeGanador.style.display = "none";
    puntajeMostrado.textContent = puntaje;
    inputAdivinar.value = "";
}

function finalizarJuego(esGanador) {
    juegoActivo = false;
    if (esGanador) {
        mensajeGanador.textContent = `¡Correcto! El número secreto era ${numeroSecreto}. ¡Ganaste!`;
        mensajeGanador.style.color = "green";
        if (puntaje > puntajeMaximo) {
            puntajeMaximo = puntaje;
            puntajeMaximoMostrado.textContent = puntajeMaximo;
        }
    } else {
        mensajeGanador.textContent = `¡Ñiñiñiñiñ Perdiste Ñiñiñiñiñ! El número secreto era ${numeroSecreto}.`;
        mensajeGanador.style.color = "red";
    }
    mensajeGanador.style.display = "block";
}

botonVerificar.addEventListener("click", function () {
    if (!juegoActivo) {
        return;
    }

    const adivinanza = parseInt(inputAdivinar.value);

    if (isNaN(adivinanza) || adivinanza < 0 || adivinanza > 20) {
        mensaje.textContent = "Ingresa un número válido entre 0 y 20.";
    } else if (adivinanza === numeroSecreto) {
        finalizarJuego(true);
    } else {
        mensaje.textContent = adivinanza < numeroSecreto ? "Demasiado bajo." : "Demasiado alto.";
        puntaje--;
        puntajeMostrado.textContent = puntaje;
        if (puntaje === 0) {
            finalizarJuego(false);
        }
    }
});
botonReiniciar.addEventListener("click", function () {
    reiniciarJuego();
});
inputAdivinar.addEventListener("keydown", function (e) {
    if (e.key === "Enter") {
        botonVerificar.click();
    }
});
