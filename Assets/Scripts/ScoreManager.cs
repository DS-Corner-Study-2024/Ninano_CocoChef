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

    // 재료 데이터를 감싸는 클래스
    //[System.Serializable]
    //public class IngredientsWrapper
    //{
    //    public List<string> ingredients;
    //}

    public void GetScore()
    {
        //가장 상단의 if에는 tool 냄비에 대한 내용
        if (ShareData.data.toolData == "pot")
        {
            if (ShareData.data.ingredientData[3] == "1") //불닭소스 선택시: 불그새
            {
                BookData.cocoBookData.bookData[3] = "1";
            }
            else if(ShareData.data.ingredientData[0] == "1" && ShareData.data.ingredientData[1] == "1" &&
                ShareData.data.ingredientData[2] == "1" && ShareData.data.ingredientData[3] == "0" &&
                ShareData.data.ingredientData[4] == "1" && ShareData.data.ingredientData[5] == "1" &&
                ShareData.data.ingredientData[6] == "0" && ShareData.data.ingredientData[7] == "1" &&
                ShareData.data.ingredientData[8] == "0" && ShareData.data.ingredientData[9] == "1" &&
                ShareData.data.ingredientData[10] == "1" && ShareData.data.ingredientData[11] == "1" &&
                ShareData.data.ingredientData[12] == "0" && ShareData.data.ingredientData[13] == "1") //최고의 레시피: 황홀 그새
            {
                BookData.cocoBookData.bookData[5] = "1";
            } else
            {//탈난그새
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
                ShareData.data.ingredientData[12] == "1" && ShareData.data.ingredientData[13] == "0") //여유 만만 그새: 코코넛 & 젤리만 선택시
            {
                BookData.cocoBookData.bookData[4] = "1";
            } else
            {// 나머지는 탈난그새
                BookData.cocoBookData.bookData[2] = "1";
            }
            
        }
        else
        {// 나머지는 탈난그새
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
        //가장 상단의 if에는 tool 냄비에 대한 내용
        if (ShareData.data.toolData == "pot")
        {
            if (ShareData.data.ingredientData[3] == "1") //불닭소스 선택시: 불그새
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
                ShareData.data.ingredientData[12] == "0" && ShareData.data.ingredientData[13] == "1") //최고의 레시피: 황홀 그새
            {
                goodImage.SetActive(true);
                goodText.SetActive(true);
            }
            else
            {//탈난그새
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
                ShareData.data.ingredientData[12] == "1" && ShareData.data.ingredientData[13] == "0") //여유 만만 그새: 코코넛 & 젤리만 선택시
            {
                travelImage.SetActive(true);
                travelText.SetActive(true);
            }
            else
            {// 나머지는 탈난그새
                pukeImage.SetActive(true);
                pukeText.SetActive(true);
            }

        }
        else
        {// 나머지는 탈난그새
            pukeImage.SetActive(true);
            pukeText.SetActive(true);
        }
    }

    IEnumerator FeedBackDelay(float delay)
    {

        BookData.cocoBookData.bookData[1] = "1";
        // delay 초 동안 대기
        yield return new WaitForSeconds(delay);

        // 이미지 비활성화
        feedBackImage.SetActive(false);
        feedBackText.SetActive(false);
        CocoScore();
    }
}
