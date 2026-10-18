using UnityEngine;

public class Movimiento_Color : MonoBehaviour
{

    private Color_Nuevo Keyboard; // Referencia de una variable 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Keyboard = GetComponent<Color_Nuevo>();
    }

    public float Velocidad = 5f; // Por que funciona fuera de los metodos ?
 


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){

            Keyboard.NewColor(Color.green);
            transform.Translate(Vector3.up * Velocidad * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A)){

            Keyboard.NewColor(Color.yellow);
            transform.Translate(Vector3.left * Velocidad * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)){

            Keyboard.NewColor(Color.red);
            transform.Translate(Vector3.down * Velocidad * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
            Keyboard.NewColor(Color.blue);
            transform.Translate(Vector3.right * Velocidad * Time.deltaTime);
        }
    }
}
