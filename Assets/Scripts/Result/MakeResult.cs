using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MakeResult : MonoBehaviour
{
    List<string[]> TextData = new List<string[]>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string filepath = Application.persistentDataPath + "/Results.txt";
        if (!File.Exists(filepath)) using (FileStream fs = File.Create(filepath)) ;
        StreamReader reader = new StreamReader(filepath);
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            TextData.Add(line.Split(','));
        }
        reader.Close();
        foreach (string[] v in TextData)
        {
            ResultClass RC = new ResultClass(v[0], v[1], v[2], v[3], int.Parse(v[4]), int.Parse(v[5]), double.Parse(v[6]), int.Parse(v[7]), double.Parse(v[8]));
            if(RC.GR == LevelVariable.GR_ && RC.PF == LevelVariable.PF_ && RC.PR == LevelVariable.PR_) LevelVariable.ResultList_.Add(RC);
        }

    }

}
