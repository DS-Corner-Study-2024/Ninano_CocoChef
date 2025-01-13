using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookData : MonoBehaviour
{
    public static BookData cocoBookData;

    // 도감 상태 배열로 저장 및 업데이트
    public string[] bookData = new string[] { "0", "0", "0", "0", "0", "0" };
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (cocoBookData == null)
        {
            cocoBookData = this;
        }
    }
}
