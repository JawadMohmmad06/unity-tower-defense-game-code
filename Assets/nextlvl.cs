using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextlvl : MonoBehaviour
{
    // Start is called before the first frame update

    public void newwgame()
    {
        UnityEngine.Debug.Log("oye");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
