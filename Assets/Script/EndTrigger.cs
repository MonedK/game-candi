using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public int ID = 0;

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Magnet")
        {
            gameManager.SetTriggered(ID);
        }
         
    }

    public void OnTriggerExit(Collider collider)
    {
        if(collider.tag == "Magnet")
        {
            Debug.Log("keluar");
        }
    }
}
