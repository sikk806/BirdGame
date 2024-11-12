using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float Speed = 2f;
    float randSpeed = 0f;
    int randNum = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randNum = Random.Range(0, 2);
        randSpeed = Random.Range(0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Speed);

        if(randNum == 0)
        {
            transform.Translate(Vector2.up * Time.deltaTime * randSpeed);
        }
        else
        {
            transform.Translate(Vector2.down * Time.deltaTime * randSpeed);
        }

        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
