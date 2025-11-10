package models;

public class Runner extends Cordyceps {
    //atributo 
    boolean aggressive;

    //constructor
    public Runner(String origin) {
        super(origin);
        this.aggressive = true;
    }

    //metodo con retorno
    @Override
    public String behavior() {
        return "En esta etapa del Cordyceps el infectado corre rápido y ataca sin pensar a lo primero que ve.";
    }

    //metodo sin retorno
    public void showAggression() {
        System.out.println("Esta etapa es agresiva?: " + aggressive + ". Son faciles de abatir a mano limpia, pero peligrosos.");
    }

    // funcion con retorno
    public boolean isAggressive() {
        return aggressive;
    }

    //funcion sin retorno
    public void calmDown() {
        aggressive = false;
    }
}
