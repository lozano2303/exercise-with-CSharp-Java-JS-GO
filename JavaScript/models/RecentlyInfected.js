import Cordyceps from './Cordyceps.js';

class RecentlyInfected extends Cordyceps {
    // constructor
    constructor(origin) {
        super(origin);
        this._hours = 2; 
    }

    // Método con retorno
    behavior() {
        return "En esta fase todavía es humano, esta es la primera etapa de la infeccion.";
    }

    // Método sin retorno
    showHours() {
        console.log("Horas desde el contacto: " + this._hours + " horas. Esta fase puede durar de uno a dos dias, dependiendo de la persona infectada.");
    }

    // Función con retorno
    getHours() {
        return this._hours;
    }

    // Función sin retorno
    resetHours() {
        this._hours = 0;
    }
}

export default RecentlyInfected;
