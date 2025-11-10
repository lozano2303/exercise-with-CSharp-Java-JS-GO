import Cordyceps from './Cordyceps.js';

class Stalker extends Cordyceps {
    //constructor
    constructor(origin) {
        super(origin);
        this.hidden = true;
    }

    //metodo con retorno
    behavior() {
        return "En esta fase del cordyceps sigue siendo muy parecida a la anterior, pero en esta se oculta y ataca por sorpresa.";
    }

    //metodo sin retorno
    hide() {
        console.log("El acechador se ha escondido. Cuidado al acercarse.");
    }

    // metodo sin retorno
    activateStealth() {
        this.hide();
    }

    // funcion con retorno
    isHidden() {
        return this.hidden;
    }

    // funcion sin retorno
    reveal() {
        this.hidden = false;
    }
}

export default Stalker;
