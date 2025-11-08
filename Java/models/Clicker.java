package models;

public class Clicker extends Cordyceps {
    // Atributo privado
    private String sound;

    // Constructor
    public Clicker(String origin) {
        super(origin);
        this.sound = "¡Click!";
    }

    // Método con retorno
    @Override
    public String behavior() {
        return "En esta fase el hongo ha dejado ciego al infectado, usa ecolocalización para cazar.\nConsejo: no lo enfrentes a mano limpia, evita el enfrentamiento.";
    }

    // Método sin retorno
    public void emitSound() {
        System.out.println("Sonido emitido: " + sound);
    }

    // Función con retorno
    public String getSound() {
        return sound;
    }

    // Función sin retorno
    public void changeSound(String newSound) {
        sound = newSound;
        System.out.println("El chasqueador ha hecho un sonido distinto: " + sound);
    }
}
