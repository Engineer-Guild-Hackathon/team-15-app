using UnityEngine;
using System.IO;
using UnityEditor;
using NUnit.Framework;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.Scripting;

public class DataManager : MonoBehaviour
{
    string filepath;


    public void Save(List<int> data, string fileName)
    {
        filepath = Application.persistentDataPath + "/" + fileName;
        if (!File.Exists(filepath)) using (FileStream fs = File.Create(filepath)) ;
        StreamWriter wr = new StreamWriter(filepath,false);
        foreach(int i in data) wr.WriteLine(i);
        wr.Close();
    }
    public void Save(List<WordlistClass> data, string fileName)
    {
        filepath = Application.persistentDataPath + "/" + fileName;
        if (!File.Exists(filepath)) using (FileStream fs = File.Create(filepath)) ;
        StreamWriter wr = new StreamWriter(filepath, false);
        foreach (WordlistClass i in data)
        {
            wr.WriteLine(i.PoF);
            wr.WriteLine(i.Rank);
            wr.WriteLine(i.English);
            wr.WriteLine(i.Japanese);
            wr.WriteLine(i.Number);
        }
        wr.Close();
    }

    public void Save(List<double> data, string fileName)
    {
        filepath = Application.persistentDataPath + "/" + fileName;
        if (!File.Exists(filepath)) using (FileStream fs = File.Create(filepath)) ;
        StreamWriter wr = new StreamWriter(filepath, false);
        foreach (double i in data) wr.WriteLine(i);
        wr.Close();
    }

    public List<WordlistClass> Load(string fileName)
    {
        filepath = Application.persistentDataPath + "/" + fileName;
        StreamReader reader = new StreamReader(filepath);
        List<WordlistClass> result = new List<WordlistClass>();
        List<string> TextData = new List<string>();
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            Debug.Log(line);
            TextData.Add(line);
        }
        reader.Close();
        Debug.Log(TextData.Count);
        for (int i = 0; i < TextData.Count; i += 5)
        {
            WordlistClass temp = new WordlistClass(TextData[i], TextData[i + 1], TextData[i + 2], TextData[i + 3], TextData[i + 4]);
            result.Add(temp);
        }
        return result;
    }

}
