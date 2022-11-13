using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act4 : MonoBehaviour
{
    public int currentYear = 2022;
 public int birthYear = 2000;
 public int age;
    public void Start()
    {
        age = currentYear - birthYear;
        Debug.Log(age);
        Debug.Log($"If we are in the year {currentYear} and you were born in {birthYear}, you are {age} years old");
    }
}
