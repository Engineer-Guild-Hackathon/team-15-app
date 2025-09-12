using UnityEngine;
using System.IO;
using UnityEditor;
using NUnit.Framework;
using System.Collections.Generic;

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

    /*
    public CArateData Load(string path)
    {
        StreamReader rd = new StreamReader(path);
        string json = rd.ReadToEnd();
        rd.Close();

        return JsonUtility.FromJson<CArateData>(json);
    }
    */
}
