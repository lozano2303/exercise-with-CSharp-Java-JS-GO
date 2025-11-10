import Cordyceps from './Cordyceps.js';

class Clicker extends Cordyceps {
    //constructor
    constructor(origin) {
        super(origin);
        this._sound = "¡Click!";
    }

    //metodo con retorno
    behavior() {
        return "En esta fase el hongo ha dejado ciego al infectado, usa ecolocalización para cazar.\nConsejo: no lo enfrentes a mano limpia, evita el enfrentamiento.";
    }

    //metodo sin retorno
    emitSound() {
        console.log("Sonido emitido: " + this._sound);
    }

    // funcion con retorno
    getSound() {
        return this._sound;
    }

    //funcion sin retorno con parametro
    changeSound(newSound) {
        this._sound = newSound;
        console.log("El chasqueador ha hecho un sonido distinto: " + this._sound);
    }
}

export default Clicker;
