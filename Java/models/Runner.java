package models;

public class Runner extends Cordyceps {
    // Atributo con modificador default (package-private)
    boolean aggressive;

    // Constructor
    public Runner(String origin) {
        super(origin);
        this.aggressive = true;
    }

    // Método con retorno
    @Override
    public String behavior() {
        return "En esta etapa del Cordyceps el infectado corre rápido y ataca sin pensar a lo primero que ve.";
    }

    // Método sin retorno
    public void showAggression() {
        System.out.println("Esta etapa es agresiva?: " + aggressive + ". Son faciles de abatir a mano limpia, pero peligrosos.");
    }

    // Función con retorno
    public boolean isAggressive() {
        return aggressive;
    }

    // Función sin retorno
    public void calmDown() {
        aggressive = false;
    }
}
