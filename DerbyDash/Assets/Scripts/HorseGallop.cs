using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseGallop : MonoBehaviour
{
    public AudioSource gallop;

    public void Gallop()
    {
        gallop.Play();
        Debug.Log("Horse gallop sound");
    }
}
