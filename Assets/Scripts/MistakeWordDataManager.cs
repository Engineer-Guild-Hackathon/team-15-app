using UnityEngine;
using System.IO;
using UnityEditor;

public class MistakeWordDataManager : MonoBehaviour
{
    [HideInInspector] public SGMistakeWordlist data;
    string filepath;
    string fileName = "SGMistakeWordlist.json";
    private void Awake()
    {
        filepath = Application.persistentDataPath + "/" + fileName;
        if (!File.Exists(filepath))
        {
            Save(data);
        }
        Debug.Log(filepath);
        data = Load(filepath);
    }

    public void Save(SGMistakeWordlist data)
    {
        string json = JsonUtility.ToJson(data);
        StreamWriter wr = new StreamWriter(filepath, false);
        wr.WriteLine(json);
        wr.Close();
    }
    public SGMistakeWordlist Load(string path)
    {
        StreamReader rd = new StreamReader(path);
        string json = rd.ReadToEnd();
        rd.Close();

        return JsonUtility.FromJson<SGMistakeWordlist>(json);
    }

    private void OnDestroyOnApplicationQuit()
    {
        Save(data);
    }
}
