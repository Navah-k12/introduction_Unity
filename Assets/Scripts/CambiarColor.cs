using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private SpriteRenderer spriteRender;
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spriteRender.color = Color.red;
        }
    }
}
