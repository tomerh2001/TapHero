using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHandler : MonoBehaviour
{
    public static int SphereCount = 1;
    public float CreationTime { get; set; }

    void Start()
    {
        CreationTime = Time.time;
    }

    void Update()
    {
        var t = Time.time;

        if (t - this.CreationTime >= 2)
        {
            //Destroy(this.gameObject);
            //GameManagerScript.AddSphere();
        }
    }
}
