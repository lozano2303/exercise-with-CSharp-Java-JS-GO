import Cordyceps from './Cordyceps.js';

class Runner extends Cordyceps {
    constructor(origin) {
        super(origin);
        this.aggressive = true;
    }

    behavior() {
        return "En esta etapa del Cordyceps el infectado corre rápido y ataca sin pensar a lo primero que ve.";
    }

    showAggression() {
        console.log("Esta etapa es agresiva?: " + this.aggressive + ". Son faciles de abatir a mano limpia, pero peligrosos.");
    }

    isAggressive() {
        return this.aggressive;
    }

    calmDown() {
        this.aggressive = false;
    }
}

export default Runner;
