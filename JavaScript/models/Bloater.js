import Cordyceps from './Cordyceps.js';

class Bloater extends Cordyceps {
    //contructor
    constructor(origin) {
        super(origin);
        this._resistance = 100;
    }
    
    //metodo con retorno
    behavior() {
        return "ultima fase del cordyceps, en esta fase lanza esporas y es muy difícil de eliminar.\nConsejo: evita el enfrentamiento directo y usa un lanzallamas.";
    }

    //metodo sin retorno
    showResistance() {
        console.log("Resistencia: " + this._resistance);
    }

    //funcion con retorno
    getResistance() {
        return this._resistance;
    }

    //funcion sin retorno
    reduceResistance() {
        this._resistance -= 10;
    }
}

export default Bloater;
