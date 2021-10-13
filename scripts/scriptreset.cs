using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptreset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void reset()
    {
      PlayerPrefs.DeleteAll();
      SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
