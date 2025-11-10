package models;
public class Stalker extends Cordyceps {
    //atributo protegido
    protected boolean hidden;

    // constructor
    public Stalker(String origin) {
        super(origin);
        this.hidden = true;
    }

    //metodo con retorno
    @Override
    public String behavior() {
        return "En esta fase del cordyceps sigue siendo muy parecida a la anterior, pero en esta se oculta y ataca por sorpresa.";
    }

    // metodo sin retorno protegido
    protected void hide() {
        System.out.println("El acechador se ha escondido. Cuidado al acercarse.");
    }

    // Metodo sin retorno público que accede al protegido
    public void activateStealth() {
        hide();
    }

    // funcion con retorno
    public boolean isHidden() {
        return hidden;
    }

    //Funcion sin retorno
    public void reveal() {
        hidden = false;
    }
}
