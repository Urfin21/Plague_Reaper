using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ESC : MonoBehaviour
{
    public GameObject resume;
    public GameObject menu;
    public GameObject reset;


    public void hide()
    {
        resume.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        reset.gameObject.SetActive(false);
    }
    public void view()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            resume.gameObject.SetActive(true);
            menu.gameObject.SetActive(true);
        }

    }
    public void view1()
    {
        reset.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);
    }
    public void Start()
    {
        hide();
    }
    public void Update()
    {
        view();
    }
    public void RESTART()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
