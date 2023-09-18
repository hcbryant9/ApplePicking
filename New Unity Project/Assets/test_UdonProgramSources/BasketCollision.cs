
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class BasketCollision : UdonSharpBehaviour
{

    public AppleCollectionManager appleCollectionManager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDED");
        if(other.gameObject.GetComponent<AppleDespawn>() != null)
        {
            Debug.Log("test passsed");
            //appleCollectionManager.CollectApple(other.gameObject);
        }
    }
    
}
