using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Debug.Log("quit application");
        Application.Quit();
    }

    public void PlayKoleksi()
    {
        SceneManager.LoadScene("koleksi");
    }

    public void PlayObjek1()
    {
        SceneManager.LoadScene("Objek1");
    }

    public void PlayObjek2()
    {
        SceneManager.LoadScene("Objek2");
    }

    public void PlayObjek3()
    {
        SceneManager.LoadScene("Objek3");
    }

    public void PlayObjek4()
    {
        SceneManager.LoadScene("Objek4");
    }

    public void PlayObjek5()
    {
        SceneManager.LoadScene("Objek5");
    }

    public void PlayObjek6()
    {
        SceneManager.LoadScene("Objek6");
    }

    public void PlayObjek7()
    {
        SceneManager.LoadScene("Objek7");
    }

    public void PlayObjek8()
    {
        SceneManager.LoadScene("Objek8");
    }
}

