import RecentlyInfected from './models/RecentlyInfected.js';
import Runner from './models/Runner.js';

console.log("Simulación de Cordyceps \n\nFase 1: Recently Infected (infectado reciente)\n");
const phase1 = new RecentlyInfected("Boston");
phase1.spread();
console.log(phase1.behavior());
phase1.showHours();
console.log(phase1.getHours());
phase1.resetHours();
console.log("\nPrimera fase del hongo Cordyceps completada.\n");

console.log("Fase 2: Runner (corredor agresivo)\n");
const phase2 = new Runner("Pittsburgh");
phase2.spread();
console.log(phase2.behavior());
phase2.showAggression();
console.log(phase2.isAggressive());
phase2.calmDown();
console.log("\nSegunda fase del hongo Cordyceps completada.\n");