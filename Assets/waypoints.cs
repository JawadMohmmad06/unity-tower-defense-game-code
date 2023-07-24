using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour
{
    // Start is called before the first frame update
    public static Transform[] waypointss;
    void Awake()
    {
        waypointss = new Transform[transform.childCount];
        for (int i = 0; i < waypointss.Length; i++)
        {
            waypointss[i] = transform.GetChild(i);
        }
    }
}
