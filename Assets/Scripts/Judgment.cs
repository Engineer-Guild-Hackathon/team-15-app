using UnityEngine;

public class Judgment : MonoBehaviour
{
    GameVar GV;
    AskQuestion AQ;
    AnswerSumCalculation ASC;
    SGMistakeWordlist SGMW;
    MistakeWordDataManager MWDM;

    public void JudgmentQuestion(string Ans)
    {
        GV = GetComponent<GameVar>();
        AQ = GetComponent<AskQuestion>();
        ASC = GetComponent<AnswerSumCalculation>();
        MWDM = GetComponent<MistakeWordDataManager>();

        if (Ans == LevelVariable.WordList_[GV.WordCn].English)
        {
            GV.CA++;

        }
        else
        {
            GV.InCA++;

            GV.SGMistakes.Add(LevelVariable.WordList_[GV.WordCn].English);

        }
        GV.WordCn++;
        if (GV.WordCn < 5) AQ.askQuestion();
        else ASC.ansSumCal();
    }
}
