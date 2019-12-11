using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void BackLevel()
    {
        SceneManager.LoadScene("Level");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

        public void PlayLevel1()
    {
        SceneManager.LoadScene("Level01");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level02");
    }
    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level03");
    }
    public void PlayLevel4()
    {
        SceneManager.LoadScene(2);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
