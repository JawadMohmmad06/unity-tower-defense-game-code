using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class Enemmy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;
    public int health=100;
    public Image healthbar;
    void Start()
    {
        health = 100;
        target = waypoints.waypointss[0];
    }
    void Update()
    {
        Vector3 dir=target.position-transform.position;
        transform.Translate(dir.normalized * speed*Time.deltaTime,Space.World);
        if(Vector3.Distance(transform.position, target.position)<=0.2f)
        {
            GetNextWypoint();
        }
    }
    public void gothit(int dmg)
    {
        health = health - dmg;
        healthbar.fillAmount = health/100f;
        
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
    void GetNextWypoint()
    {
        if (wavepointIndex < waypoints.waypointss.Length - 1)
        {
            
            wavepointIndex++;
            target = waypoints.waypointss[wavepointIndex];
        }
        else
        {
           
            lives.live--;
            Destroy(gameObject);
        }
    }
}
