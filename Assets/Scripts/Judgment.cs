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
            if(LevelVariable.PR_ == "R") GV.RICA.Add(GV.WordCn);
        }
        else
        {
            GV.InCA++;
            if(DuplicateJudgment()) GV.Mistakes.Add(LevelVariable.WordList_[GV.WordCn]);

        }
        GV.WordCn++;
        if (GV.WordCn < 5) AQ.askQuestion();
        else ASC.ansSumCal();
    }

    private bool DuplicateJudgment()
    {
        for(int i = 0; i < GV.Mistakes.Count; i++)
        {
            if(GV.Mistakes[i].Number == LevelVariable.WordList_[GV.WordCn].Number)
            {
                return false;
            }
        }
        return true;
    }

}
