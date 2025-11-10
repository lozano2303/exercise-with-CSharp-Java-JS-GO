package models

import "fmt"

type Stalker struct {
    BaseCordyceps
    Hidden bool // Atributo publico
}

//constructor
func NewStalker(origin string) *Stalker {
    return &Stalker{
        BaseCordyceps: BaseCordyceps{origin: origin},
        Hidden:        true,
    }
}

// metodo con retorno
func (s *Stalker) Behavior() string {
    return "En esta fase del cordyceps sigue siendo muy parecida a la anterior, pero en esta se oculta y ataca por sorpresa."
}

//metodo sin retorno privado
func (s *Stalker) hide() {
    fmt.Println("El acechador se ha escondido. Cuidado al acercarse.")
}

// metodo sin retorno público que accede al privado
func (s *Stalker) ActivateStealth() {
    s.hide()
}

//funcion con retorno
func (s *Stalker) IsHidden() bool {
    return s.Hidden
}

//funcion sin retorno
func (s *Stalker) Reveal() {
    s.Hidden = false
}
