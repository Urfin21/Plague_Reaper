using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENES : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void station()
    {
        SceneManager.LoadScene("Station");
    }
    public void warehouse()
    {
        SceneManager.LoadScene("Warehouse");
    }
    public void boss()
    {
        SceneManager.LoadScene("Boss");
    }
    public void pasxalco()
    {
        SceneManager.LoadScene("Pasxalco");
    }
}
