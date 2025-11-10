package models

import "fmt"

type RecentlyInfected struct {
    BaseCordyceps
    hours int // Atributo privado
}

// constructor
func NewRecentlyInfected(origin string) *RecentlyInfected {
    return &RecentlyInfected{
        BaseCordyceps: BaseCordyceps{origin: origin},
        hours:         2,
    }
}

//metodo con retorno
func (r *RecentlyInfected) Behavior() string {
    return "En esta fase todavía es humano, esta es la primera etapa de la infeccion."
}

// metodo sin retorno
func (r *RecentlyInfected) ShowHours() {
    fmt.Printf("Horas desde el contacto: %d horas. Esta fase puede durar de uno a dos dias, dependiendo de la persona infectada.\n", r.hours)
}

//funcion con retorno
func (r *RecentlyInfected) GetHours() int {
    return r.hours
}

// funcion sin retorno
func (r *RecentlyInfected) ResetHours() {
    r.hours = 0
}
