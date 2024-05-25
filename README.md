# En esta rama

El codigo tiene como objetivo mostrar una de las maneras posibles para realizar TDD en EF utilizando [SqlLite](https://www.sqlite.org/) lo cuales les permite tener la base de datos en memoria creandola y eliminandola en cada test.

# Estrucutra Importante.
## DataAccess
1. contiene los repositorios para manejar las entidades
2. Contiene el context de configuración del acceso a base de datos
3. Contiene el ProgramTest.cs, el cual es el Program usado para los tests.

## FrontEnd
1. FrontEnd de la applicación.
2. Contiene el  Program.cs para correr la applicación. 

# Como se corren los Test
1. Con el objetivo de correr los tests siempre con una base de datos vacia y en memoria, se creo el ProgramTest, el cual instancia un service builder, similar al Program.cs (Ver `Program.cs` y `ProgramTest.cs`)
2. El `ProgramTest.cs` se le agregan los repositorios como `scoped` para luego ser usados en las instancias de los servicios en los tests.
3. En los tests se instanica el `ProgramTest` y luego el servicio que neccesita con los repositorios obtenidos del ProgramTest (ver el UserService.test.cs)
