using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class gathering : MonoBehaviour
{
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

    public void menu()
    {
        Debug.Log("menu button");
        SceneManager.LoadScene("menu");
    }

    public void GatherButtonx1()
    {
        RandomGatherStuff(1);
    }

    public void GatherButtonx2()
    {
        RandomGatherStuff(2);
    }

    public void GatherButtonx5()
    {
        RandomGatherStuff(5);
    }

    public void RandomGatherStuff(int RandomGatherPulls)
    {
        int RunGatheringScript = 0;

        while (RandomGatherPulls > RunGatheringScript)
        {
            int randomlyGatheredNumber = Random.Range(0, 10);
            Debug.Log("random value:" + randomlyGatheredNumber);

            if (randomlyGatheredNumber == 0)
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
    }
}
