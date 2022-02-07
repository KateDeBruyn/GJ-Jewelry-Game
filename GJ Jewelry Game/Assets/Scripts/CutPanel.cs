using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutPanel : MonoBehaviour
{
    [SerializeField] private GameObject cutOptionsPanel, hammerPanel, finalPanel;

    [SerializeField] private Image whiteGemImg, purpleGemImg, pinkGemImg, finalGemImg, gemCut1, gemCut2, gemCut3;
    [SerializeField] private Image whiteGemTick, purpleGemTick, pinkGemTick, cut1Tick, cut2Tick, cut3Tick;

    [SerializeField] private Animator hammerAnim;

    private bool selectedGem, selectedCut;

    private int hits = 0;
    private int cut = 0;
    private string finalGem = "none";

    // Start is called before the first frame update
    void Start()
    {
        cutOptionsPanel.SetActive(false);
        hammerPanel.SetActive(false);
        finalPanel.SetActive(false);

        selectedGem = false;
        selectedCut = false;

        whiteGemImg.enabled = false;
        purpleGemImg.enabled = false;
        pinkGemImg.enabled = false;
        finalGemImg.enabled = false;

        gemCut1.enabled = false;
        gemCut2.enabled = false;
        gemCut3.enabled = false;

        pinkGemTick.enabled = false;
        purpleGemTick.enabled = false;
        whiteGemTick.enabled = false;

        cut1Tick.enabled = false;
        cut2Tick.enabled = false;
        cut3Tick.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedGem)
        {
            cutOptionsPanel.SetActive(true);
        }
        else
        {
            cutOptionsPanel.SetActive(false);
        }

        if (selectedCut)
        {
            hammerPanel.SetActive(true);
        }
        else
        {
            hammerPanel.SetActive(false);
        }
    }

    #region gems
    public void WhiteGem()
    {
        /*selectedGemImg.enabled = true;
        selectedGemImg = whiteGemImg;*/

        whiteGemImg.enabled = true;
        purpleGemImg.enabled = false;
        pinkGemImg.enabled = false;

        pinkGemTick.enabled = false;
        purpleGemTick.enabled = false;
        whiteGemTick.enabled = true;

        selectedGem = true;
        //gem = 1;
        finalGem = "white";
    } 
    public void PurpleGem()
    {
        whiteGemImg.enabled = false;
        purpleGemImg.enabled = true;
        pinkGemImg.enabled = false;

        pinkGemTick.enabled = false;
        purpleGemTick.enabled = true;
        whiteGemTick.enabled = false;

        selectedGem = true;
        //gem = 2;
        finalGem = "purple";
    }
    public void PinkGem()
    {
        whiteGemImg.enabled = false;
        purpleGemImg.enabled = false;
        pinkGemImg.enabled = true;

        pinkGemTick.enabled = true;
        purpleGemTick.enabled = false;
        whiteGemTick.enabled = false;

        selectedGem = true;
        //gem = 3;
        finalGem = "pink";
    }
    #endregion

    
    public void Cut1()
    {
        cut1Tick.enabled = true;
        selectedCut = true;
        cut = 1;
    }

    public void Cut2()
    {
        cut2Tick.enabled = true;
        selectedCut = true;
        cut = 2;
    }

    public void Cut3()
    {
        cut3Tick.enabled = true;
        selectedCut = true;
        cut = 3;
    }

    public void Hammer()
    {
        /*if(hits == 4)
        {
            whiteGemImg.enabled = false;
            purpleGemImg.enabled = false;
            pinkGemImg.enabled = false;

            finalGemImg.enabled = true;

            
            //Debug.Log("enough smashing");
            
            //make hammer diappear
        }else if (hits == 5)
        {
            finalPanel.SetActive(true);
        }*/

        whiteGemImg.enabled = false;
        purpleGemImg.enabled = false;
        pinkGemImg.enabled = false;
        gemCut1.enabled = false;
        gemCut2.enabled = false;
        gemCut3.enabled = false;
        finalGemImg.enabled = false;

        hammerAnim.SetBool("hammerAnim", true);

        switch (hits)
        {
            case 0:
            case 1:
                gemCut1.enabled = true;
                break; 
            case 2:
                gemCut2.enabled = true;
                break;
            case 3:
                gemCut3.enabled = true;
                break;
            case 4:
                finalGemImg.enabled = true;
                break;
            case 5:
                finalPanel.SetActive(true);
                break;
            default:
                Debug.Log("system eroor os sumn");
                break;

        }

        ++hits;
        Debug.Log(hits);

        hammerAnim.SetBool("hammerAnim", true);
    }
}
