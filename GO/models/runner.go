package models

import "fmt"

type Runner struct {
    BaseCordyceps
    Aggressive bool //atributo publico
}

// constructor
func NewRunner(origin string) *Runner {
    return &Runner{
        BaseCordyceps: BaseCordyceps{origin: origin},
        Aggressive:    true,
    }
}

// metodo con retorno
func (r *Runner) Behavior() string {
    return "En esta etapa del Cordyceps el infectado corre rápido y ataca sin pensar a lo primero que ve."
}

// metodo sin retorno
func (r *Runner) ShowAggression() {
    fmt.Printf("Esta etapa es agresiva?: %v. Son faciles de abatir a mano limpia, pero peligrosos.\n", r.Aggressive)
}

//funcion con retorno
func (r *Runner) IsAggressive() bool {
    return r.Aggressive
}

//funcion sin retorno
func (r *Runner) CalmDown() {
    r.Aggressive = false
}
