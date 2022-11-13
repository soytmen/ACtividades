using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act6 : MonoBehaviour
{
    public int day = 4;
    public void Start () {

        if (day > 5)
            Debug.Log($"Day {day} belongs to the weekend");
        else Debug.Log($"Day {day} belongs to the week");
    }
}
