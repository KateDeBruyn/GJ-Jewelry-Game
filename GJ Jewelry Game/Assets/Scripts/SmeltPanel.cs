using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmeltPanel : MonoBehaviour
{

    public GameObject cutsPanel;

    private MoldPanel moldPanel;

    public Image plainRingSelec, detRingSelec;
    public Image goldTick, silvTick;

    public bool goldSelected, silvSelected;

    void Start()
    {
        moldPanel = gameObject.GetComponent<MoldPanel>();

        cutsPanel.SetActive(false);

        plainRingSelec.enabled = false;
        detRingSelec.enabled = false;
        goldTick.enabled = false;
        silvTick.enabled = false;

        goldSelected = false;
        silvSelected = false;
    }

    void Update()
    {
        if (moldPanel.usingRingMould2 == true)
        {
            detRingSelec.enabled = false;
            plainRingSelec.enabled = true;
        }
        else if (moldPanel.usingRingMould3 == true)
        {
            plainRingSelec.enabled = false;
            detRingSelec.enabled = true;
        }
    }

    public void GoldSelected()
    {
        goldSelected = true;
        silvTick.enabled = false;
        goldTick.enabled = true;
        

    }

    public void SilverSelected()
    {
        silvSelected = true;
        goldTick.enabled = false;
        silvTick.enabled = true;

    }

    public void Smelt()
    {
        if (goldSelected == true || silvSelected == true)
        {
            cutsPanel.SetActive(true);
        }
    }
}
