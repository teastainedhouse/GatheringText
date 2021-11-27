using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGatheringScene : MonoBehaviour
{
    public void ChangeToGatheringScene()
    {
        SceneManager.LoadScene("gather");
    }
}
