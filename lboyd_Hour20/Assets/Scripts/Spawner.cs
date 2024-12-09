
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;

    public GameObject obstacle1Prefab;
    public GameObject obstacle2Prefab;
    public GameObject obstacle3Prefab;

    public float spawnCycle = .5f;

    GameManager manager;

    float elapsedTime;

    bool spawnPowerup = true;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;
            if (spawnPowerup)
                temp = Instantiate(powerupPrefab) as GameObject;
            else
            {
                float spawn = Random.Range(-3f, 3f);
                if (spawn <= -1)
                {
                    temp = Instantiate(obstacle1Prefab) as GameObject;
                }
                else if (spawn >= 1)
                {
                    temp = Instantiate(obstacle2Prefab) as GameObject;
                }
                else
                {
                    temp = Instantiate(obstacle3Prefab) as GameObject;
                }
            }
                
            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;
            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;
            elapsedTime = 0;
            spawnPowerup = !spawnPowerup;
        }
    }
}
