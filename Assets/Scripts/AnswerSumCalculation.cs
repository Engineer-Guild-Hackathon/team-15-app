using UnityEngine;
using TMPro;

public class AnswerSumCalculation : MonoBehaviour
{
    GameVar GV;
    DataManager DM;
    CArateData CAD;
    MistakeWordDataManager MWDM;
    SGMistakeWordlist SGMW;
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
        MWDM = GetComponent<MistakeWordDataManager>();
        CAD = DM.Load(Application.persistentDataPath + "/CArate.json");
        SGMW = MWDM.Load(Application.persistentDataPath + "/SGMistakeWordlist.json");
        
        double CArate = Mathf.Round(GV.CA / GV.Qn * 1000) / 10 ;
        CArateText.text = CArate.ToString() + "%";
        CAText.text = CArate.ToString();
        QnText.text = (GV.Qn-1).ToString();

        CAD.CArates.Add(CArate);
        for (int i = 0; i < GV.SGMistakes.Count; i++)
        {
            SGMW.SGMistakes.Add(GV.SGMistakes[i]);
        }
        for (int i = 0; i < GV.SGMistakes.Count; i++)
        {
            Debug.Log(SGMW.SGMistakes[i]);
        }
        //GV.CArates.Add(CArate);
        DM.Save(CAD);
        MWDM.Save(SGMW);
    }
}
