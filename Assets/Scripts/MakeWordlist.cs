using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using System.IO.Enumeration;
public class MakeWordlist : MonoBehaviour
{
    TextAsset TextFile;
    List<string> TextData = new List<string>();
    public WordlistClass WLC;
    private string FileName = "";
    private string filepath;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(LevelVariable.GR_ == "SG")
        {
            FileName = "2ãâWordlist";
        }
        else
        {
            FileName = "èÄ1ãâWordlist";
        }
        if (LevelVariable.PR_ == "R")
        {
            filepath = Application.persistentDataPath + "/" + LevelVariable.GR_ + "MistakeWordlist.txt";
            StreamReader reader = new StreamReader(filepath);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                TextData.Add(line);
            }
            reader.Close();
        }
        else
        {
            var tex = Resources.Load(FileName, typeof(TextAsset)) as TextAsset;
            StringReader reader = new StringReader(tex.text);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                TextData.Add(line);
            }
        }


        int WordCount = TextData.Count/5;
        Debug.Log("WordCount = "  +  WordCount);
          
        for (int i = 0; i < TextData.Count; i+= 5)
        {
            WLC = new WordlistClass(TextData[i], TextData[i + 1], TextData[i + 2], TextData[i + 3], TextData[i + 4]);
            LevelVariable.WordList_.Add(WLC);
        }
        while(WordCount > 1)
        {
            WordCount--;
            int k = Random.Range(0, WordCount+1);
            WordlistClass temp = LevelVariable.WordList_[k];
            LevelVariable.WordList_[k] = LevelVariable.WordList_[WordCount];
            LevelVariable.WordList_[WordCount] = temp;
        }

    }

}
