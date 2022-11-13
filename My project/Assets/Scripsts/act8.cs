using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act8 : MonoBehaviour
{
    public string month = "january";
    void Start()
    {
        if (month == "january" || month == "march" || month == "may" || month == "july" || month == "agust" || month == "october" || month == "december")
            Debug.Log("Tiewne 31 dias");
        else if (month == "febraury")
            Debug.Log("Tiene 28 dias");
        else
            Debug.Log("Tiene 30 dias");
    }

    
}
