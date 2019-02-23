using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject player;

    public int spawnChance1;
    public int spawnChance2;
    public int spawnChance3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randomSpawnChance1 = Random.Range(0, 400);
        int randomSpawnChance2 = Random.Range(0, 400);
        int randomSpawnChance3 = Random.Range(0, 400);

        int spawnPos = Random.Range(-4, 6);

        if(randomSpawnChance1 < spawnChance1 && Time.timeScale == 1)
        {
            Instantiate(obstacle1, new Vector3(spawnPos, -1, player.transform.position.z + 40), new Quaternion());
        }

        if (randomSpawnChance2 < spawnChance2 && Time.timeScale == 1)
        {
            Instantiate(obstacle2, new Vector3(spawnPos, -1, player.transform.position.z + 40), new Quaternion());
        }

        if (randomSpawnChance3 < spawnChance3 && Time.timeScale == 1)
        {
            Instantiate(obstacle3, new Vector3(spawnPos, -1, player.transform.position.z + 40), new Quaternion());
        }
    }
}
