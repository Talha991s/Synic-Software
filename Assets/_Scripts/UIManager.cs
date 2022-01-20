using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Transform EnterPoint;
    public Transform Exitpoint;
    public GameObject player;
    public Transform EnterPoint2;
   

    public void OnPressYes()
    {
        //panel.SetActive(false);
        player.transform.position = EnterPoint.transform.position;
    }
    public void OnPressYestoLeave()
    {
        player.transform.position = Exitpoint.transform.position;
    }
    public void OnPressYesEnter()
    {
        player.transform.position = EnterPoint2.transform.position;
    }
}
