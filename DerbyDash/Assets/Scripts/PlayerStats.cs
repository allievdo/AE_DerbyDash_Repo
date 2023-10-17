using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int currentMoney;
    public int currentCarrots;

    public static PlayerStats instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public int GetCurrentMoney()
    {
        return currentMoney;
    }

    public int GetCurrentCarrots()
    {
        return currentCarrots;
    }
}
