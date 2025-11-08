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

        System.out.println("Fase 4: Clicker (Chasqueador)\n");
        Clicker phase4 = new Clicker("Salt Lake City");
        phase4.spread();
        System.out.println(phase4.behavior());
        phase4.emitSound();
        System.out.println(phase4.getSound());
        phase4.changeSound("¡Chas!");
        System.out.println("\nCuarta fase del hongo Cordyceps completada.\n");

        System.out.println("Fase 5: Bloater (gordinflón o hinchado)\n");
        Bloater phase5 = new Bloater("Jackson");
        phase5.spread();
        System.out.println(phase5.behavior());
        phase5.showResistance();
        System.out.println(phase5.getResistance());
        phase5.reduceResistance();
        System.out.println("\nQuinta y última fase del hongo Cordyceps completada.\n");
    }
}
