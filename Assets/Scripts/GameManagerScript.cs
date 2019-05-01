using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    private static string SphereObjectPath = "Sphere";
    private static GameObject SphereObject;
    GameObject[] Spheres = GameObject.FindGameObjectsWithTag("Sphere");

    public static GameObject AddSphere()
    {
        return Instantiate(SphereObject);
    }

    void Start()
    {
        //object obj = Resources.Load("Sphere");
        //print(obj);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var mouseLoc = Input.mousePosition;
            var sphereLoc = Spheres[0].transform.position;
            if(mouseLoc.x == sphereLoc.x && mouseLoc.y == sphereLoc.y)
            {
                print("CLICK DETECTED!");
            }
        }
    }
}
