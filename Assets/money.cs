using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class money : MonoBehaviour
{
    public TextMeshProUGUI moneytxt;
    public static int mony;
    public int startmoney = 800;
    void Start()
    {
        mony = 800;
        moneytxt.SetText("Money:" + mony.ToString());
    }
    void Update()
    {
        moneytxt.SetText("Money:" + mony.ToString());
    }

}
