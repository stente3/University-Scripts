// Definición de la clase base
class LenguajeProgramacion {
  constructor(nombre, tipo) {
    this.nombre = nombre;
    this.tipo = tipo;
    this.caracteristicas = {
      version: "",
      creador: ""
    };
  }

  setVersion(version) {
    this.caracteristicas.version = version;
  }

  setCreador(creador) {
    this.caracteristicas.creador = creador;
  }

  getInfo() {
    return `Lenguaje: ${this.nombre}, Tipo: ${this.tipo}, Versión: ${this.caracteristicas.version}, Creador: ${this.caracteristicas.creador}`;
  }
  getInfoEnglish() {
    return `Language: ${this.nombre}, Type: ${this.tipo}, Version: ${this.caracteristicas.version}, Creador: ${this.caracteristicas.creador}`;
  }
}

// Clase derivada
class LenguajeWeb extends LenguajeProgramacion {
  constructor(nombre, tipo) {
    super(nombre, tipo);
    this.framework = {
      nombre: "",
      popularidad: ""
    };
  }

  setFramework(nombre, popularidad) {
    this.framework.nombre = nombre;
    this.framework.popularidad = popularidad;
  }

  getInfo() {
    const baseInfo = super.getInfo();
    return `${baseInfo}, Framework: ${this.framework.nombre}, Popularidad: ${this.framework.popularidad}`;
  }
}

// Objetos de las clases
const python = new LenguajeProgramacion("Python", "Interpretado");
python.setVersion("3.9");
python.setCreador("Guido van Rossum");

const javascript = new LenguajeWeb("JavaScript", "Interpretado");
javascript.setVersion("ES6");
javascript.setCreador("Brendan Eich");
javascript.setFramework("React", "Muy alta");

// Mostrar resultados
console.log(python.getInfo());
console.log(javascript.getInfo());
