using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using TMPro;

[DefaultExecutionOrder(1000)]
public class StartUIHandler : MonoBehaviour
{
    //This is the handler of the main menu scene

    public TMP_Text PlayerNameInput;

	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}

    public void SetPlayerName()
    {
        PlayerDataHandler.Instance.PlayerName = PlayerNameInput.text;
    }

	public void ExitGame()
	{
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
