package models

import "fmt"

type Bloater struct {
    BaseCordyceps
    resistance int //atributo privado
}

// constructor
func NewBloater(origin string) *Bloater {
    return &Bloater{
        BaseCordyceps: BaseCordyceps{origin: origin},
        resistance:    100,
    }
}

//metodo con retorno
func (b *Bloater) Behavior() string {
    return "ultima fase del cordyceps, en esta fase lanza esporas y es muy difícil de eliminar.\nConsejo: evita el enfrentamiento directo y usa un lanzallamas."
}

// metodo sin retorno
func (b *Bloater) ShowResistance() {
    fmt.Printf("Resistencia: %d\n", b.resistance)
}

// funcion con retorno
func (b *Bloater) GetResistance() int {
    return b.resistance
}

//funcion sin retorno
func (b *Bloater) ReduceResistance() {
    b.resistance -= 10
}
