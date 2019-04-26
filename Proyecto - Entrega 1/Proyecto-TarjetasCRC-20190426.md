# PROGRAMACIÓN 2 - 2019

### EQUIPO 5 : Sofía, Fausto, Matías, Marcelo.

## INTRODUCCIÓN

### El centro Ignis, de acuerdo a la presentación realizada por Natalia y Carolina, necesita una aplicación que permita la administración de recursos para proyectos. Para este caso en particular, el centro Ignis cumple el rol de facilitador de recursos humanos (técnicos calificados), siendo un intermediario entre el cliente que tiene un proyecto a desarrollar y los técnicos que necesita contratar.

## REQUISITOS DE LA APP

* Mantener una base de datos de:
    * clientes.
    * técnicos.
    * proyectos.
    * solicitudes de clientes.

* Permitir a los clientes:
    * registrar sus proyectos. 
    * registrar solicitudes por los técnicos que necesita.

* Permitir a los técnicos:
    * registrarse como técnico.
    * postularse hasta un máximo de 3 roles.

* Permitir al operador de Ignis:
    * asignar técnicos a los proyectos a partir de las solicitudes.
    * mantener un registro de costo por hora.

* Ignis debe poder contar con la siguiente información:
    * informe de un cliente y sus proyectos y técnicos asignados.
    * informe de proyectos activos y concluidos.
    * informe de técnicos activos e inactivos.
    * informe de técnicos y sus proyectos realizados.

* Fronts:
    * front para clientes
    * front para técnicos
    * front para Ignis (administradores)

## CLIENTES, TÉCNICOS, PROYECTOS

### Los clientes son estudiantes o podrían ser egresados (se implementaría a futuro). Se contactan con el Centro Ignis presentando su proyecto y realizando solicitudes por los técnicos que necesitan.
### Al final del proyecto se calcula cuantas horas debe liquidarse para el pago del técnico.
### Agregamos la opción de activar o inactivar las cuentas de los clientes, puesto que interesa mantener datos históricos, aunque no se trabaje de nuevo con la persona.

### Los técnicos son estudiantes de la UCU que se registran en el centro. Pueden anotarse hasta en 3 roles (hay 22 disponibles). Pueden ser de cualquier año de la carrera, serán catalogados en "niveles de dificultad" que pueden encarar.
### Al igual que los clientes, los técnicos cuentan con la opción de activar o inactivar su cuenta a los efectos de mantener datos históricos pero que no estén disponibles, en caso de estar inactivos, impidiendo que puedan ser asignados a proyectos.

## CLASE "CLIENTE"

### Considerando EXPERT, decimos que esta clase es experta en construir un objeto "Cliente" y cambiar sus datos y su estado. 
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si cambia el constructor o se agregan nuevos métodos al objeto.

* Atributos:
    * Nombre completo (nombre y apellido)
    * Estado (activo, inactivo)

* Comportamientos:
    * activar()    método para activar un cliente.
    * inactivar()    método para inactivar un cliente y sus solicitudes y proyectos asociados.

* Colaboraciones:
    * Personas

* Implementa:
    * Interfase IPersona.

## CLASE "TECNICO"

### Considerando EXPERT, decimos que esta clase es experta en construir un objeto "Tecnico" y cambiar sus datos y su estado.
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si cambia el constructor o se agregan nuevos métodos al objeto.

* Atributos:
    * Nombre completo (nombre y apellido)
    * Presentación (texto)
    * Estudiante o Egresado
    * Año de egreso
    * Nivel de dificultad que puede encarar (básico, avanzado)
    * Estado (activo, inactivo)
    * Calificación de Centro Ignis (asignada por el administrador de Ignis)
    * Calificación de Clientes (asignada por clientes)

* Comportamientos:
    * activar()      método para activar un técnico.
    * inactivar()    método para inactivar un técnico.
    * modificarCalificaIgnis()     método para modificar la calificación realizada por Ignis
    * modificarCalificaCliente()   método para modificar la calificación realizada por Clientes

* Colaboraciones:
    * Personas

* Implementa:
    * Interfase IPersona.

## CLASE "PERSONAS"

### Considerando EXPERT, decimos que esta clase es experta en mantener una lista de personas en el sistema (clientes, técnicos).
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si hay modificaciones sobre las listas o se agrega otra a futuro.

* Atributos:
    * ListaClientes.
    * ListaTecnicos.

* Comportamientos:
    * actualizarLista() 	método para actualizar las listas al inicio o al agregar o quitar objetos.

* Colaboraciones:
    * Cliente
    * Tecnico

* Implementa:
    * Clase abstracta "AdminListas"
    
## INTERFASE "IPERSONA"

### Basándonos en el patrón de Polimorfismo, creamos esta interfase para activar o desactivar la cuenta de un objeto Cliente o de un objeto Tecnico.
### Identificamos que ambos objetos comparten los mismos tipos.

* Comportamientos:
    * activar()
    * inactivar()

* Implementada por:
    * clase "Cliente"
    * clase "Tecnico"

## CLASE "PROYECTO"

### Considerando EXPERT, esta clase es experta en construir un objeto "Proyecto" y mantener sus datos.
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si se necesita modificar el constructor o agregar nuevos comportamientos.

* Atributos:
    * Nombre
    * Presentación (texto)
    * Estado (activo, concluido)
    * Lista de Solicitudes

* Comportamientos:
    * agregarProyecto() 	método para agregar el proyecto al sistema luego de construido el objeto. Dispara actualizarListaProyectos() de la clase Proyectos y también guarda un registro nuevo en los archivos de texto.
    * agregarSolicitud() 	método para agregar una solicitud de un técnico a las lista de solicitudes.
    * reactivarProyecto()      método para marcar como reactivar un proyecto.
    * concluirProyecto()    método para marcar como concluido un proyecto.

* Colaboraciones:
    * Proyectos.
    * Solicitud.

## CLASE "PROYECTOS"

### Esta clase tiene como responsabilidad mantener una lista de proyectos y actualizar la lista al inicio de la app, luego de agregar un nuevo proyecto o cambiar el estado de uno existente.

### Considerando EXPERT, decimos que esta clase es experta por mantener una lista de objetos de tipo "Proyecto".
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si se modifica como se utiliza la misma o se agregan nuevos comportamientos.

* Atributos:
    * Lista de Proyectos

* Comportamientos:
    * actualizarLista() 	método para actualizar la lista al inicio de la app, luego de agregar un nuevo proyecto o cambiar el estado de uno existente.

* Colaboraciones:
    * Proyecto

* Implementa:
    * Clase abstracta "AdminListas"

## CLASE "SOLICITUD"

### Los clientes ingresaran una solicitud por cada técnico que requiera su proyecto.
### Un proyecto podrá tener n solicitudes de técnicos, no hay una limitación establecida por Ignis.
### Por ejemplo, para un proyecto "A" el cliente puede solicitar 5 o más técnicos especializados en distintos roles.

### Considerando EXPERT, esta clase es experta en construir una solicitud de técnico.
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si cambia el constructor o se agregan comportamientos.

* Atributos:
    * solicitud_Rol
    * solicitud_Nivel
    * solicitud_Observaciones

* Colaboraciones:
    * Proyecto.

## CLASE "ROL"

### Considerando EXPERT, esta clase es experta en construir un rol (especialización de los técnicos).
### Cumple con SRP ya que está es su única responsabilidad y solo cambia si se modifica el constructor o se agregan comportamientos.

* Atributos:
    * Identificador, título principal.
    * Descripción, de la actividad que desarrolla.

* Colaboraciones:
    * Roles

## CLASE "ROLES"

### Esta clase tiene como responsabilidad mantener una lista de los roles y actualizar la lista al inicio de la app o luego de agregar un nuevo rol.

### Considerando EXPERT, decimos que esta clase es experta porque su función es solo mantener una lista de objetos de tipo "Roles".
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si se modifican o agregan comportamientos.

* Atributos:
    * listaRoles[]

* Comportamientos:
    * actualizarLista() 	método para actualizar la lista.

* Colaboraciones:
    * Rol

* Implementa:
    * Clase abstracta "AdminListas"

## CLASE ABSTRACTA "AdminListas"

### Implementamos esta clase abstracta ya que identificamos que las clases Persona, Roles y Proyectos tienen listas que deben ser actualizadas. Como comparten este mismo tipo, podemos aplicar una clase abstracta, una en algunas clases realizamos un override del método ya que el comportamiento debe ser distinto a las demás clases.

* Comportamientos:
    * actualizarLista()

* Implementada por:
    * clase "Personas"
    * clase "Roles"
    * clase "Proyectos"

## COSTOS

### Cada técnico realiza 'n' horas, que serán pagas por el cliente a determinado precio.

## CLASE "COSTO"

### Según EXPERT, esta clase es experta porque su función es mantener la información del costo según categoría.
### Cumple con SRP ya que esta es su única responsabilidad y solo cambia si se modifican sus valores o se agregan comportamientos.

* Atributos:
    * Categoria
    * CostoPorHora

* Comportamiento:
    * modificarCostoPorHora()

## CLASE "CONFIG"

### Existen determinados parámetros de la aplicación que podrían variar a futuro pero que no deben ser manipulados por los usuarios.
### Establecemos una clase de "configuración general" para mantener los mismos.

* Atributos:
    * limiteRolesPorTecnico (máx. 3 concurrentes).
    * limiteProyectosPorTecnico (máx. 3 concurrentes).
    * limiteAñosEgresados (ej. 1, 2 o 3 años máximo).

* Comportamientos:
    * modificarRolesPorTecnico()
    * modificarProyectosPorTecnico()
    * modificarAñosEgresados()

## CLASE "dbFormato"

### A los efectos de mantener la información de los objetos en forma local, esta clase recibe los atributos de un objeto, genera una línea a partir de los mismos y la guarda en un archivo de texto. Al inicio de la aplicación esta clase lee los datos y genera los objetos a partir de la información almacenada.

* Comportamientos:
    * CodificarLineaTxt()
    * DecodificarLineaTxt()

* Colaboradores:
    * dbArchivo

## CLASE "dbArchivo"

### A los efectos de mantener la información de los objetos en forma local, esta clase recibe los atributos de un objeto, genera una línea a partir de los mismos y la guarda en un archivo de texto. Al inicio de la aplicación esta clase lee los datos y genera los objetos a partir de la información almacenada.

* Comportamientos:
    * GuardarLinea()
    * EliminarLinea()
    * LeerLineas() = leer todo el archivo.

* Colaboradores:
    * dbFormato

