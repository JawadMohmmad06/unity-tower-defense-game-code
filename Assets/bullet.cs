using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public int dmg;

  public  void seek(Transform _trrget)
    {
        target= _trrget;
    }
    // Update is called once per frame
    void Update()
    {
        if(target==null)
        {
            Destroy(gameObject);
            return;
        }
       Vector3 dir=target.position-transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if(dir.magnitude<=distanceThisFrame)
        {
            Hittarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame);
    }
    void Hittarget()
    {
        Enemmy e = target.GetComponent<Enemmy>();
        if(e!=null)
        {
            e.gothit(dmg);
        }
        lives.hit++;
        money.mony += 10;
        Destroy(gameObject);
       
    }
}
