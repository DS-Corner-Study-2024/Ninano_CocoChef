using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareData : MonoBehaviour
{
    //저장할 데이터 3가지
    public static ShareData data;

    // 음식 배열 0,1로 다루기
    public string[] ingredientData = new string[] { "0", "0", "0", "0", "0", "0" , "0", "0", "0", "0", "0", "0", "0", "0"};
    // 도구는 이름으로 스트링 저장
    public string toolData;
    // 도감 상태 배열로 저장 및 업데이트
    public string[] bookData = new string[] {"0","0","0","0","0","0"};


    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (data == null)
        {
            data = this;
        }
        //else
        //{
        //    Destroy(gameObject);
        //}
        Debug.Log(ingredientData[0]);
    }

    public void Start()
    {
        // 배열의 모든 요소를 "0"으로 초기화
        //for (int i = 0; i < ingredientData.Length; i++)
        //{
        //    ingredientData[i] = "0";
        //}
    }
}
