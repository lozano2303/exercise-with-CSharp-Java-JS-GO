import models.*;

public class Main {
    public static void main(String[] args) {
        System.out.println("Simulación de Cordyceps \n\nFase 1: Recently Infected (infectado reciente)\n");
        RecentlyInfected phase1 = new RecentlyInfected("Boston");
        phase1.spread();
        System.out.println(phase1.behavior());
        phase1.showHours();
        System.out.println(phase1.getHours());
        phase1.resetHours();
        System.out.println("\nPrimera fase del hongo Cordyceps completada.\n");
    }
}
