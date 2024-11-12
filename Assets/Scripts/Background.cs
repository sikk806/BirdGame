using Unity.VisualScripting;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float Speed = 2f;
    public float Width = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Width = spriteRenderer.sprite.bounds.size.x * transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Speed);

        if(transform.position.x < -Width)
        {
            transform.Translate(new Vector2(Width * 2, 0));
        }
    }
}
