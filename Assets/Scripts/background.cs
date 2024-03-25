using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background : MonoBehaviour
{
    public int background1 = 0;
    public Image imgObj;
    public Sprite spriteImage;
    public Sprite spriteImage1;
    public Sprite spriteImage2;

    public void Start()
    {
        LoadSettings();
    }

    public void Click()
    {
        background1 = background1 + 1;
    }

    public void Change()
    {
        if (background1 == 3)
        {
            background1 = 0;
        }
        if (background1 == 0)
        {
            imgObj.sprite = spriteImage;
        }
        if (background1 == 1)
        {
            imgObj.sprite = spriteImage1;
        }
        if (background1 == 2)
        {
            imgObj.sprite = spriteImage2;
        }
    }
    public void Update() 
    {
        Change();
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("background1", background1);
    }

    public void LoadSettings()
    {
        if (PlayerPrefs.HasKey("background1"))
            background1 = PlayerPrefs.GetInt("background1");
        else
            background1 = 1;

    }

}
