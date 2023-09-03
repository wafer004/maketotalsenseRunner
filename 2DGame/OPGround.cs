using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPGround : MonoBehaviour
{
    public float speed;
    public float endX = -20.92f;
    public float startX = 20.91f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x<=endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
