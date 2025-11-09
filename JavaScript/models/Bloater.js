import Cordyceps from './Cordyceps.js';

class Bloater extends Cordyceps {
    constructor(origin) {
        super(origin);
        this._resistance = 100;
    }

    behavior() {
        return "ultima fase del cordyceps, en esta fase lanza esporas y es muy difícil de eliminar.\nConsejo: evita el enfrentamiento directo y usa un lanzallamas.";
    }

    showResistance() {
        console.log("Resistencia: " + this._resistance);
    }

    getResistance() {
        return this._resistance;
    }

    reduceResistance() {
        this._resistance -= 10;
    }
}

export default Bloater;
