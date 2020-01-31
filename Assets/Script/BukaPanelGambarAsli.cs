using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BukaPanelGambarAsli : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        /*if(Panel != null)
        {
            Panel.SetActive(true);
        }
        */
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");

                animator.SetBool("open", !isOpen);
            }
        }

    }
}
