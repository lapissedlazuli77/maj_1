using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PassiveEnemy : MonoBehaviour
{
    public float maxMoveSpeed = 10f;
    Vector3 headingfor = Vector3.zero;

    float currenttime = 0;
    float targetTime;

    // Start is called before the first frame update
    void Start()
    {
        headingfor.x = Random.Range(-10, 10);
        headingfor.y = Random.Range(-5, 5);

        targetTime = Random.Range(2.0f, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = headingfor - transform.position;
        float angle = Vector2.SignedAngle(Vector2.down, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);

        currenttime += Time.deltaTime;
        if (currenttime > targetTime)
        {
            currenttime = 0; 
            headingfor.x = Random.Range(-10, 10);
            headingfor.y = Random.Range(-5, 5);
            targetTime = Random.Range(2.0f, 6.0f);
        }
        var step = maxMoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, headingfor, step);

        if (transform.position == headingfor)
        {
            currenttime = 0;
            headingfor.x = Random.Range(-10, 10);
            headingfor.y = Random.Range(-5, 5);
            targetTime = Random.Range(2.0f, 6.0f);
        }
    }
}
