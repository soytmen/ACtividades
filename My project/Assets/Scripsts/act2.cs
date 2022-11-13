using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class act2 : MonoBehaviour
{
    public string name = "Jowi";
    public string city = "Valencia";
    public void Start()
    {
        Debug.Log($"Hello, {name}! Welcome to {city}");
    }
}
