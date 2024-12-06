using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public string nameUser = "User";

    private void Awake()
    {
        // ���������, ��� ������ ���������� ������ ���� ���
        if (FindObjectsOfType<MenuManager>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        // ��������� ������ ��� ����� �����
        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // ������������� ���� � ���������
#else
        Application.Quit();
#endif
    }

    public void ChangeName()
    {
        nameUser = inputField.text;
        Debug.Log(name);
    }
    
}
