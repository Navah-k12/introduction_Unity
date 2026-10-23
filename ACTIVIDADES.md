# Verificación de actividades (15)

Repositorio: https://github.com/Navah-k12/introduction_Unity
Fecha de revisión: 2026-10-22

Leyenda: OK = existe y parece completa · REVISAR = existe pero incompleta o sin confirmar · FALTA = no está en el disco

| #  | Actividad | Archivos en el proyecto | Estado |
|----|-----------|-------------------------|--------|
| 1  | SampleScene (objetos simples) | `Assets/Scenes/SampleScene.unity` (3 cuadrados) | OK |
| 2  | Scene 1 (físicas básicas) | ¿`Assets/Scenes/Clases_01-04/Scena2.unity`? (Player + `Movimiento`, `CambiarColor`) | REVISAR: confirmar cuál es |
| 3  | Plinko | `Assets/Scenes/Clases_01-04/Plinko.unity` | OK |
| 4  | Script Movimiento (básico) | `Assets/Scripts/Clases_01-04/Movimiento.cs` | OK |
| 5  | Clase 3 Actividad 1 | ¿`Assets/Scenes/Clases_01-04/Personajes.unity` (Player, Enemy, Platform)? | REVISAR: confirmar cuál es |
| 6  | Nave | ¿`Assets/Scenes/Clases_01-04/RetoIntegradorScrips.unity`? (Square + `Movimiento_Color`, `Color_Nuevo`) | REVISAR: confirmar cuál es |
| 7  | Clase 4 Act. 1: movimiento con flechas | `Assets/Scripts/Clases_01-04/Movimiento.cs` (flechas/WASD) | REVISAR: sin escena propia |
| 8  | Clase 4 Act. 2: cambiar las teclas | `Assets/Scripts/Clases_01-04/` (`Movimiento_Color.cs`, `Color_Nuevo.cs`, `Subir_Space.cs`) | REVISAR: sin escena propia |
| 9  | Clase 5 Ej. 1: Transform | `Scenes/Clase05/Escena01_Transform.unity` + `Scripts/Clase05/MovimientoTransform.cs` | HECHO: Jugador en (-5,0,0), escala 1, velocidad 5 |
| 10 | Clase 5 Ej. 2: AddForce | `Scenes/Clase05/Escena02_AddForce.unity` + `ImpulsoPelota.cs` | OK |
| 11 | Clase 5 Ej. 3: LinearVelocity | `Scenes/Clase05/Escena03_LinearVelocity.unity` + `VelocidadPelota.cs` | OK (la guía usa velocidad 4, tiene 5) |
| 12 | Clase 6 Ej. 1: acciones de entrada | Restaurado desde git en `Scenes/Clase06/` + `Scripts/Clase06/` | OK, sin modificar |
| 13 | Clase 6 Ej. 2: mover personaje | `Scenes/Clase06/Escena01_InputMovement.unity` | OK, sin modificar |
| 14 | Clase 6 Ej. 3: fuerzas, impulso y color | `Scenes/Clase06/Escena02_InputPhysics.unity` | OK, sin modificar |
| 15 | Reto final: migrar la nave | `Scenes/Clase06/Reto_Input_Equilibrio.unity` | OK, sin modificar |

## Clase 05 (según la guía del repositorio)
- Ej. 1 corregido: nuevo `MovimientoTransform.cs` (Translate con Horizontal); se eliminó el script roto `Escena01_Transform.cs`.
- Reto final armado en `Scenes/Clase05/Reto_Final_Equilibrio.unity`:
  - Nave (0,-1) escala (3,0.5), Rigidbody2D gravedad 0, linear damping 1, `NaveEquilibrio` (fuerza 8).
  - Mejora A: `CambioColorNave.cs` (tecla C) convive con `NaveEquilibrio` en la Nave.
  - Pelota (0,0) escala 0.5, gravedad 1, `ControlPelota` (vel. 3, impulso 4 con Space).
  - Mejora C: `OnCollisionEnter2D` con el objeto "Suelo" muestra `Debug.Log("La pelota cayó al suelo.")`.
  - Suelo (0,-4) escala (14,1), estático.
- Mejoras B y D (pruebas y reflexión): ver `Clase05_Pruebas.md`. Están sin llenar porque requieren ejecutar la escena en Unity.

## Estructura
- `Assets/Scenes/` → `SampleScene` (Build Settings), `Clases_01-04/`, `Clase05/`
- `Assets/Scripts/` → `Clases_01-04/`, `Clase05/`
- `Assets/Sprites/Clase05/` → `Circle.png`, `RebotePelota.physicsMaterial2D`

## Pendientes
- Preguntas de estudio: `Unity_Preguntas/Unity_Preguntas.md`.
- Portada con fecha y enlace de GitHub.
