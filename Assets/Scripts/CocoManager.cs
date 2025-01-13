using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class cocoManager : MonoBehaviour
{
    public GameObject feedBackImage;
    public GameObject pukeImage;
    public GameObject fireImage;
    public GameObject travelImage;
    public GameObject goodImage;

    public GameObject feedBackBImage;
    public GameObject pukeBImage;
    public GameObject fireBImage;
    public GameObject travelBImage;
    public GameObject goodBImage;

    public GameObject feedBackText;
    public GameObject pukeText;
    public GameObject fireText;
    public GameObject travelText;
    public GameObject goodText;

    public GameObject feedBackQText;
    public GameObject pukeQText;
    public GameObject fireQText;
    public GameObject travelQText;
    public GameObject goodQText;


    public void Start()
    {
        for(int i = 1;i<6; i++)
        {
            StateUpdate(i);
        }
    }

    public void StateUpdate(int num)
    {

        switch (num)
        {
            case 1:
                if (ShareData.data.bookData[num] == "1")
                {
                    feedBackBImage.SetActive(false);
                    feedBackImage.SetActive(true);
                    feedBackQText.SetActive(false);
                    feedBackText.SetActive(true); 
                }
                break;
            case 2:
                if (ShareData.data.bookData[num] == "1")
                {
                    pukeBImage.SetActive(false);
                    pukeImage.SetActive(true);
                    pukeQText.SetActive(false);
                    pukeText.SetActive(true);
                }
                break;
            case 3:
                if (ShareData.data.bookData[num] == "1")
                {
                    fireBImage.SetActive(false);
                    fireImage.SetActive(true);
                    fireQText.SetActive(false);
                    fireText.SetActive(true);
                }
                break;
            case 4:
                if (ShareData.data.bookData[num] == "1")
                {
                    travelBImage.SetActive(false);
                    travelImage.SetActive(true);
                    travelQText.SetActive(false);
                    travelText.SetActive(true);
                }
                break;
            case 5:
                if (ShareData.data.bookData[num] == "1")
                {
                    goodBImage.SetActive(false);
                    goodImage.SetActive(true);
                    goodQText.SetActive(false);
                    goodText.SetActive(true);
                }
                break;
            default:
                break;
        }

        
    }
}
