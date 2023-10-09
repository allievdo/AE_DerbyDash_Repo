using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorsesForSale
{
    public enum HorseType
    {
        HorseNone, Horse1, Horse2, Horse3
    }

    public static int GetCost(HorseType horseType)
    {
        switch (horseType)
        {
            default:
            case HorseType.HorseNone: return 0;
            case HorseType.Horse1 : return 50;
            case HorseType.Horse2: return 100;
            case HorseType.Horse3: return 125;
        }
    }
}
