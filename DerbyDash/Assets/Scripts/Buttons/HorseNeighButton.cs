using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseNeighButton : MonoBehaviour
{
    public AudioSource neighing;
    public void NeighButton ()
    {
        if (neighing != null )
        {
            neighing.Play();
            Debug.Log("Neighing");
        }
    }
}
