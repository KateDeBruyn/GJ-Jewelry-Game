using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmeltPanel : MonoBehaviour
{

    public GameObject cutsPanel;

    private MoldPanel moldPanel;

    public Image ringMould2Selec, ringMould3Selec, ringMould1Selec;
    public Image goldTick, silvTick, copperTick;

    public bool goldSelected, silvSelected, copperSelected;

    void Start()
    {
        moldPanel = gameObject.GetComponent<MoldPanel>();

        cutsPanel.SetActive(false);

        ringMould2Selec.enabled = false;
        ringMould3Selec.enabled = false;
        ringMould1Selec.enabled = false;
        goldTick.enabled = false;
        silvTick.enabled = false;
        copperTick.enabled = false;

        goldSelected = false;
        silvSelected = false;
        copperSelected = false;
    }

    void Update()
    {
        if (moldPanel.usingRingMould2 == true)
        {
            ringMould3Selec.enabled = false;
            ringMould2Selec.enabled = true;
            ringMould1Selec.enabled = false;
        }
        else if (moldPanel.usingRingMould3 == true)
        {
            ringMould1Selec.enabled = false;
            ringMould2Selec.enabled = false;
            ringMould3Selec.enabled = true;

        }else if (moldPanel.usingRingMould1)
        {
            ringMould1Selec.enabled = true;
            ringMould2Selec.enabled = false;
            ringMould3Selec.enabled = false;
        }
    }

    public void GoldSelected()
    {
        silvSelected = false;
        goldSelected = true;
        copperSelected = false;

        silvTick.enabled = false;
        goldTick.enabled = true;
        copperTick.enabled = false;


    }

    public void CopperSelected()
    {
        silvSelected = false;
        goldSelected = false;
        copperSelected = true;

        silvTick.enabled = false;
        goldTick.enabled = false;
        copperTick.enabled = true;
    }

    public void SilverSelected()
    {
        silvSelected = true;
        goldSelected = false;
        copperSelected = false;

        goldTick.enabled = false;
        silvTick.enabled = true;
        copperTick.enabled = false;

    }

    public void Smelt()
    {
        if (goldSelected == true || silvSelected == true || copperSelected == true)
        {
            cutsPanel.SetActive(true);
        }
    }
}
