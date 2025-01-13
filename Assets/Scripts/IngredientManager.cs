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
        public string name;         // 재료 이름
        public GameObject button;   // 버튼 오브젝트
        public GameObject item;     // 냄비 안의 재료 오브젝트
    }

    public List<Ingredient> ingredients;  // 버튼-재료 매핑 리스트
    public string nextSceneName;          // 이동할 씬 이름
    private List<string> selectedIngredients = new List<string>(); // 선택된 재료 이름 저장
    public Color selectedColor = Color.HSVToRGB(41, 100, 100); // 버튼이 선택되었을 때의 색깔

    private Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>(); // 버튼의 원래 색깔 저장

    //public void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    void Start()
    {
        Debug.Log("여기 처음");
        Debug.Log(message: ShareData.data.ingredientData[0]);
        //Debug.Log(ShareData.data.ingredientData);

        //버튼 클릭 이벤트 설정
        foreach (var ingredient in ingredients)
        {
            var btn = ingredient.button.GetComponent<UnityEngine.UI.Button>();
            if (btn != null)
            {
                // 원래 색깔 저장
                originalColors[btn] = btn.colors.normalColor;

                Debug.Log("선택한 재료:" + ingredient.name);

                btn.onClick.AddListener(() => ToggleIngredient(ingredient, btn));
            }
        }
    }

    // 재료 선택/해제 토글
    void ToggleIngredient(Ingredient ingredient, Button button)
    {
        if (selectedIngredients.Contains(ingredient.name))
        {
            SaveIngerdient(ingredient.name);
            selectedIngredients.Remove(ingredient.name); // 선택 해제
            ingredient.item.SetActive(false);            // 냄비에서 숨김
            UpdateButtonColor(button, originalColors[button]); // 원래 색으로 복원


        }
        else
        {
            SaveIngerdient(ingredient.name);
            selectedIngredients.Add(ingredient.name);    // 선택
            ingredient.item.SetActive(true);             // 냄비에서 보임
            UpdateButtonColor(button, selectedColor); // 선택된 색으로 변경
        }
    }

    // 버튼 색깔 업데이트
    void UpdateButtonColor(Button button, Color color)
    {
        var colors = button.colors;
        colors.normalColor = color;
        colors.selectedColor = color;
        button.colors = colors;
    }

    // 화살표 버튼 클릭 시 호출 (씬 전환 및 데이터 전달)
    public void ChangeNextScene()
    {
        if (selectedIngredients.Count > 0)
        {
            // 선택된 재료를 JSON 형식으로 저장
            string jsonData = JsonUtility.ToJson(new { ingredients = selectedIngredients });
            PlayerPrefs.SetString("SelectedIngredients", jsonData);

            // 다음 씬으로 이동
            SceneManager.LoadScene("Tools"); // "ToolSelectionScene"을 실제 다음 씬 이름으로 변경
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

        if (currentIngredientData[num] == "0") // 원래 비선택이었다면
        {
            ShareData.data.ingredientData[num] = "1"; //선택으로
            Debug.Log(ShareData.data.ingredientData[num]);
        } else
        {
            ShareData.data.ingredientData[num] = "0";
            Debug.Log(ShareData.data.ingredientData[num]);
        }
    }
}
