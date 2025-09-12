using UnityEngine;
using TMPro;
using Unity.VisualScripting;

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

        //CAD = DM.Load(Application.persistentDataPath + "/CArate.json");
        //SGMW = MWDM.Load(Application.persistentDataPath + "/SGMistakeWordlist.json");
        //CAC = CACDM.Load(Application.persistentDataPath + "/CACount.json");

        double CArate = Mathf.Round(GV.CA / GV.Qn * 1000) / 10 ;
        CArateText.text = CArate.ToString() + "%";
        CAText.text = CArate.ToString();
        QnText.text = (GV.Qn-1).ToString();

        GV.CArates.Add(CArate);
        GV.CACounts.Add(GV.CA);
        DM.Save(GV.Mistakes, LevelVariable.GR_ + "MistakeWordlist.txt");
        DM.Save(GV.CArates, "/CArate.txt");
        DM.Save(GV.CACounts, "/CACount.txt");
    }
}
