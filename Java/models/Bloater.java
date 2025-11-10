package models;

public class Bloater extends Cordyceps {
    //atributo privado
    private int resistance;

    // constructor
    public Bloater(String origin) {
        super(origin);
        this.resistance = 100;
    }

    //metodo con retorno
    @Override
    public String behavior() {
        return "ultima fase del cordyceps, en esta fase lanza esporas y es muy difícil de eliminar.\nConsejo: evita el enfrentamiento directo y usa un lanzallamas.";
    }

    // metodo sin retorno
    public void showResistance() {
        System.out.println("Resistencia: " + resistance);
    }

    // funcion con retorno
    public int getResistance() {
        return resistance;
    }

    //fuuncion sin retorno
    public void reduceResistance() {
        resistance -= 10;
    }
}
