using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act9 : MonoBehaviour
{
    public int candys = 10;
    public int people = 5;
    void Start()
    {
        Debug.Log($"{candys/people} caramelos por persona y sobran {candys%people}");
    }

    
}
