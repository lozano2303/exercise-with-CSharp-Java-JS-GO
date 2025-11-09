// Abstracción: clase base que define comportamiento común
class Cordyceps {
    constructor(origin) {
        // Encapsulamiento
        this._origin = origin || "Desconocido";
    }

    // Método sin retorno
    spread() {
        console.log("El hongo se propaga desde: " + this._origin);
    }

    // Método con retorno (polimorfismo)
    behavior() {
        throw new Error("Este método debe ser implementado por la subclase.");
    }
}

export default Cordyceps;
