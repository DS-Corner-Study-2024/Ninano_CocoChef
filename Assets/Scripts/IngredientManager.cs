using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IngredientManager : MonoBehaviour
{
    [System.Serializable]
    public class Ingredient
    {
        public string name;         // ��� �̸�
        public GameObject button;   // ��ư ������Ʈ
        public GameObject item;     // ���� ���� ��� ������Ʈ
    }

    public List<Ingredient> ingredients;  // ��ư-��� ���� ����Ʈ
    public string nextSceneName;          // �̵��� �� �̸�
    private List<string> selectedIngredients = new List<string>(); // ���õ� ��� �̸� ����
    public Color selectedColor = Color.HSVToRGB(41, 100, 100); // ��ư�� ���õǾ��� ���� ����

    private Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>(); // ��ư�� ���� ���� ����

    //public void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    void Start()
    {
        Debug.Log("���� ó��");
        Debug.Log(message: ShareData.data.ingredientData[0]);
        //Debug.Log(ShareData.data.ingredientData);

        //��ư Ŭ�� �̺�Ʈ ����
        foreach (var ingredient in ingredients)
        {
            var btn = ingredient.button.GetComponent<UnityEngine.UI.Button>();
            if (btn != null)
            {
                // ���� ���� ����
                originalColors[btn] = btn.colors.normalColor;

                Debug.Log("������ ���:" + ingredient.name);

                btn.onClick.AddListener(() => ToggleIngredient(ingredient, btn));
            }
        }
    }

    // ��� ����/���� ���
    void ToggleIngredient(Ingredient ingredient, Button button)
    {
        if (selectedIngredients.Contains(ingredient.name))
        {
            SaveIngerdient(ingredient.name);
            selectedIngredients.Remove(ingredient.name); // ���� ����
            ingredient.item.SetActive(false);            // ���񿡼� ����
            UpdateButtonColor(button, originalColors[button]); // ���� ������ ����


        }
        else
        {
            SaveIngerdient(ingredient.name);
            selectedIngredients.Add(ingredient.name);    // ����
            ingredient.item.SetActive(true);             // ���񿡼� ����
            UpdateButtonColor(button, selectedColor); // ���õ� ������ ����
        }
    }

    // ��ư ���� ������Ʈ
    void UpdateButtonColor(Button button, Color color)
    {
        var colors = button.colors;
        colors.normalColor = color;
        colors.selectedColor = color;
        button.colors = colors;
    }

    // ȭ��ǥ ��ư Ŭ�� �� ȣ�� (�� ��ȯ �� ������ ����)
    public void ChangeNextScene()
    {
        if (selectedIngredients.Count > 0)
        {
            // ���õ� ��Ḧ JSON �������� ����
            string jsonData = JsonUtility.ToJson(new { ingredients = selectedIngredients });
            PlayerPrefs.SetString("SelectedIngredients", jsonData);

            // ���� ������ �̵�
            SceneManager.LoadScene("Tools"); // "ToolSelectionScene"�� ���� ���� �� �̸����� ����
        }
        else
        {
            Debug.LogError("No ingredients selected!");
        }
    }

    public void SaveIngerdient(string ingredientName)
    {

        switch (ingredientName)
        {
            case "ricecake":
                CheckIngredient(0);
                break;
            case "pa":
                CheckIngredient(1);
                break;
            case "mandu":
                CheckIngredient(2);
                break;
            case "fire":
                CheckIngredient(3);
                break;
            case "kim":
                CheckIngredient(4);
                break;
            case "egg":
                CheckIngredient(5);
                break;
            case "coconut":
                CheckIngredient(6);
                break;
            case "fish":
                CheckIngredient(7);
                break;
            case "mango":
                CheckIngredient(8);
                break;
            case "msg":
                CheckIngredient(9);
                break;
            case "papper":
                CheckIngredient(10);
                break;
            case "beef":
                CheckIngredient(11);
                break;
            case "jelly":
                CheckIngredient(12);
                break;
            case "salt":
                CheckIngredient(13);
                break;
            default:
                CheckIngredient(14);
                break;
        }
    }

    public void CheckIngredient(int num)
    {
        string[] currentIngredientData = ShareData.data.ingredientData;
        Debug.Log(currentIngredientData);

        if (currentIngredientData[num] == "0") // ���� �����̾��ٸ�
        {
            ShareData.data.ingredientData[num] = "1"; //��������
            Debug.Log(ShareData.data.ingredientData[num]);
        } else
        {
            ShareData.data.ingredientData[num] = "0";
            Debug.Log(ShareData.data.ingredientData[num]);
        }
    }
}
