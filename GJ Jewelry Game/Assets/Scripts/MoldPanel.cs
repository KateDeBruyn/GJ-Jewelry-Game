using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoldPanel : MonoBehaviour
{
    public GameObject smeltPanel;

    public Image ringMould1,ringMould2, ringMould3;
    public Image ringMould2Tick, ringMould3Tick, ringMould1Tick;

    public bool usingRingMould2, usingRingMould3, usingRingMould1;


    void Start()
    {
        smeltPanel.SetActive(false);

        ringMould1.enabled = false;
        ringMould1Tick.enabled = false;
        ringMould2.enabled = false;
        ringMould2Tick.enabled = false;
        ringMould3.enabled = false;
        ringMould3Tick.enabled = false;
        usingRingMould2 = false;
        usingRingMould3 = false;
        usingRingMould1 = false;
    }

    void Update()
    {
        
    }
    

    #region Ring Moulds
    public void RingMould2()
    {
        usingRingMould3 = false;
        ringMould3.enabled = false;
        ringMould3Tick.enabled = false;

        usingRingMould1 = false;
        ringMould1.enabled = false;
        ringMould1Tick.enabled = false;

        usingRingMould2 = true;
        ringMould2.enabled = true;
        ringMould2Tick.enabled = true;
    } 
    public void RingMould1()
    {
        usingRingMould3 = false;
        ringMould3.enabled = false;
        ringMould3Tick.enabled = false;
        
        usingRingMould2 = false;
        ringMould2.enabled = false;
        ringMould2Tick.enabled = false;

        usingRingMould1 = true;
        ringMould1.enabled = true;
        ringMould1Tick.enabled = true;
    }


    public void RingMould3()
    {
        usingRingMould2 = false;
        ringMould2.enabled = false;
        ringMould2Tick.enabled = false;

        usingRingMould1 = false;
        ringMould1.enabled = false;
        ringMould1Tick.enabled = false;

        usingRingMould3 = true; 
        ringMould3.enabled = true;
        ringMould3Tick.enabled = true;
    }
    #endregion 
    public void Continue()
    {
        if (usingRingMould2 == true || usingRingMould3 == true || usingRingMould1 == true)
        {
            smeltPanel.SetActive(true);
        }
    }
}
