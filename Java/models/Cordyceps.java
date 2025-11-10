package models;

//abstraccion
public abstract class Cordyceps {
    //encapsulamiento con atributo privado
    private String origin;

    //constructor
    public Cordyceps(String origin) {
        this.origin = origin;
    }

    //metodo sin retorno
    public void spread() {
        System.out.println("El hongo se propaga desde: " + origin);
    }

    // metodo con retorno para polimorfismo
    public abstract String behavior();
}
