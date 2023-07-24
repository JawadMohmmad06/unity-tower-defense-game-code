using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Torent : MonoBehaviour
{
    public float turnspeed = 10f;
    public Transform parttorotate;
    public Transform target;
    public float range = 5f;
    public string enemyTag = "enemy";
    public float firerate = 1f;
    private float firecountdown = 0f;
    public GameObject bulletprefab;
    public Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        Vector3 dir = target.position-transform.position;
        Quaternion lookrotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(parttorotate.rotation,lookrotation,Time.deltaTime*turnspeed).eulerAngles;
        parttorotate.rotation = Quaternion.Euler(0f, rotation.y,0f);

        if(firecountdown<=0f)
        {
            shoot();
            firecountdown= 1/firerate;
        }
        firecountdown -= Time.deltaTime;
    }

    void shoot()
    {
        GameObject bullet60=(GameObject)Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
        bullet bul = bullet60.GetComponent<bullet>();
        if(bul!= null)
        {
            bul.seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    void UpdateTarget()
    {
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null; 
        }
    }
}
