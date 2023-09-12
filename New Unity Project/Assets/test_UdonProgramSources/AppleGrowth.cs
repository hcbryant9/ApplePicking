
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AppleGrowth : UdonSharpBehaviour
{
    public GameObject large;
    public float growthDuration = 10.0f;

    private bool hasGrown;
    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        if (!hasGrown)
        {
            float elapsedTime = Time.time - startTime;

            if (elapsedTime >= growthDuration)
            {
                Replace();
            }
        }

        
    }
    void Replace()
    {
        Instantiate(large, transform.position, Quaternion.identity);

        Destroy(gameObject);

        hasGrown = true;
    }
}
