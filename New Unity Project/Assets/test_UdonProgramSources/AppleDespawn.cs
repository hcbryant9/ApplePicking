
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AppleDespawn : UdonSharpBehaviour
{
    public AppleCollectionManager appleCollectionManager;
    public float despawnRate = 10f;
    public float freezeRate = 3f;
    
    //public int counter;
    
    private float startTime;
    private Rigidbody rb;
    //private bool isFrozen = true;
    void Start()
    {
        

        startTime = Time.time;
        
        rb = GetComponent<Rigidbody>();
        Freeze();
    }
    void Update()
    {
        float elapsedTime = Time.time - startTime;

        if (elapsedTime >= despawnRate)
        {
            DestroySelf();
        }

        if (elapsedTime >= freezeRate)
        {
            Unfreeze();
        }
    }
    void DestroySelf()
    {
        
        gameObject.SetActive(false);
        Destroy(gameObject, 1f);
    }
    void Freeze()
    {
        rb.isKinematic = true;
        //isFrozen = true;
    }
    void Unfreeze()
    {
        rb.isKinematic = false;
        //isFrozen = false;
    }
    void OnPickup()
    {
        AppleCollectionManager appleCollectionManager = GameObject.Find("AppleCollectionManager").GetComponent<AppleCollectionManager>();
        appleCollectionManager.score++;
        Debug.Log(appleCollectionManager.score);
        DestroySelf();

    }
}
