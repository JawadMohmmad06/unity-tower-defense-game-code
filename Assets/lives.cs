using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class lives : MonoBehaviour
{
    public Button yourButton;
    public Button yourButton2;
    public GameObject complelvl;
    public TextMeshProUGUI livetxt;
    public static int live;
    public int startlive = 10;
    public static int hit=0;
    public TextMeshProUGUI newhigh;
    public TextMeshProUGUI oldhigh;
  
    void Start()
    {
        hit = 0;
        live = startlive;
        livetxt.SetText("Lives:" + live.ToString());
    }
    void Update()
    {
        livetxt.SetText("Lives:" + live.ToString());
        if(live <=0) {
            int hs = PlayerPrefs.GetInt("Score", 0);
            if (hit > hs)
            {
                PlayerPrefs.SetInt("Score", hit);
                newhigh.SetText("New HighScore " + hit.ToString());
                oldhigh.SetText("");

            }
            else
            {
                
                newhigh.SetText("Your Score " + hit);
                oldhigh.SetText("High Score " + hs.ToString());
            }
            complelvl.SetActive(true);
            yourButton2.gameObject.SetActive(false); 
            yourButton2.interactable = false;
            yourButton.gameObject.SetActive(false);
            yourButton.interactable = false;

        }
    }


}
