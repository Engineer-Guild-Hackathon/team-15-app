using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System;
using System.Data;

public class AnswerSumCalculation : MonoBehaviour
{
    GameVar GV;
    DataManager DM;
    [SerializeField] TMP_Text CArateText;
    [SerializeField] TMP_Text TimeText;
    [SerializeField] TMP_Text CAText;
    [SerializeField] TMP_Text QnText;
    [SerializeField] TMP_Text MAXConsecutiveCAText;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject inputField;

    public void ansSumCal()
    {
        inputField.SetActive(false);
        GameOverPanel.SetActive(true);
        GV = GetComponent<GameVar>();
        
        DM = GetComponent<DataManager>();

        double CArate = Mathf.Round((float)GV.CA / (float)(GV.Qn-1) * 1000f) / 10 ;
        double TimeScore = GV.TimeScore;
        CArateText.text = "ê≥âó¶: "+CArate.ToString() + "%";
        CAText.text = "ê≥âêî: "+ GV.CA.ToString();
        QnText.text = "ñ‚ëËêî: " + (GV.Qn-1).ToString();
        TimeText.text = $"{TimeScore:0.0}";
        MAXConsecutiveCAText.text = "ç≈çÇòAë±ê≥âêî: "+GV.MAX_CCA.ToString();
        GV.CArates.Add(CArate);
        DM.Save(GV.Mistakes, LevelVariable.GR_ + "MistakeWordlist.txt");
        DM.Save(GV.CArates, "/CArate.txt");

        if (LevelVariable.PR_ == "R")
        {
            List<WordlistClass> ReMistakes = new List<WordlistClass>();
            for (int i = 0; i < LevelVariable.WordList_.Count; i++)
            {
                if (!GV.RICA.Contains(i)) ReMistakes.Add(LevelVariable.WordList_[i]);
            }
            DM.Save(ReMistakes, LevelVariable.GR_ + "MistakeWordlist.txt");
        }

        string filepath = Application.persistentDataPath + "/Results.txt";
        if (!File.Exists(filepath)) using (FileStream fs = File.Create(filepath)) ;
        StreamWriter wr = new StreamWriter(filepath, true);
        DateTime dateTime = DateTime.Now;
        string TimeString = dateTime.Year.ToString() + "/" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.ToLongTimeString();
        wr.WriteLine(TimeString + "," + LevelVariable.GR_ + "," + LevelVariable.PF_ + "," + LevelVariable.PR_ + "," + GV.Qn + "," + GV.CA + "," + CArate + "," + GV.MAX_CCA + "," + $"{TimeScore:0.0}");
        wr.Close();
    }
}
