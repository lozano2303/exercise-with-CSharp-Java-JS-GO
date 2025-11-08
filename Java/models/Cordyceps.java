package models;

// Abstracción: clase base que define comportamiento común
public abstract class Cordyceps {
    // Encapsulamiento: atributo privado
    private String origin;

    // Constructor
    public Cordyceps(String origin) {
        this.origin = origin;
    }

    // Método sin retorno
    public void spread() {
        System.out.println("El hongo se propaga desde: " + origin);
    }

    // Método con retorno (abstracto - polimorfismo)
    public abstract String behavior();
}
