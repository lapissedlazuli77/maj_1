using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    Vector2 currentVelocity;

    Vector2 headingfor = Vector2.zero;
    bool inmotion = false;

    public Bottle bottle;
    int ammoclip = 5;

    float currenttime = 0;
    float targetTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;
        if (currenttime > targetTime)
        {
            currenttime = 0;
            ammoclip++;
        }

        if (inmotion)
        {
            Vector2 currentpos = transform.position;
            
            if (currentpos == headingfor)
            {
                inmotion = false;
            }
            transform.position = Vector2.SmoothDamp(transform.position, headingfor, ref currentVelocity, smoothTime, maxMoveSpeed);
        } else
        {
            Vector3 mousePosi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePosi - transform.position;
            float angle = Vector2.SignedAngle(Vector2.up, direction);
            transform.eulerAngles = new Vector3(0, 0, angle);
        }

        if (Input.GetMouseButtonDown(0))
        {
            inmotion = true;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            headingfor = mousePosition;
        }
        if (Input.GetMouseButtonDown(1))
        {
            {
                if (ammoclip >= 1)
                {
                    ammoclip -= 1;
                    Vector3 rotation = transform.rotation.eulerAngles;
                    Quaternion quatrot = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
                    Bottle bott = (Bottle)Instantiate(bottle, transform.position, quatrot);
                    bott.GetComponent<Rigidbody2D>().AddForce(transform.up * 100);
                }
            }
        }
    }
}
