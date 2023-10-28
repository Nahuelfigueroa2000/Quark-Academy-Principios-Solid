# Quark-Academy-Principios-Solid
# Principios SOLID en C# :computer:

Este repositorio de muestra demuestra la aplicación de los cinco principios SOLID en C# utilizando ejemplos simples en Visual Studio.

## Principios SOLID :memo:

Los principios SOLID son un conjunto de directrices que promueven el diseño de software limpio, mantenible y escalable. A continuación, se muestran ejemplos de cada uno de los cinco principios SOLID:

### 1. Principio de Responsabilidad Única (SRP) :dart:

El [Principio de Responsabilidad Única](https://en.wikipedia.org/wiki/Single-responsibility_principle) establece que una clase debe tener una única razón para cambiar. En este ejemplo, hemos creado una clase `Empleado` que almacena información de los empleados y una clase `CalculadoraSalario` que calcula los salarios de los empleados, siguiendo el SRP.

### 2. Principio de Abierto/Cerrado (OCP) :lock:

El [Principio de Abierto/Cerrado](https://en.wikipedia.org/wiki/Open/closed_principle) establece que las clases deben estar abiertas para la extensión pero cerradas para la modificación. Hemos extendido la funcionalidad sin modificar las clases existentes al agregar una nueva clase `CalculadoraBonos` que calcula los bonos de los empleados.

### 3. Principio de Sustitución de Liskov (LSP) :twisted_rightwards_arrows:

El [Principio de Sustitución de Liskov](https://en.wikipedia.org/wiki/Liskov_substitution_principle) asegura que los objetos de una clase derivada puedan reemplazar objetos de la clase base sin problemas. En nuestro ejemplo, creamos subclases de `Empleado` que cumplen con el LSP.

### 4. Principio de Segregación de Interfaz (ISP) :v:

El [Principio de Segregación de Interfaz](https://en.wikipedia.org/wiki/Interface_segregation_principle) divide interfaces grandes en interfaces más pequeñas y específicas. Hemos dividido una interfaz original en interfaces segregadas para generar informes de empleados.

### 5. Principio de Inversión de Dependencia (DIP) :recycle:

El [Principio de Inversión de Dependencia](https://en.wikipedia.org/wiki/Dependency_inversion_principle) asegura que los módulos de alto nivel no dependan directamente de módulos de bajo nivel. En nuestro ejemplo, utilizamos la inyección de dependencias para que las clases de alto nivel no dependan directamente de `GestorDeBaseDeDatos`.

## Cómo ejecutar los ejemplos :rocket:

1. Clona este repositorio en tu máquina local.
2. Abre la solución en Visual Studio.
3. Explora y ejecuta los ejemplos en Visual Studio.

## Contribuciones :bulb:

¡Siéntete libre de contribuir y mejorar estos ejemplos! Si tienes ideas para ejemplos adicionales o mejoras en la presentación, no dudes en hacer una solicitud de extracción.

¡Gracias por visitar este repositorio! :star2:
