import Cordyceps from './Cordyceps.js';

class Clicker extends Cordyceps {
    constructor(origin) {
        super(origin);
        this._sound = "¡Click!";
    }

    behavior() {
        return "En esta fase el hongo ha dejado ciego al infectado, usa ecolocalización para cazar.\nConsejo: no lo enfrentes a mano limpia, evita el enfrentamiento.";
    }

    emitSound() {
        console.log("Sonido emitido: " + this._sound);
    }

    getSound() {
        return this._sound;
    }

    changeSound(newSound) {
        this._sound = newSound;
        console.log("El chasqueador ha hecho un sonido distinto: " + this._sound);
    }
}

export default Clicker;
