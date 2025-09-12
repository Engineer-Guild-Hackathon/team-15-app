using UnityEngine;
using System.IO;
using UnityEditor;

public class DataManager : MonoBehaviour
{
    [HideInInspector] public CArateData data;
    string filepath;
    string fileName = "CArate.json";
    private void Awake()
    {
        filepath = Application.persistentDataPath + "/" + fileName;
        if (!File.Exists(filepath))
        {
            Save(data);
        }

        data = Load(filepath);
    }

    public void Save(CArateData data)
    {
        string json = JsonUtility.ToJson(data);
        StreamWriter wr = new StreamWriter(filepath,false);
        wr.WriteLine(json);
        wr.Close();
    }
    public CArateData Load(string path)
    {
        StreamReader rd = new StreamReader(path);
        string json = rd.ReadToEnd();
        rd.Close();

        return JsonUtility.FromJson<CArateData>(json);
    }

    private void OnDestroy()
    {
        Save(data);
    }
}
