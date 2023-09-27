using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;

    public GameObject fish;
    public GameObject turtle;
    public GameObject shark;

    float currenttime = 0;
    float targetTime = 6.0f;
    
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
            targetTime = Random.Range(4.0f, 10.0f);
            int spawncount = Random.Range(1, 5);
            Startspawn(spawncount);
        }
    }
    void Startspawn(int numspawn)
    {
        for (int i = 0; i < numspawn; i++) {
            int spawnerchoice = Random.Range(1, 5);
            int enemychoice = Random.Range(1, 10);
            
            if (spawnerchoice == 1) { 
                GameObject tospawn = spawn1;
                if (5 >= enemychoice && enemychoice >= 1) { 
                    GameObject enemyspawn = fish;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (8 >= enemychoice && enemychoice >= 6) { 
                    GameObject enemyspawn = turtle;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (enemychoice == 9) { 
                    GameObject enemyspawn = shark;
                    SpawnIn(tospawn, enemyspawn);
                }
            }
            if (spawnerchoice == 2)
            {
                GameObject tospawn = spawn2;
                if (5 >= enemychoice && enemychoice >= 1)
                {
                    GameObject enemyspawn = fish;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (8 >= enemychoice && enemychoice >= 6)
                {
                    GameObject enemyspawn = turtle;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (enemychoice == 9)
                {
                    GameObject enemyspawn = shark;
                    SpawnIn(tospawn, enemyspawn);
                }
            }
            if (spawnerchoice == 3)
            {
                GameObject tospawn = spawn3;
                if (5 >= enemychoice && enemychoice >= 1)
                {
                    GameObject enemyspawn = fish;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (8 >= enemychoice && enemychoice >= 6)
                {
                    GameObject enemyspawn = turtle;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (enemychoice == 9)
                {
                    GameObject enemyspawn = shark;
                    SpawnIn(tospawn, enemyspawn);
                }
            }
            if (spawnerchoice == 4)
            {
                GameObject tospawn = spawn4;
                if (5 >= enemychoice && enemychoice >= 1)
                {
                    GameObject enemyspawn = fish;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (8 >= enemychoice && enemychoice >= 6)
                {
                    GameObject enemyspawn = turtle;
                    SpawnIn(tospawn, enemyspawn);
                }
                if (enemychoice == 9)
                {
                    GameObject enemyspawn = shark;
                    SpawnIn(tospawn, enemyspawn);
                }
            }
        }
    }
    void SpawnIn(GameObject spawner, GameObject spawnedenemy)
    {
        Instantiate(spawnedenemy, spawner.transform);
    }
}
