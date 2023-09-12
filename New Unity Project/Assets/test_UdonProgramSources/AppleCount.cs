
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AppleCount : UdonSharpBehaviour
{
    public int counter;

    private AudioSource collection;
    
    void Start()
    {
        collection = GetComponent<AudioSource>();
    }
    public void increaseCount()
    {
        Debug.Log("FUNCTION CALLED");
        collection.Play();
        counter++;
        Debug.Log(counter);
    }
}
