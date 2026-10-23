using UnityEngine;

public class VelocidadPelota : MonoBehaviour
{
    public float velocidadHorizontal = 5f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = new Vector2(
            velocidadHorizontal,
            0f
        );
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
