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
        public string name;         // ���� �̸�
        public GameObject button;   // ��ư ������Ʈ
    }

    public List<Tool> tools;       // ���� ����Ʈ
    private string selectedTool;   // ���õ� ����
    public Button nextButton;      // ȭ��ǥ ��ư

    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ ����
        foreach (var tool in tools)
        {
            var btn = tool.button.GetComponent<Button>();
            if (btn != null)
            {
                btn.onClick.AddListener(() => SelectTool(tool.name));
            }
        }

        // ȭ��ǥ ��ư Ŭ�� �̺�Ʈ
        nextButton.onClick.AddListener(GoToNextScene);
    }

    // ���� ����
    void SelectTool(string toolName)
    {
        selectedTool = toolName; // ���õ� ���� ����
        ShareData.data.toolData = toolName;
        Debug.Log($"���� ��: {ShareData.data.toolData}");
        Debug.Log($"Selected Tool: {selectedTool}");
    }

    // ���� ������ �̵�
    public void GoToNextScene()
    {
        //if (!string.IsNullOrEmpty(selectedTool))
        //{
            // ���� ������ ����
            PlayerPrefs.SetString("SelectedTool", selectedTool);

            // ���� ������ ����� ��� ������ ��������
            string selectedIngredients = PlayerPrefs.GetString("SelectedIngredients", "[]");

        // ����� ���
        Debug.Log($"Ingredients: {selectedIngredients}");
        Debug.Log($"Tool: {selectedTool}");

            // ���� ������ �̵�
            SceneManager.LoadScene("Score"); // "NextSceneName"�� ���� ���� �� �̸����� ����
        //}
        //else
        //{
        //    Debug.LogError("No tool selected!");
        //}
    }

}
