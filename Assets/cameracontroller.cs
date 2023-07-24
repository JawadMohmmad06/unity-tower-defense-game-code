using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class cameracontroller : MonoBehaviour
{
    private bool domovement=true;
    public float panspped = 30f;
    private float scrollspeed = 5f;
    public float miny = 10f;
    public float maxy = 80f;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            domovement=!domovement;
        }
        if(!domovement)
        {
            return;
        }
        if(Input.GetKey("w")||Input.mousePosition.y>=Screen.height-10f)
        {
            transform.Translate(Vector3.forward * panspped * Time.deltaTime,Space.World);
        }
        if (Input.GetKey("s") || Input.mousePosition.y <=10f)
        {
            transform.Translate(Vector3.back * panspped * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - 10f)
        {
            transform.Translate(Vector3.right * panspped * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.mousePosition.x<= 10f)
        {
            transform.Translate(Vector3.left * panspped * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll*1000 * scrollspeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, miny, maxy);
        transform.position = pos;

    }
}
