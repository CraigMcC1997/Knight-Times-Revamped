using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level1";
    [SerializeField] private string ControlsScene = "Controls";

    public void StartGameButton()
    {
        SceneManager.LoadScene(newGameLevel); 
    }

    public void DisplayControlsButton()
    {
        SceneManager.LoadScene(ControlsScene);
    }
    
    public void OpenSettingsButton()
    {
       //fill this in
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }
}
