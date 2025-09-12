using System.Collections.Generic;
using UnityEngine;

public class GameVar : MonoBehaviour
{
    public int Qn = 1;
    public int CA = 0;
    public int InCA = 0;
    public int WordCn = 0;
    public List<double> CArates;
    public List<WordlistClass> Mistakes = new List<WordlistClass>();
    public List<WordlistClass> RICA = new List<WordlistClass>();
    public List<int> CACounts = new List<int>();
}
