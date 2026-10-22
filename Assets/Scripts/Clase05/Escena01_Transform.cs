using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float Velocidad = 5f;
    // Update is called once per frame
    void Update()
    {
        float movimiento = Input.GetAxisRaw("Horizontl");
    }
}
