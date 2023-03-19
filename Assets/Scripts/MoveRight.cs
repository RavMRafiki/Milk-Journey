using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private float speed;
    void Start()
    {
        speed = Random.Range(10,15);
        float y = Random.Range(-3f,0f);
        transform.position = new Vector2(transform.position.x,y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        if(transform.position.x > 10){
            Destroy(gameObject);
        }
    }
}
