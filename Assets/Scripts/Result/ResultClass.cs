using System.Text;
using UnityEngine;

public class ResultClass
{
    public string GR;
    public string PF;
    public string PR;
    public int Qn;
    public int CACount;
    public double CArate;
    public double TimeScore;
    public int ConsecutiveCA;
    public string DayS;

    public ResultClass(string dayS, string gR, string pF, string pR, int qn ,int cACount, double cArate, int consecutiveCA, double timeScore)
    {
        GR = gR;
        PF = pF;
        PR = pR;
        CACount = cACount;
        CArate = cArate;
        TimeScore = timeScore;
        ConsecutiveCA = consecutiveCA;
        DayS = dayS;
        Qn = qn;
    }
}
