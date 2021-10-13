using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelchange : MonoBehaviour
{
    // Start is called before the first frame update
    public int nextScene;
    void Start()
    {
      nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.name == "finalline")
        {
          if(SceneManager.GetActiveScene().buildIndex == 4)
          {
            SceneManager.LoadScene(0);
          }
          else
          {
            SceneManager.LoadScene(nextScene);
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            if(nextScene > PlayerPrefs.GetInt("levelAt"))
            {
              PlayerPrefs.SetInt("levelAt",nextScene-1);
            }
          }
        }
    }
    void Update()
    {

    }
}
