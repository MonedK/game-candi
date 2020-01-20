using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        CurrentLevelTriggerCount = _currentLevelTriggerCount;
    }
    public bool[] trigger = new bool[0];

    [SerializeField]
    private int _currentLevelTriggerCount;

    public int CurrentLevelTriggerCount {
        get {
            return _currentLevelTriggerCount;
        }
        set
        {
           _currentLevelTriggerCount = value; trigger = new bool[_currentLevelTriggerCount];
        }
    }

    bool gameHasEnded = false;

    public float restartDelay = 0f;

    public GameObject completeLevelUI;
    public GameObject helpButton;

    public void SetTriggered(int ID)
    {
        trigger[ID] = true;
        for (int i = 0; i < trigger.Length; i++)
        {
            if (trigger[i] == false)
            {
                return;
            }            
        }
        Cursor.lockState = CursorLockMode.None;
        completeLevelUI.SetActive(true);
        helpButton.SetActive(false);
    }

    public void Endgame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
