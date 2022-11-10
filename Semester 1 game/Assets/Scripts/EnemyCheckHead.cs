using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheckHead : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody2d;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BootCheck>())
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, 0f);
            rigidbody2d.AddForce(Vector2.up * 300f);
        }
        
    }
}
