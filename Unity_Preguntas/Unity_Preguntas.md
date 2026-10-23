# Unity: preguntas de estudio (Clases 05 y 06)

Preguntas de la guía de la Clase 05 y del reto, con respuesta corta para repasar.

## Clase 05: Transform, fuerzas y velocidad

**1. ¿Cuál es la diferencia entre `transform.Translate` y `AddForce`?**
`Translate` mueve el objeto directamente, cambiando su posición, sin física: ignora masa, gravedad e inercia, y puede atravesar colisiones. `AddForce` aplica una fuerza a un `Rigidbody2D`; el motor de física calcula la aceleración según la masa, el damping y las colisiones.

**2. ¿Qué diferencia hay entre un impulso y asignar `linearVelocity`?**
`AddForce(..., ForceMode2D.Impulse)` suma un golpe instantáneo a la velocidad que ya tiene el objeto. `rb.linearVelocity = ...` sobrescribe la velocidad por completo, por eso se usa para fijar el movimiento (por ejemplo, el lanzamiento de un proyectil).

**3. ¿Qué papel tiene la gravedad?**
La controla el *Gravity Scale* del Rigidbody2D. Con 0 el objeto no cae (como la nave del reto), con 1 cae normal y con 2 cae el doble de rápido. Afecta cuánto sube un impulso y qué tan rápido baja.

**4. ¿Por qué se necesitan colliders?**
El Rigidbody2D solo aporta el movimiento; el collider define la forma con la que el objeto choca. Sin collider, la pelota atraviesa el suelo y no se disparan `OnCollisionEnter2D` ni los rebotes.

**5. ¿Qué propiedad ayuda a mejorar el equilibrio de la nave?**
El *Linear Damping* de la nave (frena su deslizamiento), además de la masa y la fuerza. Más damping y menos fuerza dan un control más fino. (Pon aquí la que tú comprobaste.)

**6. ¿Dónde se mueve con física, en `Update` o `FixedUpdate`?**
En `FixedUpdate`, que corre al ritmo de la física. El input discreto (`GetKeyDown`) se lee en `Update`.

**7. ¿Cómo se lanza un proyectil?**
Se le da un Rigidbody2D y se fija `linearVelocity` en la dirección del disparo (o un `AddForce` impulso una sola vez). La gravedad lo curva solo.

**8. ¿Qué cambiarías para una nave sin inercia?**
Aumentar mucho el Linear Damping o poner `linearVelocity` directo según el input en vez de `AddForce`.

## Preguntas de prueba del reto

- ¿Qué pasa si la fuerza de la nave baja de 8 a 4? Responde más lento y le cuesta sostener a la pelota.
- ¿Y si la gravedad de la pelota sube de 1 a 2? Cae más rápido y es más difícil equilibrarla.
- ¿Cómo se detecta que la pelota tocó el suelo? Con `OnCollisionEnter2D(Collision2D collision)` y `collision.gameObject.name == "Suelo"`.
- ¿Por qué `NaveEquilibrio` y `CambioColorNave` conviven? Son componentes distintos del mismo GameObject: uno mueve el Rigidbody2D y el otro cambia el color del SpriteRenderer.

## Clase 06: New Input System

**9. ¿Qué diferencia hay con el Input Manager antiguo?**
El Input System se basa en *acciones* (Move, Jump, ChangeColor) definidas en un asset de Input Actions. Se separa la acción del dispositivo (teclado, gamepad) en vez de leer teclas con `Input.GetKey`.

**10. ¿Cómo se recibe una acción en el script?**
Con el componente `PlayerInput` en modo *Send Messages*, que llama a métodos con el nombre `On` + acción: `OnMove(InputValue value)` y `OnChangeColor(InputValue value)`.

**11. ¿Cómo se lee el movimiento?**
`value.Get<Vector2>()` devuelve el eje; se guarda y se aplica en `FixedUpdate` con `rb.AddForce(movimiento * fuerza)`.

**12. ¿Para qué sirve `value.isPressed`?**
Para actuar solo al pulsar la tecla (un botón dispara el método al pulsar y al soltar).

**13. ¿Por qué `Input.GetAxisRaw` deja de funcionar en un proyecto con el New Input System?**
Porque en Project Settings > Player > Active Input Handling está activo solo el sistema nuevo. Hay que elegir *Both* o migrar los scripts.
