package models;

public class Bloater extends Cordyceps {
    // Atributo privado
    private int resistance;

    // Constructor
    public Bloater(String origin) {
        super(origin);
        this.resistance = 100;
    }

    // Método con retorno
    @Override
    public String behavior() {
        return "ultima fase del cordyceps, en esta fase lanza esporas y es muy difícil de eliminar.\nConsejo: evita el enfrentamiento directo y usa un lanzallamas.";
    }

    // Método sin retorno
    public void showResistance() {
        System.out.println("Resistencia: " + resistance);
    }

    // Función con retorno
    public int getResistance() {
        return resistance;
    }

    // Función sin retorno
    public void reduceResistance() {
        resistance -= 10;
    }
}
