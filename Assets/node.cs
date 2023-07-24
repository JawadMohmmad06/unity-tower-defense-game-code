using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class node : MonoBehaviour
{
    
    public TextMeshProUGUI socretest;
    public TextMeshProUGUI moneytxt;
    private GameObject turrent;
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    public buldmanager bm;
    private float lastClickTime = 0;
    private float doubleClickDelay = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        bm = buldmanager.instance;
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject()) { return; }
        if (bm.GetTurrenttoBuld() == null)
        {
            return;
        }
        rend.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    void OnMouseDown()
    {
       


        if (EventSystem.current.IsPointerOverGameObject()) { return; }
        if (bm.GetTurrenttoBuld()== null)
        {
            return;
        }
        if(turrent!=null)
        {
            money.mony += 50;
            Destroy(turrent);
            return;
        }
        GameObject turrenttobuild = buldmanager.instance.GetTurrenttoBuld();

        if(turrenttobuild.name== "Turret (1) 1") {
        if((money.mony-100)<0)
            {
                UnityEngine.Debug.Log("NO money");
                return;
            }
            money.mony = money.mony - 100;

        }
        else if( turrenttobuild.name == "misail")
        {
            if ((money.mony - 200) < 0)
            {
                UnityEngine.Debug.Log("NO money");
                return;
            }
            money.mony = money.mony - 200;

        }


        turrent =(GameObject) Instantiate(turrenttobuild, transform.position, transform.rotation);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
