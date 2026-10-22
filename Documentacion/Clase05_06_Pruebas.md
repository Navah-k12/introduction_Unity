# Clases 05 y 06 — Pruebas y reflexión

## Escenas

| Clase | Escena | Script(s) |
|---|---|---|
| 05 | `Scenes/Clase05/Escena01_Transform` | `MovimientoTransform` |
| 05 | `Scenes/Clase05/Escena02_AddForce` | `ImpulsoPelota` |
| 05 | `Scenes/Clase05/Escena03_LinearVelocity` | `VelocidadPelota` |
| 05 | `Scenes/Clase05/Reto_Final_Equilibrio` | `NaveEquilibrio`, `CambiarColor` (tecla C), `ControlPelota` |
| 06 | `Scenes/Clase06/Escena01_InputMovement` | `MovimientoInput` |
| 06 | `Scenes/Clase06/Escena02_InputPhysics` | `MovimientoFisicoInput`, `CambioColorInput` |
| 06 | `Scenes/Clase06/Reto_Input_Equilibrio` | `NaveInput`, `CambioColorInput`, `PelotaInput` |

`Active Input Handling` está en **Both**: las escenas de la Clase 05 usan el sistema clásico y las de la Clase 06 el New Input System (`Settings/PlayerControls`).

## Clase 05 — Mejora D: experimentos

| Prueba | Fuerza de nave | Gravedad de pelota | Resultado observado |
|---|---|---|---|
| 1 | 4 | 1 | |
| 2 | 8 | 1 | |
| 3 | 8 | 2 | |

Configuración que facilita el equilibrio:

Configuración que lo dificulta:

## Clase 06 — Mejoras obligatorias

1. **Personalizar controles:** se agregó la tecla Enter a la acción `Jump` (además de Espacio) desde `PlayerControls`, sin modificar los scripts.
2. **Modificar la física:** la nave del reto tiene `Linear Damping = 2` para reducir la inercia.
3. **Detectar la caída:** la consola muestra "La pelota cayó al suelo." al tocar `Suelo`.
4. **Documentar pruebas:**

| Prueba | Fuerza de nave | Impulso de pelota | Gravedad de pelota | Resultado observado |
|---|---|---|---|---|
| 1 | | | | |
| 2 | | | | |
| 3 | | | | |

5. **Comparar sistemas:**

## Reflexión final

Responde con tus propias palabras las preguntas de la sección "Reflexión final" de cada clase.
