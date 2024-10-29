using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Burger : MonoBehaviour
{
    public GameObject Bread;

    public GameObject WinPanel;
    public TMP_Text level;
    static int i = 5;
    
    void Start()
    {
        WinPanel.SetActive(false);
        level.text = i.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.gameObject.SetActive(false);
            i--;
            level.text = i.ToString();

            if (i == 0)
            {
                WinPanel.SetActive(true);
            }
        }
    }
}
