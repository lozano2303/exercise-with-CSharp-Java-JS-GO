package models;
public class Stalker extends Cordyceps {
    // Atributo protegido
    protected boolean hidden;

    // Constructor
    public Stalker(String origin) {
        super(origin);
        this.hidden = true;
    }

    // Método con retorno
    @Override
    public String behavior() {
        return "En esta fase del cordyceps sigue siendo muy parecida a la anterior, pero en esta se oculta y ataca por sorpresa.";
    }

    // Método sin retorno protegido
    protected void hide() {
        System.out.println("El acechador se ha escondido. Cuidado al acercarse.");
    }

    // Método sin retorno público que accede al protegido
    public void activateStealth() {
        hide();
    }

    // Función con retorno
    public boolean isHidden() {
        return hidden;
    }

    // Función sin retorno
    public void reveal() {
        hidden = false;
    }
}
