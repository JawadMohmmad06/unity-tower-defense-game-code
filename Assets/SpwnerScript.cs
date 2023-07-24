using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpwnerScript : MonoBehaviour
{
    public GameObject cubeprefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubeprefab, transform.position, Quaternion.identity);
        }
    }
}
