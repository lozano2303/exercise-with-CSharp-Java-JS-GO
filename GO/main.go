package main

import (
    "fmt"
    "cordyceps/models"
)

func main() {
    // Fase 1: Recently Infected
    fmt.Println("Simulación de Cordyceps")
    fmt.Println("Fase 1: Recently Infected (infectado reciente)")
    fmt.Println()
    phase1 := models.NewRecentlyInfected("Boston")
    phase1.Spread()
    fmt.Println(phase1.Behavior())
    phase1.ShowHours()
    fmt.Println(phase1.GetHours())
    phase1.ResetHours()
    fmt.Println("Primera fase del hongo Cordyceps completada.")
    fmt.Println()

    // Fase 2: Runner
    fmt.Println("Fase 2: Runner (corredor agresivo)")
    fmt.Println()
    phase2 := models.NewRunner("Pittsburgh")
    phase2.Spread()
    fmt.Println(phase2.Behavior())
    phase2.ShowAggression()
    fmt.Println(phase2.IsAggressive())
    phase2.CalmDown()
    fmt.Println("Segunda fase del hongo Cordyceps completada.")
    fmt.Println()

    // Fase 3: Stalker
    fmt.Println("Fase 3: Stalker (acechador sigiloso)")
    fmt.Println()
    phase3 := models.NewStalker("Seattle")
    phase3.Spread()
    fmt.Println(phase3.Behavior())
    phase3.ActivateStealth()
    fmt.Println(phase3.IsHidden())
    phase3.Reveal()
    fmt.Println("Tercera fase del hongo Cordyceps completada.")
    fmt.Println()

    // Fase 4: Clicker
    fmt.Println("Fase 4: Clicker (infectado con ecolocalización)")
    fmt.Println()
    phase4 := models.NewClicker("Salt Lake City")
    phase4.Spread()
    fmt.Println(phase4.Behavior())
    phase4.EmitSound()
    fmt.Println(phase4.GetSound())
    phase4.ChangeSound("¡Chas!")
    fmt.Println("Cuarta fase del hongo Cordyceps completada.")
    fmt.Println()

    // Fase 5: Bloater
    fmt.Println("Fase 5: Bloater (gordinflón o hinchado)")
    fmt.Println()
    phase5 := models.NewBloater("Jackson")
    phase5.Spread()
    fmt.Println(phase5.Behavior())
    phase5.ShowResistance()
    fmt.Println(phase5.GetResistance())
    phase5.ReduceResistance()
    fmt.Println("Quinta y última fase del hongo Cordyceps completada.")
}
