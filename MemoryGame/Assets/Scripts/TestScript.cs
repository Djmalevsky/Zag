using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject PrefabTrail;
    public LineRenderer[] Line;
    bool Thing = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Clone4 = Instantiate(PrefabTrail, Line[2].transform);
        Clone4.GetComponent<ExampleClass>().XDistance = 0;
        Clone4.GetComponent<ExampleClass>().YDistance = 2;
        GameObject Clone = Instantiate(PrefabTrail, Line[1].transform); //animate first line
        Clone.GetComponent<ExampleClass>().XDistance = 0;
        Clone.GetComponent<ExampleClass>().YDistance = -2;

    }
    public void pp()
    {
        GameObject Clone = Instantiate(PrefabTrail, Line[1].transform); //animate first line
        Clone.GetComponent<ExampleClass>().XDistance = 0;
        Clone.GetComponent<ExampleClass>().YDistance = -3;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
