using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookData : MonoBehaviour
{
    public static BookData cocoBookData;

    // ���� ���� �迭�� ���� �� ������Ʈ
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
