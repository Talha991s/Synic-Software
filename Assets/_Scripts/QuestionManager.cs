using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public GameObject spawnPoint1;
    public GameObject panel;
    public GameObject panel2;
    public GameObject ExitPanel;
    public GameObject menubutton;
    public GameObject menubutton2;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Store 1"))
        {
            panel.SetActive(true);
        }

        if(other.gameObject.CompareTag("Store 2"))
        {
            panel2.SetActive(true);
        }
        if(other.gameObject.CompareTag("Exit1"))
        {
            ExitPanel.SetActive(true);
        }
        if(other.gameObject.CompareTag("NPC"))
        {
            anim.SetInteger("CashParam", 1);
            menubutton.SetActive(true);
        }
        if(other.gameObject.CompareTag("NPC2"))
        {
            anim.SetInteger("CashParam", 1);
            menubutton2.SetActive(true);
        }
        
    }

}
