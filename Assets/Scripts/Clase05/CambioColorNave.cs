using UnityEngine;

public class CambioColorNave : MonoBehaviour
{
    public Color[] colores = { Color.cyan, Color.red, Color.green, Color.yellow };

    private SpriteRenderer spriteRender;
    private int indice;

    void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            indice = (indice + 1) % colores.Length;
            spriteRender.color = colores[indice];
        }
    }
}
