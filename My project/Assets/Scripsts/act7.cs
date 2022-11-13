using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act7 : MonoBehaviour
{
  public string letter = "a";
        public void Start () {
    if (letter != "a" || letter != "e" || letter != "i" || letter != "o" || letter != "u"  ) 
        Debug.Log("Es consonante");
            else Debug.Log("Es vocal");
    
}
}
