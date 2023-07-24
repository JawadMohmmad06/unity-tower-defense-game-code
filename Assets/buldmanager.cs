using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buldmanager : MonoBehaviour
{
    public GameObject standardturrentPrefab;
    public GameObject misailturrentPrefab;
    private GameObject turretntoBuld;

    public static buldmanager instance;
    void Awake()
    {
        if(instance!=null)
        {
            return;
        }
        instance = this;
        
    }
    public void SetTorrentBuild(GameObject turrent)
    {
       if (turrent.tag=="st")
        { 
        turretntoBuld= standardturrentPrefab;
            

            }
        else
        {
            turretntoBuld = misailturrentPrefab;
        }
    }
   
    public GameObject GetTurrenttoBuld()
    {

        return turretntoBuld;
    }
}
