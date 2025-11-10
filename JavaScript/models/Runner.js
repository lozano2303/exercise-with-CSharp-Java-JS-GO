import Cordyceps from './Cordyceps.js';

class Runner extends Cordyceps {
    // constructor
    constructor(origin) {
        super(origin);
        this.aggressive = true;
    }

    // Método con retorno
    behavior() {
        return "En esta etapa del Cordyceps el infectado corre rápido y ataca sin pensar a lo primero que ve.";
    }

    //metodo sin retorno
    showAggression() {
        console.log("Esta etapa es agresiva?: " + this.aggressive + ". Son faciles de abatir a mano limpia, pero peligrosos.");
    }

    // funcion con retorno
    isAggressive() {
        return this.aggressive;
    }

    // funcion sin retorno
    calmDown() {
        this.aggressive = false;
    }
}

export default Runner;
