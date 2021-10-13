using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptpause : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPaused = false;
    void Start()
    {

    }
    public void pause()
    {
      if(isPaused)
      {
        Time.timeScale=1;
        // Debug.Log("butt"+btn.name);
        isPaused=false;
      }
      else
      {
        Time.timeScale=0;
        isPaused=true;
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
