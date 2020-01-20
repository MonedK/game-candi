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
        SceneManager.LoadScene("Level04");
    }
    public void PlayLevel5()
    {
        SceneManager.LoadScene("Level05");
    }
    public void PlayLevel6()
    {
        SceneManager.LoadScene("Level06");
    }
    public void PlayLevel7()
    {
        SceneManager.LoadScene("Level07");
    }
    public void PlayLevel8()
    {
        SceneManager.LoadScene("Level08");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
