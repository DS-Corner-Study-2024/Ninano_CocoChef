using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToolManager : MonoBehaviour
{
    [System.Serializable]
    public class Tool
    {
        public string name;         // 도구 이름
        public GameObject button;   // 버튼 오브젝트
    }

    public List<Tool> tools;       // 도구 리스트
    private string selectedTool;   // 선택된 도구
    public Button nextButton;      // 화살표 버튼

    void Start()
    {
        // 버튼 클릭 이벤트 설정
        foreach (var tool in tools)
        {
            var btn = tool.button.GetComponent<Button>();
            if (btn != null)
            {
                btn.onClick.AddListener(() => SelectTool(tool.name));
            }
        }

        // 화살표 버튼 클릭 이벤트
        nextButton.onClick.AddListener(GoToNextScene);
    }

    // 도구 선택
    void SelectTool(string toolName)
    {
        selectedTool = toolName; // 선택된 도구 저장
        ShareData.data.toolData = toolName;
        Debug.Log($"선택 툴: {ShareData.data.toolData}");
        Debug.Log($"Selected Tool: {selectedTool}");
    }

    // 다음 씬으로 이동
    public void GoToNextScene()
    {
        //if (!string.IsNullOrEmpty(selectedTool))
        //{
            // 도구 데이터 저장
            PlayerPrefs.SetString("SelectedTool", selectedTool);

            // 이전 씬에서 저장된 재료 데이터 가져오기
            string selectedIngredients = PlayerPrefs.GetString("SelectedIngredients", "[]");

        // 디버깅 출력
        Debug.Log($"Ingredients: {selectedIngredients}");
        Debug.Log($"Tool: {selectedTool}");

            // 다음 씬으로 이동
            SceneManager.LoadScene("Score"); // "NextSceneName"을 실제 다음 씬 이름으로 변경
        //}
        //else
        //{
        //    Debug.LogError("No tool selected!");
        //}
    }

}
