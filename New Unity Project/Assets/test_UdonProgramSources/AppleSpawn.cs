using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AppleSpawn : UdonSharpBehaviour
{
    // apple prefabs
    public GameObject smallApplePrefab;
    //public GameObject mediumApplePrefab;
    public GameObject largeApplePrefab;

    // growth times
    public float spawnInterval = 10.0f;
    public float minGrowthTime = 30.0f;
    public float maxGrowthTime = 60.0f;
 
    private Transform[] spawnPoints;
    //private bool[] isSpawned;
    private float nextSpawnTime;

    void Start()
    {
        spawnPoints = GetComponentsInChildren<Transform>();
        //isSpawned = new bool[spawnPoints.Length];
        nextSpawnTime = Time.time + spawnInterval;
    }
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnApple();
            SetNextSpawnTime();
        }
    }
    void SpawnApple()
    {
        int randomIndex = Random.Range(1, spawnPoints.Length);

        //make sure to make it so that is spawned gets changed on collection
        //if (!isSpawned[randomIndex])
        //{
        Transform spawnPoint = spawnPoints[randomIndex];
        //isSpawned[randomIndex] = true;

        GameObject applePrefab;

            
        applePrefab = smallApplePrefab;


         Instantiate(applePrefab, spawnPoint.position, Quaternion.identity);
       // }
        





    }
    void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }
}