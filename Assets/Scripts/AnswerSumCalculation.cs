using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Collections.Generic;


public class AnswerSumCalculation : MonoBehaviour
{
    GameVar GV;
    DataManager DM;
    [SerializeField] TMP_Text CArateText;
    [SerializeField] TMP_Text TimeText;
    [SerializeField] TMP_Text CAText;
    [SerializeField] TMP_Text QnText;
    [SerializeField] GameObject GameOverPanel;

    public void ansSumCal()
    {
        GameOverPanel.SetActive(true);
        GV = GetComponent<GameVar>();
        
        DM = GetComponent<DataManager>();

        double CArate = Mathf.Round((float)GV.CA / (float)(GV.Qn-1) * 1000f) / 10 ;
        CArateText.text = CArate.ToString() + "%";
        CAText.text = GV.CA.ToString();
        QnText.text = (GV.Qn-1).ToString();

        GV.CArates.Add(CArate);
        GV.CACounts.Add(GV.CA);
        DM.Save(GV.Mistakes, LevelVariable.GR_ + "MistakeWordlist.txt");
        DM.Save(GV.CArates, "/CArate.txt");
        DM.Save(GV.CACounts, "/CACount.txt");

        if (LevelVariable.PR_ == "R")
        {
            List<WordlistClass> ReMistakes = new List<WordlistClass>();
            for (int i = 0; i < LevelVariable.WordList_.Count; i++)
            {
                if (!GV.RICA.Contains(i)) ReMistakes.Add(LevelVariable.WordList_[i]);
            }
            DM.Save(ReMistakes, LevelVariable.GR_ + "MistakeWordlist.txt");
        }
    }
}
