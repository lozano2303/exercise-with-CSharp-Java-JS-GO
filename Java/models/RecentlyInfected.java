package models;
public class RecentlyInfected extends Cordyceps {
    // Atributo privado
    private int hours;

    // Constructor
    public RecentlyInfected(String origin) {
        super(origin);
        this.hours = 2;
    }

    // Método con retorno
    @Override
    public String behavior() {
        return "En esta fase todavía es humano, esta es la primera etapa de la infeccion.";
    }

    // Método sin retorno
    public void showHours() {
        System.out.println("Horas desde el contacto: " + hours + "horas. Esta fase puede durar de uno a dos dias, dependiendo de la persona infectada.");
    }

    // Función con retorno
    public int getHours() {
        return hours;
    }

    // Función sin retorno
    public void resetHours() {
        hours = 0;
    }
}
