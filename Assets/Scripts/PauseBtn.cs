using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

public class PauseBtn : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;

    public void BackToTitle()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScene");
    }

    public void ShowPausePanel()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);

    }

    public void HidePausePanel()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);

    }
}
