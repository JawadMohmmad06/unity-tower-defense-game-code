using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
  public buldmanager bm;
    void Start()
    {
        bm = buldmanager.instance;
    }
   public void PurchaseStandardTurrent()
    {
        bm.SetTorrentBuild(bm.standardturrentPrefab);
    }
    public void misailStandardTurrent()
    {
        bm.SetTorrentBuild(bm.misailturrentPrefab);
    }
}
