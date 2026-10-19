using UnityEngine;

public class MovimientoTransform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    public float velocidad = 10f;
    // Update is called once per frame
    void Update()
    {
        float movimiento = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * movimiento * velocidad * Time.deltaTime);
    }
}
