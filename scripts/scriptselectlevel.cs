using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptselectlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void level1()
    {
      SceneManager.LoadScene(2);
    }
    public void level2()
    {
      SceneManager.LoadScene(3);
    }
    public void level3()
    {
      SceneManager.LoadScene(4);
    }
    void Update()
    {

    }
}
