using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefs;
    public Transform playerTransform;
    private float spawnZ = 10f;
    private float roadLenght = 5f;
    private int amnRoadOnScreen = 10;
    private float safeZone = 15f;
    private int lastPrefIndex = 0;


    private List<GameObject> activeRoad;



    private void Start() {
        activeRoad = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;


        for(int i = 0; i < amnRoadOnScreen; i++) {
            SpawnRoad();
        }
        


    }
    
    private void Update() {
        if(-playerTransform.position.z - safeZone > (spawnZ - amnRoadOnScreen * roadLenght)) {
            SpawnRoad();
            DeleteRoad();
        }
        
    }

    private void SpawnRoad(int roadIndex = -1) {
        GameObject go;
        go = Instantiate(tilePrefs [RandomPrefIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = -Vector3.forward * spawnZ;
        spawnZ += roadLenght;
        activeRoad.Add(go);

    }

    private void DeleteRoad() {
        Destroy(activeRoad[0]);
        activeRoad.RemoveAt(0);
    }
    
    private int RandomPrefIndex() {
        if(tilePrefs.Length <= 1) 
            return 0;

        int randomIndex = lastPrefIndex;
        while (randomIndex == lastPrefIndex) {
            randomIndex = Random.Range(0,tilePrefs.Length);
        }

        lastPrefIndex = randomIndex;
        return randomIndex;
    }

}
