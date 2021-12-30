using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class gathering : MonoBehaviour
{

    //how many gathers
    int numberOfPulls = 1;

    //inventory

    public int threadInv;
    public int paperInv;
    public int cardboardInv;
    public int woodInv;
    public int wireInv;
    public int fluffInv;
    public int metalInv;
    public int trashInv;

    //inventory text display
    public TextMeshProUGUI[] displayInvText;

    //setting selected button color
    public Color buttonSelectedColor;
    public Button[] BtnHowManyPulls;
    public int WhichButton = 0;

    //setting colors back to grey
    public Color buttonNotSelectedColor;

    private void Start()
    {
        LoadPerfs();
        SetButtonColor();

    }
    public void menu()
    {
        Debug.Log("menu button");
        SceneManager.LoadScene("menu");
    }

    public void GatherButton()
    {
        RandomGatherStuff();
        SetButtonColor();
    }

    public void LoadPerfs()
    {
        int threadInv = PlayerPrefs.GetInt("Inventory", 0);
    }

    public void SavePerfs()
    {
        PlayerPrefs.SetInt("Inventory", threadInv);
    }

    public void SetButtonColor()
    {
        foreach (Button buttons in BtnHowManyPulls)
        {
            ColorBlock cb1 = buttons.colors;
            cb1.normalColor = buttonNotSelectedColor;
            cb1.highlightedColor = buttonNotSelectedColor;
            cb1.pressedColor = buttonNotSelectedColor;
            buttons.colors = cb1;
        }

        ColorBlock cb = BtnHowManyPulls[WhichButton].colors;
        cb.normalColor = buttonSelectedColor;
        cb.highlightedColor = buttonSelectedColor;
        cb.pressedColor = buttonSelectedColor;
        BtnHowManyPulls[WhichButton].colors = cb;
    }

    public void SinglePullButton()
    {
        numberOfPulls = 1;
        WhichButton = 0;
        SetButtonColor();
    }

    public void PlusTwoButton()
    {
        numberOfPulls = 2;
        WhichButton = 1;
        SetButtonColor();
    }

    public void PlusFiveButton()
    {
        numberOfPulls = 5;
        WhichButton = 2;
        SetButtonColor();
    }

    public void RandomGatherStuff()
    {
        int RunGatheringScript = 0;

        while (numberOfPulls > RunGatheringScript)
        {
            int randomlyGatheredNumber = Random.Range(0, 10);
            Debug.Log("random value:" + randomlyGatheredNumber);

            if (randomlyGatheredNumber == 0 )
            {
                fluffInv++;
                displayInvText[0].text = "" + fluffInv;
            }

            else if (randomlyGatheredNumber == 1)
            {
                cardboardInv++;
                displayInvText[5].text = "" + cardboardInv;
            }

            else if (randomlyGatheredNumber == 2)
            {
                metalInv++;
                displayInvText[1].text = "" + metalInv;
            }

            else if (randomlyGatheredNumber == 3)
            {
                threadInv++;
                displayInvText[2].text = "" + threadInv;
            }

            else if (randomlyGatheredNumber == 4)
            {
                paperInv++;
                displayInvText[3].text = "" + paperInv;
            }

            else if (randomlyGatheredNumber == 5)
            {
                wireInv++;
                displayInvText[4].text = "" + wireInv;
            }

            else if (randomlyGatheredNumber == 6)
            {
                woodInv++;
                displayInvText[6].text = "" + woodInv;
            }

            else
            {
                trashInv++;
                displayInvText[7].text = "" + trashInv;
            }

            RunGatheringScript++;
        }
        Debug.Log("current inventory: thread=" + threadInv + " paper=" + paperInv + " cardboard=" + cardboardInv + " wood=" + woodInv + " wire=" + wireInv + " wool=" + fluffInv + " metal=" + metalInv + " trash=" + trashInv);
        SavePerfs();
    }
}
