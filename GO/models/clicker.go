package models

import "fmt"

type Clicker struct {
    BaseCordyceps
    sound string // atributo privado
}

// constructor
func NewClicker(origin string) *Clicker {
    return &Clicker{
        BaseCordyceps: BaseCordyceps{origin: origin},
        sound:         "¡Click!",
    }
}

// Método con retorno
func (c *Clicker) Behavior() string {
    return "En esta fase el hongo ha dejado ciego al infectado, usa ecolocalización para cazar.\nConsejo: no lo enfrentes a mano limpia, evita el enfrentamiento."
}

// Método sin retorno
func (c *Clicker) EmitSound() {
    fmt.Println("Sonido emitido: " + c.sound)
}

// Función con retorno
func (c *Clicker) GetSound() string {
    return c.sound
}

// Función sin retorno con parámetro
func (c *Clicker) ChangeSound(newSound string) {
    c.sound = newSound
    fmt.Println("El chasqueador ha hecho un sonido distinto: " + c.sound)
}
