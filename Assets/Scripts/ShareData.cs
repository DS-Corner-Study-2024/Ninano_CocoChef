using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareData : MonoBehaviour
{
    //������ ������ 3����
    public static ShareData data;

    // ���� �迭 0,1�� �ٷ��
    public string[] ingredientData = new string[] { "0", "0", "0", "0", "0", "0" , "0", "0", "0", "0", "0", "0", "0", "0"};
    // ������ �̸����� ��Ʈ�� ����
    public string toolData;
    // ���� ���� �迭�� ���� �� ������Ʈ
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
        // �迭�� ��� ��Ҹ� "0"���� �ʱ�ȭ
        //for (int i = 0; i < ingredientData.Length; i++)
        //{
        //    ingredientData[i] = "0";
        //}
    }
}
