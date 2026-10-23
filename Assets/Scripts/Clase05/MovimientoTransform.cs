using UnityEngine;

public class MovimientoTransform : MonoBehaviour
{
    public float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        float movimiento = Input.GetAxisRaw("Horizontal");

        transform.Translate(
            Vector3.right * movimiento * velocidad * Time.deltaTime
        );
    }
}
