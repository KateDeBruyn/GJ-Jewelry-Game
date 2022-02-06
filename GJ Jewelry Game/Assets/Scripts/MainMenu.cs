using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Button helpClient;

    public GameObject moldPanel;

    void Start()
    {
        moldPanel.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void HelpClient()
    {
        moldPanel.SetActive(true);
    }
}
