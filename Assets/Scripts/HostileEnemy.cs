using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HostileEnemy : MonoBehaviour
{
    public float maxMoveSpeed = 10f;
    Vector3 headingfor;

    public GameObject player;

    float currenttime = 0;
    float targetTime;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player Submarine");

        headingfor = player.transform.position;
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
            player = GameObject.Find("Player Submarine");
            headingfor = player.transform.position;
            targetTime = Random.Range(2.0f, 6.0f);
        }
        var step = maxMoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, headingfor, step);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Start");
        }
    }
}
