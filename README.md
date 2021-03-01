# csharp-simple-clean-code
C# minimal clean code example

# Como trabajo
Voy a ir realizando commits por cada paso, para evidenciar la forma que, bajo mi punto de vista, mejores resultados da.
Iré modificando este fichero agregando lo que se va a realizar en cada commit.
Puedes ir siguiendo el flujo de trabajo realizado a través de los commits.

# Escenario
Supongamos que tenemos una clase User (Entity) y un record Address (value object) ya que para nosotros no tiene entidad propia, en otro contexto podría ser una entidad.
Tenemos que permitir que se pueda modificar la dirección de usuario. Pues al tajo

# Primeros pasos
Como nos gusta tener el código organizadito y no nos da miedo tener 20 millones de clases pequeñas en un proyecto vamos a empezar creando un UseCase para realizar la actualización, un proyecto para testear la funcionalidad, y luego ya veremos que vamos necesitando.

Creamos la clase UseCases/UpdateUserAddress
Implementamos una actualización muy sencilla: Actualizamos el valor de User.PrimaryAddress con el nuevo objeto recibido
Creamos el test unitario que nos valida esta funcionalidad y a correr.

Todos los tests funcionando por lo que podemos dar por implementada la primera iteración

# Esto no sirve para nada
Efectivamente, esta implementación no sirve para nada, solo recibimos copiamos y devolvemos... pero ya tenemos una estructura, vamos a ir rellenando:
Vamos a validar los datos de la dirección y crear los test correspondientes para confirmar que se raliza correctamente la validación

# Pero Isra, que esto sigue sin hacer nada
Calma, calma, ya tenemos una entidad que actualiza su dirección y además validamos los datos de la misma, y negocio puede aprobar este funcionamiento porque tenemos una implementación muy limpia.

Ahora vamos a hacer que la aplicación funcione, vamos a crear una capa aplicación que se encargue de invocar a nuestro objeto de negocio.
Para ello necesitará tener acceso a algun repositorio para obtener los datos actuales del usuario, y para guardar los nuevos datos.