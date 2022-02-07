using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutPanel : MonoBehaviour
{
    [SerializeField] private GameObject cutOptionsPanel;

    [SerializeField] private Image whiteGemImg, purpleGemImg, pinkGemImg;
    [SerializeField] private Image whiteGemTick, purpleGemTick, pinkGemTick;

    private bool selectedGem;

    // Start is called before the first frame update
    void Start()
    {
        cutOptionsPanel.SetActive(false);
        selectedGem = false;

        whiteGemImg.enabled = false;
        purpleGemImg.enabled = false;
        pinkGemImg.enabled = false;

        pinkGemTick.enabled = false;
        purpleGemTick.enabled = false;
        whiteGemTick.enabled = false;
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
    }

    public void WhiteGem()
    {
        whiteGemImg.enabled = true;
        purpleGemImg.enabled = false;
        pinkGemImg.enabled = false;

        pinkGemTick.enabled = false;
        purpleGemTick.enabled = false;
        whiteGemTick.enabled = true;

        selectedGem = true;
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
    }

}
