using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public Terrain terrain;
    public GameObject road;

    GameObject player;

    List<Terrain> terrains;
    List<GameObject> roads;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        terrains = new List<Terrain>();
        roads = new List<GameObject>();

        Terrain terrain1 = Instantiate(terrain, new Vector3(-250, -3, -10), Quaternion.identity, null);
        terrains.Add(terrain1);

        Terrain terrain2 = Instantiate(terrain, new Vector3(-250, -3, 490), Quaternion.identity, null);
        terrains.Add(terrain2);

        GameObject road1 = Instantiate(road, new Vector3(0, -2.6f, 240), Quaternion.identity, null);
        roads.Add(road1);

        GameObject road2 = Instantiate(road, new Vector3(0, -2.6f, 740), Quaternion.identity, null);
        roads.Add(road2);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > (terrains[0].transform.position.z + terrain.terrainData.size.z))
        {

            // CREATE NEW OBJECTS
            Terrain newTerrain = Instantiate(terrain, new Vector3(terrains[1].transform.position.x, terrains[1].transform.position.y, terrains[1].transform.position.z + terrain.terrainData.size.z), Quaternion.identity, null);
            terrains.Add(newTerrain);
            GameObject newRoad = Instantiate(road, new Vector3(roads[1].transform.position.x, roads[1].transform.position.y, roads[1].transform.position.z + terrain.terrainData.size.z), Quaternion.identity, null);
            roads.Add(newRoad);

            // DESTROY OLD OBJECTS (BEHIND PLAYER)
            Destroy(terrains[0]);
            Destroy(roads[0]);
        }

        // if the player reaches the second terrain
        // delete the first terrain
        // spawn a new one in front of the second original terrain

        // if the first terrain 
    }
}
