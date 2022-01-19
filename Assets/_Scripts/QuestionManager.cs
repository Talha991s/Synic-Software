using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public GameObject spawnPoint1;
    public GameObject panel;
    public GameObject panel2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Store1"))
        {
            panel.SetActive(true);
        }

        if(other.gameObject.CompareTag("Store2"))
        {
            panel.SetActive(true);
        }
        
    }

}
