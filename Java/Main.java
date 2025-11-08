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

        System.out.println("Fase 2: Runner (corredor agresivo)\n");
        Runner phase2 = new Runner("Pittsburgh");
        phase2.spread();
        System.out.println(phase2.behavior());
        phase2.showAggression();
        System.out.println(phase2.isAggressive());
        phase2.calmDown();
        System.out.println("\nSegunda fase del hongo Cordyceps completada.\n");

        System.out.println("Fase 3: Stalker (acechador sigiloso)\n");
        Stalker phase3 = new Stalker("Seattle");
        phase3.spread();
        System.out.println(phase3.behavior());
        phase3.activateStealth();
        System.out.println(phase3.isHidden());
        phase3.reveal();
        System.out.println("\nTercera fase del hongo Cordyceps completada.\n");
    }
}
