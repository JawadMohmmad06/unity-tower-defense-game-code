using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;
public class WaveSpanner : MonoBehaviour
{
    public TextMeshProUGUI wavecountdown;
    public Transform spwanpoint;
    public Transform enemyprefab;
    public float timeBetweenWaves = 5f;
    public float coundown;
    private int wavenumber = 1;
    // Update is called once per frame
    void Start()
    {
        coundown = 10;
    }
    void Update()
    {
        if (coundown <= 0f)
        {
           StartCoroutine( Spanwave());
            coundown = timeBetweenWaves;
        }
        coundown -= Time.deltaTime;
        wavecountdown.text="Time: " +coundown.ToString("0");
    }
    IEnumerator Spanwave()
    {
        for(int i = 0; i < wavenumber; i++)
        {
            Spanenemy();
            yield return new WaitForSeconds(0.5f);
        }
        wavenumber++;
    }
    void Spanenemy()
    {
        Instantiate(enemyprefab,spwanpoint.position,spwanpoint.rotation);
    }
}
