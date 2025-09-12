using UnityEngine;

public class Judgment : MonoBehaviour
{
    GameVar GV;
    AskQuestion AQ;
    AnswerSumCalculation ASC;

    public void JudgmentQuestion(string Ans)
    {
        GV = GetComponent<GameVar>();
        AQ = GetComponent<AskQuestion>();
        ASC = GetComponent<AnswerSumCalculation>();

        if (Ans == LevelVariable.WordList_[GV.WordCn].English)
        {
            GV.CA++;

        }
        else
        {
            GV.InCA++;
            GV.Mistakes.Add(LevelVariable.WordList_[GV.WordCn]);

        }
        GV.WordCn++;
        if (GV.WordCn < 5) AQ.askQuestion();
        else ASC.ansSumCal();
    }
}
