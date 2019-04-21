# PROGRAMACIÓN 2 - 2019

## EQUIPO 5 : Sofía, Fausto, Matías, Marcelo.

## PROYECTO IGNIS APP

### INTRODUCCIÓN

#### Tuvimos la presentación por parte de Natalia y Carolina.

#### Se pretende una aplicación que brinde al centro de un sistema de administración de técnicos y proyectos para el programa IGNIS CONVOCA. Este programa tiene como objetivo brindar a clientes que tienen un proyecto en desarrollo, la contratación de técnicos profesionales.

* Requisitos de la app
    * Base de técnicos
    * Visual Interna y Externa
        * Front para clientes
        * Front para técnicos
        * Front para Ignis (administradores)
    * Registro de proyectos
    * Formas de filtrar técnicos según proyecto
    * Reportes de información
        * Proyectos activos
        * Clientes inscriptos y clientes en actividad
        * Técnicos inscriptos y clientes en actividad

### CLIENTES

#### Los clientes pueden ser estudiantes o egresados. Se contactan con el Centro Ignis indicando el proyecto que tienen en desarrollo y el técnico que necesitan (fotográfos, sonidista, etc.).

* Clientes
    * Nombre y apellido
    * Proyectos en actividad
    * Proyectos concluidos

### TÉCNICOS

#### Los técnicos son estudiantes de la UCU que se registran en el centro. Pueden anotarse hasta en 3 roles (hay 22 disponibles). Pueden ser de cualquier año de la carrera, por lo que pueden catalogarse en "niveles de dificultad" que pueden encarar.

* Técnico
    * Nombre y apellido
    * Estudiante o Egresado
    * Año de egreso
    * Roles
    * Presentación (texto máx x palabras)
    * Proyectos en actividad
    * Proyectos concluidos
    * Horas realizadas
    * Calificación del Centro Ignis (la que le da el centro)
    * Calificación de Clientes 
    * Nivel de dificultad que puede encarar (básico, avanzado)
    * Variable para técnico activo / inactivo
    * Notas por parte del centro ignis sobre el técnico 

### PROYECTOS

#### Los proyectos son presentados por el clientes.

* Proyecto
    * Nombre y apellido
    * Roles
    * Presentación (texto máx x palabras)
    * Proyectos en actividad
    * Proyectos concluidos
    * Técnicos en actividad
    * Horas realizadas

### PAGOS

#### Cada técnico realiza equis horas, estas son pagas por el cliente.

#### El centro debe reportar estas horas a la UCU, por lo que debe contar con esta información.

* Pagos
    * Categoría
    * Costo por hora

### CONFIGURACIÓN

#### El centro necesita un lugar para configurar ciertos criterios de selección, para filtrar información y para establecer limitaciones.

* Ejemplos:
    * Limite de eventos en activo para cada técnico.
    * Limite de años trancurridos a partir de su egreso (ej. 1, 2 o 3 años máximo).

## CLASES

* CLASE: Clientes
    * Esta clase conoce los clientes que se registraron.
    * Responsabilidades
        * Nombre y apellido.
        * Proyectos en Marcha.
        * Proyectos Concluidos.
        * Estado (activo, inactivo).
        * altaCliente()
        * activarCliente()
        * inactivarCliente()
    * Colaboraciones
        * Usuarios.
        * Proyectos.

* CLASE: Técnicos
    * Esta clase conoce los técnicos que se registraron.
    * Responsabilidades
        * Nombre y apellido.
        * Proyectos en Marcha.
        * Proyectos Concluidos.
        * Roles (máx. 3).
        * Horas acumuladas.
        * Estado (activo, inactivo).
        * altaTecnico()
        * activarTecnico()
        * inactivarTecnico()
        * asignarTecnicoProyecto()
    * Colaboraciones
        * Usuarios.
        * Roles.

* CLASE: Usuarios
    * Esta clase conoce los usuarios del sistema.
    * Responsabilidades
        * Nombre y apellido.
        * Contaseña.
        * Perfil (cliente, técnico, ignis).
        * Estado (activo, inactivo).
        * altaUsuario()
        * activarUsuario()
        * inactivarUsuario()
        * cambiarContrasena()
    * Colaboraciones
        * Login.
        * Clientes.
        * Técnicos.

* CLASE: Autenticacion
    * Esta clase recibe usuario y contraseña a partir de una página inicial y presenta la siguiente ventana de acuerdo al perfil. Puede ser un cliente, un técnico o una operadora de Ignis.
    * Responsabilidades
        * login()
        * logout ()
    * Colaboraciones
        * Usuarios.

* CLASE: Proyecto
    * Esta clase conoce los proyectos en curso y realizados.
    * Responsabilidades
        * ID del proyecto (código único para identificar el proyecto).
        * Descripción.
        * Dificultad.
        * Horas estimadas.
        * Estado (activo, concluido, cancelado).
        * altaProyecto()
        * activarProyecto()
        * inactivarProyecto()
    * Colaboraciones
        * Clientes.
        * Técnicos.
        * Pagos.

* CLASE: Roles
    * Esta clase conoce los roles de los técnicos.
    * Responsabilidades
        * Descripción.
        * Estado.
        * altaRol()
        * activarRol()
        * inactivarRol()
    * Colaboraciones
        * Técnicos.
        * Proyecto.

* CLASE: Pagos
    * Esta clase conoce las categorías de pagos y el costo por hora.
    * Responsabilidades
        * Categoría.
        * Costo por hora.
        * modificarCostoPorHora()
    * Colaboraciones
        * Proyecto.
        * Clientes.
        * Técnicos.

* CLASE: Config
    * Esta clase conoce configuraciones generales del sistema.
    * Responsabilidades
        * Límite de roles por técnico.
        * Límite de proyectos por técnico.
        * modificarLimiteRoles()
        * modificarLimiteProyectos()
    * Colaboraciones
        * Roles.
        * Proyecto.

* CLASE: dbFormatter
    * Esta clase conoce los formatos, genera una linea a partir de los datos recibidos.
    * Responsabilidades
        * CodificarLineaTxt()
        * DecodificarLineaTxt()
    * Colaboraciones
        * dbTxtFiles

* CLASE: dbTxtFiles
    * Esta clase guarda, elimina o lee archivos de textos.
    * Responsabilidades
        * GuardarLinea()
        * EliminarLinea()
        * LeerLineas() = leer todo el archivo.
    * Colaboraciones
        * dbTxtFiles
