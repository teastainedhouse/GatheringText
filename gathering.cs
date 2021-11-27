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

    int threadInv;
    int paperInv;
    int cardboardInv;
    int woodInv;
    int wireInv;
    int fluffInv;
    int metalInv;
    int trashInv;

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
        SetButtonColor();
        threadInv = ES3.Load("saveThread", 0);
        paperInv = ES3.Load("savePaper", 0);
        cardboardInv = ES3.Load("saveCardboard", 0);
        woodInv = ES3.Load("saveWood", 0);
        wireInv = ES3.Load("saveWire", 0);
        fluffInv = ES3.Load("saveFluff", 0);
        metalInv = ES3.Load("saveMetal", 0);
        trashInv = ES3.Load("saveTrash", 0);

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
                ES3.Save("saveFluff", fluffInv, "gamesave.es3");
            }

            else if (randomlyGatheredNumber == 1)
            {
                cardboardInv++;
                displayInvText[5].text = "" + cardboardInv;
                ES3.Save("saveCardboard", cardboardInv, "gamesave.es3");
            }

            else if (randomlyGatheredNumber == 2)
            {
                metalInv++;
                displayInvText[1].text = "" + metalInv;
                ES3.Save("saveMetal", metalInv, "gamesave.es3");
            }

            else if (randomlyGatheredNumber == 3)
            {
                threadInv++;
                displayInvText[2].text = "" + threadInv;
                ES3.Save("saveThread", threadInv, "gamesave.es3");
            }

            else if (randomlyGatheredNumber == 4)
            {
                paperInv++;
                displayInvText[3].text = "" + paperInv;
                ES3.Save("savePaper", paperInv, "gamesave.es3");
            }

            else if (randomlyGatheredNumber == 5)
            {
                wireInv++;
                displayInvText[4].text = "" + wireInv;
                ES3.Save("saveWire", wireInv, "gamesave.es3");
            }

            else if (randomlyGatheredNumber == 6)
            {
                woodInv++;
                displayInvText[6].text = "" + woodInv;
                ES3.Save("saveWood", woodInv, "gamesave.es3");
            }

            else
            {
                trashInv++;
                displayInvText[7].text = "" + trashInv;
                ES3.Save("saveTrash", trashInv, "gamesave.es3");
            }

            RunGatheringScript++;
        }
        Debug.Log("current inventory: thread=" + threadInv + " paper=" + paperInv + " cardboard=" + cardboardInv + " wood=" + woodInv + " wire=" + wireInv + " wool=" + fluffInv + " metal=" + metalInv + " trash=" + trashInv);
    }
}
