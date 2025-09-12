using System.Text;
using UnityEngine;

public class ResultClass
{
    string GR;
    string PF;
    string PR;
    int CACount;
    double CArate;
    double TimeScore;
    int ConsecutiveCA;

    public ResultClass(string gR, string pF, string pR, int cACount, double cArate, double timeScore, int consecutiveCA)
    {
        GR = gR;
        PF = pF;
        PR = pR;
        CACount = cACount;
        CArate = cArate;
        TimeScore = timeScore;
        ConsecutiveCA = consecutiveCA;
    }
}
