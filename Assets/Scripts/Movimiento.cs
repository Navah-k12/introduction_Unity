using System.Reflection.PortableExecutable;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
//   void Start()
//    {
        //ES lo que se inicializa por primera vez en el juego

//   }

    public float velocidad = 5f;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Flecha arriba");
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //Debug.Log("Flecha abajo");
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Flecha izquierda");
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Flecha derecha");
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        


    }
}
