
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AppleCount : UdonSharpBehaviour
{
    private int counter = 0;

    void OnPickup()
    {
        Debug.Log("PICKEDUP");
        counter++;
    }
}
