using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEditor.Tilemaps;
using UnityEngine;
//using TMPro;
//using static IngredientManager;
//using UnityEditor.VersionControl;

public class ScoreManager : MonoBehaviour
{
    //[System.Serializable]
    public GameObject feedBackImage;
    public GameObject pukeImage;
    public GameObject fireImage;
    public GameObject travelImage;
    public GameObject goodImage;

    public GameObject feedBackText;
    public GameObject pukeText;
    public GameObject fireText;
    public GameObject travelText;
    public GameObject goodText;

    //[System.Serializable]
    //public class CocoReaction
    //{
    //    public GameObject cocoImage;
    //    public TextMeshProUGUI cocoText;
    //}
    //public List<CocoReaction> cocoRection;

    void Start()
    {

        StartCoroutine(FeedBackDelay(1.5f));
    }

    // ��� �����͸� ���δ� Ŭ����
    //[System.Serializable]
    //public class IngredientsWrapper
    //{
    //    public List<string> ingredients;
    //}

    public void GetScore()
    {
        //���� ����� if���� tool ���� ���� ����
        if (ShareData.data.toolData == "pot")
        {
            if (ShareData.data.ingredientData[3] == "1") //�Ҵ߼ҽ� ���ý�: �ұ׻�
            {
                BookData.cocoBookData.bookData[3] = "1";
            }
            else if(ShareData.data.ingredientData[0] == "1" && ShareData.data.ingredientData[1] == "1" &&
                ShareData.data.ingredientData[2] == "1" && ShareData.data.ingredientData[3] == "0" &&
                ShareData.data.ingredientData[4] == "1" && ShareData.data.ingredientData[5] == "1" &&
                ShareData.data.ingredientData[6] == "0" && ShareData.data.ingredientData[7] == "1" &&
                ShareData.data.ingredientData[8] == "0" && ShareData.data.ingredientData[9] == "1" &&
                ShareData.data.ingredientData[10] == "1" && ShareData.data.ingredientData[11] == "1" &&
                ShareData.data.ingredientData[12] == "0" && ShareData.data.ingredientData[13] == "1") //�ְ��� ������: ȲȦ �׻�
            {
                BookData.cocoBookData.bookData[5] = "1";
            } else
            {//Ż���׻�
                BookData.cocoBookData.bookData[2] = "1";
            }
            
        }
        else if(ShareData.data.toolData == "mix")
        {
            if (ShareData.data.ingredientData[0] == "0" && ShareData.data.ingredientData[1] == "0" &&
                ShareData.data.ingredientData[2] == "0" && ShareData.data.ingredientData[3] == "0" &&
                ShareData.data.ingredientData[4] == "0" && ShareData.data.ingredientData[5] == "0" &&
                ShareData.data.ingredientData[6] == "1" && ShareData.data.ingredientData[7] == "0" &&
                ShareData.data.ingredientData[8] == "0" && ShareData.data.ingredientData[9] == "0" &&
                ShareData.data.ingredientData[10] == "0" && ShareData.data.ingredientData[11] == "0" &&
                ShareData.data.ingredientData[12] == "1" && ShareData.data.ingredientData[13] == "0") //���� ���� �׻�: ���ڳ� & ������ ���ý�
            {
                BookData.cocoBookData.bookData[4] = "1";
            } else
            {// �������� Ż���׻�
                BookData.cocoBookData.bookData[2] = "1";
            }
            
        }
        else
        {// �������� Ż���׻�
            BookData.cocoBookData.bookData[2] = "1";
        }
           

    }

    public void GetReset()
    {
        for (int i = 0; i < ShareData.data.ingredientData.Length; i++)
        {
            ShareData.data.ingredientData[i] = "0";
        }
        ShareData.data.toolData = "unselect";
    }

    public void CocoScore()
    {
        //���� ����� if���� tool ���� ���� ����
        if (ShareData.data.toolData == "pot")
        {
            if (ShareData.data.ingredientData[3] == "1") //�Ҵ߼ҽ� ���ý�: �ұ׻�
            {
                fireImage.SetActive(true);
                fireText.SetActive(true);
            }
            else if (ShareData.data.ingredientData[0] == "1" && ShareData.data.ingredientData[1] == "1" &&
                ShareData.data.ingredientData[2] == "1" && ShareData.data.ingredientData[3] == "0" &&
                ShareData.data.ingredientData[4] == "1" && ShareData.data.ingredientData[5] == "1" &&
                ShareData.data.ingredientData[6] == "0" && ShareData.data.ingredientData[7] == "1" &&
                ShareData.data.ingredientData[8] == "0" && ShareData.data.ingredientData[9] == "1" && 
                ShareData.data.ingredientData[10] == "1" && ShareData.data.ingredientData[11] == "1" && 
                ShareData.data.ingredientData[12] == "0" && ShareData.data.ingredientData[13] == "1") //�ְ��� ������: ȲȦ �׻�
            {
                goodImage.SetActive(true);
                goodText.SetActive(true);
            }
            else
            {//Ż���׻�
                pukeImage.SetActive(true);
                pukeText.SetActive(true);
            }

        }
        else if (ShareData.data.toolData == "mix")
        {
            if (ShareData.data.ingredientData[0] == "0" && ShareData.data.ingredientData[1] == "0" &&
                ShareData.data.ingredientData[2] == "0" && ShareData.data.ingredientData[3] == "0" &&
                ShareData.data.ingredientData[4] == "0" && ShareData.data.ingredientData[5] == "0" &&
                ShareData.data.ingredientData[6] == "1" && ShareData.data.ingredientData[7] == "0" &&
                ShareData.data.ingredientData[8] == "0" && ShareData.data.ingredientData[9] == "0" &&
                ShareData.data.ingredientData[10] == "0" && ShareData.data.ingredientData[11] == "0" &&
                ShareData.data.ingredientData[12] == "1" && ShareData.data.ingredientData[13] == "0") //���� ���� �׻�: ���ڳ� & ������ ���ý�
            {
                travelImage.SetActive(true);
                travelText.SetActive(true);
            }
            else
            {// �������� Ż���׻�
                pukeImage.SetActive(true);
                pukeText.SetActive(true);
            }

        }
        else
        {// �������� Ż���׻�
            pukeImage.SetActive(true);
            pukeText.SetActive(true);
        }
    }

    IEnumerator FeedBackDelay(float delay)
    {

        BookData.cocoBookData.bookData[1] = "1";
        // delay �� ���� ���
        yield return new WaitForSeconds(delay);

        // �̹��� ��Ȱ��ȭ
        feedBackImage.SetActive(false);
        feedBackText.SetActive(false);
        CocoScore();
    }
}
