import RecentlyInfected from './models/RecentlyInfected.js';

console.log("Simulación de Cordyceps \n\nFase 1: Recently Infected (infectado reciente)\n");
const phase1 = new RecentlyInfected("Boston");
phase1.spread();
console.log(phase1.behavior());
phase1.showHours();
console.log(phase1.getHours());
phase1.resetHours();
console.log("\nPrimera fase del hongo Cordyceps completada.\n");