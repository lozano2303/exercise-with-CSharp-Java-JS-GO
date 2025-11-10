package models

import "fmt"

// Interfaz Cordyceps (es como una clase abstracta)
type Cordyceps interface {
    Spread()            // Método sin retorno
    Behavior() string   // Método con retorno
}

// "herencia" (esto es una composicion)
type BaseCordyceps struct {
    origin string // Atributo privado simulado
}

// metodo comun sin retorno
func (b *BaseCordyceps) Spread() {
    fmt.Println("El hongo se propaga desde: " + b.origin)
}
