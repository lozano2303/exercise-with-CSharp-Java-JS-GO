package models;
public class RecentlyInfected extends Cordyceps {
    //atributo privado
    private int hours;

    //constructor
    public RecentlyInfected(String origin) {
        super(origin);
        this.hours = 2;
    }

    //metodo con retorno (polimorfismo)
    @Override
    public String behavior() {
        return "En esta fase todavía es humano, esta es la primera etapa de la infeccion.";
    }

    //metodo sin retorno
    public void showHours() {
        System.out.println("Horas desde el contacto: " + hours + "horas. Esta fase puede durar de uno a dos dias, dependiendo de la persona infectada.");
    }

    //funcion con retorno
    public int getHours() {
        return hours;
    }

    //funcion sin retorno
    public void resetHours() {
        hours = 0;
    }
}
