﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptlevel : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] lvlButtons;
    void Start()
    {
      int levelAt = PlayerPrefs.GetInt("levelAt", 1);
      for(int i=0;i<lvlButtons.Length;i++)
      {
        if(i+1 > levelAt)
        {
          lvlButtons[i].interactable = false;
        }
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
