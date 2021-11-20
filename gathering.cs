using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class gathering : MonoBehaviour
{
    public GameObject gatheredPrefab;

    //inventory
    int threadInv;
    int wireInv;
    int woolInv;
    int metalInv;
    int trashInv;

    public void menu()
    {
        Debug.Log("menu button");
        SceneManager.LoadScene("menu");
    }
    
    public void gather()
    {
        GatherStuff();
    }

    public void GatherStuff()
    {
        int randomlyGatheredNumber = Random.Range(0, 7);
        Debug.Log("random value:" + randomlyGatheredNumber);
        TextMeshPro gatheredTextMsg = gatheredPrefab.GetComponent<TextMeshPro>();

        if (randomlyGatheredNumber == 0)
        {
            // gatheredThing = "thread";
            threadInv++;
            gatheredTextMsg.text = "thread";
        }

        else if (randomlyGatheredNumber == 2)
        {
            //gatheredThing = "wire";
            wireInv++;
            gatheredTextMsg.text = "wire";
        }

        else if(randomlyGatheredNumber == 4)
        {
            //gatheredThing = "wool";
            woolInv++;
            gatheredTextMsg.text = "wool";
        }

        else if (randomlyGatheredNumber == 6)
        {
            //gatheredThing = "metal";
            gatheredTextMsg.text = "metal";
            metalInv++;
        }
        
        else
        {
            gatheredTextMsg.text = "trash";
            trashInv++;
        }

        Debug.Log("current inventory: thread=" + threadInv + " wire=" + wireInv + " wool=" + woolInv + " metal=" + metalInv + " trash=" + trashInv);
    }
}
