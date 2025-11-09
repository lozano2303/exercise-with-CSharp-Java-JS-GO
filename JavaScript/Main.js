import RecentlyInfected from './models/RecentlyInfected.js';
import Runner from './models/Runner.js';
import Stalker from './models/Stalker.js';
import Clicker from './models/Clicker.js';

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

console.log("Fase 3: Stalker (acechador sigiloso)\n");
const phase3 = new Stalker("Seattle");
phase3.spread();
console.log(phase3.behavior());
phase3.activateStealth();
console.log(phase3.isHidden());
phase3.reveal();
console.log("\nTercera fase del hongo Cordyceps completada.\n");

console.log("Fase 4: Clicker (infectado con ecolocalización)\n");
const phase4 = new Clicker("Salt Lake City");
phase4.spread();
console.log(phase4.behavior());
phase4.emitSound();
console.log(phase4.getSound());
phase4.changeSound("¡Chas!");
console.log("\nCuarta fase del hongo Cordyceps completada.\n");