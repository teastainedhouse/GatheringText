using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gathering : MonoBehaviour
{
    //string gatheredThing;
    
    public GameObject gatheredTextResult;
    public GameObject gatheredImageResult;

    //inventory
    int threadInv;
    int wireInv;
    int woolInv;
    int metalInv;

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
        int randomlyGatheredNumber = Random.Range(0, 4);
        Debug.Log("random value:" + randomlyGatheredNumber);
        TextMeshProUGUI TextMeshProLable = gatheredTextResult.GetComponent<TextMeshProUGUI>();

        switch (randomlyGatheredNumber)
        {
            case 0:
               // gatheredThing = "thread";
                threadInv++;
                TextMeshProLable.text = "thread";
                break;
            case 1:
                //gatheredThing = "wire";
                wireInv++;
                TextMeshProLable.text = "wire";
                break;
            case 2:
                //gatheredThing = "wool";
                woolInv++;
                TextMeshProLable.text = "wool";
                break;
            case 3:
                //gatheredThing = "metal";
                TextMeshProLable.text = "metal";
                metalInv++;
                break;
            default:
                print("sadness");
                break;
        }

        Debug.Log("current inventory: thread=" + threadInv + " wire=" + wireInv + " wool=" + woolInv + " metal=" + metalInv);

    }
}
