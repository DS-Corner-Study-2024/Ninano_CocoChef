using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        if (!string.IsNullOrEmpty("Ingredients"))
        {
            SceneManager.LoadScene("Ingredients");
        }
        else
        {
            Debug.LogError("Target scene name is not set!");
        }
    }

    public void ChangeSceneBook()
    {
        if (!string.IsNullOrEmpty("CocoBook"))
        {
            SceneManager.LoadScene("CocoBook");
        }
        else
        {
            Debug.LogError("Target scene name is not set!");
        }
    }

    public void ChangeHome()
    {
        if (!string.IsNullOrEmpty("Main"))
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            Debug.LogError("Target scene name is not set!");
        }
    }
}
