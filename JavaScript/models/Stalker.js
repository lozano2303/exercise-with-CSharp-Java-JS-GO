import Cordyceps from './Cordyceps.js';

class Stalker extends Cordyceps {
    constructor(origin) {
        super(origin);
        this.hidden = true;
    }

    behavior() {
        return "En esta fase del cordyceps sigue siendo muy parecida a la anterior, pero en esta se oculta y ataca por sorpresa.";
    }

    hide() {
        console.log("El acechador se ha escondido. Cuidado al acercarse.");
    }

    activateStealth() {
        this.hide();
    }

    isHidden() {
        return this.hidden;
    }

    reveal() {
        this.hidden = false;
    }
}

export default Stalker;
