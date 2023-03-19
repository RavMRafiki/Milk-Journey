using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarket : MonoBehaviour
{
    public float speed;
    public GameObject old1;
    public GameObject old2;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        if(transform.position.x > 15 || transform.position.x < -15){
            Destroy(gameObject);
        }
    }

}
