import Cordyceps from './Cordyceps.js';

class RecentlyInfected extends Cordyceps {
    constructor(origin) {
        super(origin);
        this._hours = 2;
    }

    behavior() {
        return "En esta fase todavía es humano, esta es la primera etapa de la infeccion.";
    }

    showHours() {
        console.log("Horas desde el contacto: " + this._hours + " horas. Esta fase puede durar de uno a dos dias, dependiendo de la persona infectada.");
    }

    getHours() {
        return this._hours;
    }

    resetHours() {
        this._hours = 0;
    }
}

export default RecentlyInfected;
