using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act1 : MonoBehaviour
{
    public float variable1 = 1;
    public float variable2 = 2;
    public float variable3 = 3;
    public float sum;

    public void Start () {
        sum = variable1 + variable2 + variable3;
        Debug.Log(sum);
    }
}
