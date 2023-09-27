using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            EnemyHealth enhealth = collision.gameObject.GetComponent<EnemyHealth>();
            collision.gameObject.GetComponent<EnemyHealth>().totalhealth -= 1;
        }
        if (collision.gameObject.tag == "Enemy1")
        {
            EnemyHealth enhealth = collision.gameObject.GetComponent<EnemyHealth>();
            collision.gameObject.GetComponent<EnemyHealth>().totalhealth -= 1;
        }
    }
}
