using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    AnswerSumCalculation ASC;


    public void BackToTitle()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        ASC = GetComponent<AnswerSumCalculation>();
        ASC.ansSumCal();
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
