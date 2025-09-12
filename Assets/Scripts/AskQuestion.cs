using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class AskQuestion : MonoBehaviour
{
    [SerializeField] TMP_Text PofText;
    [SerializeField] TMP_Text NumText;
    [SerializeField] TMP_Text QuestionText;
    GameVar GV;
    InputFieldManager IFM;
    public void askQuestion()
    {
        IFM = GetComponent<InputFieldManager>();
        GV = GetComponent<GameVar>();
        bool cS = canShow(GV.WordCn);
        if (cS)
        {
            PofText.text = "ëÊ" + GV.Qn + "ñ‚";
            NumText.text = "ÅyïiéåÅz" + LevelVariable.WordList_[GV.WordCn].PoF;
            if(LevelVariable.PF_ == "JtoS")
            {
                QuestionText.text = LevelVariable.WordList_[GV.WordCn].Japanese;
            }
            else if(LevelVariable.PF_ == "JtoE_4C")
            {

            }
            GV.Qn++;
        }
    }

    public bool canShow(int i) {
        string pr = LevelVariable.PR_;
        string pof = LevelVariable.WordList_[i].PoF;
        string fr = LevelVariable.WordList_[i].Rank;
        if (pr == "WI" || pr == "R") return true;
        else if(pr == "AW")
        {
            if(pof != "ènåÍ") return true;
            else return false;
        }
        else if(pr == "WA")
        {
            if(pof != "ènåÍ" && fr =="A") return true;
            else return false;
        }
        else if (pr == "WB")
        {
            if (pof != "ènåÍ" && fr == "B") return true;
            else return false;
        }
        else if (pr == "WC")
        {
            if (pof != "ènåÍ" && fr == "C") return true;
            else return false;
        }
        else if(pr == "V")
        {
            if(pof == "ìÆéå") return true;
            else return false;
        }
        else if (pr == "N")
        {
            if (pof == "ñºéå") return true;
            else return false;
        }
        else if (pr == "O")
        {
            if (pof == "å`óeéåÅEïõéåÅEÇªÇÃëº") return true;
            else return false;
        }
        else if (pr == "AI")
        {
            if (pof == "ènåÍ") return true;
            else return false;
        }
        else if (pr == "IA")
        {
            if (pof == "ènåÍ" && fr == "A") return true;
            else return false;
        }
        else if (pr == "IB")
        {
            if (pof == "ènåÍ" && fr == "B") return true;
            else return false;
        }
        else return false;
    }
}
