using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoldPanel : MonoBehaviour
{
    public GameObject smeltPanel;

    public Image plainRingImg, detailRingImg;
    public Image plainRingTick, detailRingTick;

    public bool usingPlain, usingDetail;

    public 

    void Start()
    {
        smeltPanel.SetActive(false);

        plainRingImg.enabled = false;
        plainRingTick.enabled = false;
        detailRingImg.enabled = false;
        detailRingTick.enabled = false;
        usingPlain = false;
        usingDetail = false;
    }

    void Update()
    {
        
    }

    public void PlainRing()
    {
        usingDetail = false;
        detailRingImg.enabled = false;
        detailRingTick.enabled = false;

        usingPlain = true;
        plainRingImg.enabled = true;
        plainRingTick.enabled = true;
    }

    public void DetailedRing()
    {
        usingPlain = false;
        plainRingImg.enabled = false;
        plainRingTick.enabled = false;

        usingDetail = true;
        detailRingImg.enabled = true;
        detailRingTick.enabled = true;
    }

    public void Continue()
    {
        if (usingPlain == true || usingDetail == true)
        {
            smeltPanel.SetActive(true);
        }
    }
}
