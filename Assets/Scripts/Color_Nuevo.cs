using UnityEngine;

public class Color_Nuevo : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    public void NewColor(Color color){
        spriteRender.color = color;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
