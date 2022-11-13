using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act5 : MonoBehaviour
{
    public int num1 = 3;
    public int num2 = 4;
    public void Start()
    {
        if (num1 > num2) { Debug.Log($"{num1} es mayor");}
        else {
            Debug.Log("{num2} es mayor");
                }

    }
    

}
