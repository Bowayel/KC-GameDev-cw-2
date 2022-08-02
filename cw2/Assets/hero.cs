using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = "yasuo";
        int age = 18;
        int height = 176+5;
        string superpower = "Air";
        int ageDifference = 19 - 18;
        
        print("the hero name is" + name + "and his age is" + age + "and his height" + height + "and his superpower" + superpower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
