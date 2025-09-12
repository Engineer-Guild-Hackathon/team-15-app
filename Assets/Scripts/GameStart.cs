using UnityEngine;

public class GameStart : MonoBehaviour
{
    AskQuestion AQ;
    GameVar GV;
    DataManager DM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AQ = GetComponent<AskQuestion>();
        GV = GetComponent<GameVar>();
        DM = GetComponent<DataManager>();
        GV.Mistakes = DM.Load(LevelVariable.GR_ + "MistakeWordlist.txt");
        for(int i = 0; i < GV.Mistakes.Count ; i++) Debug.Log(GV.Mistakes[i].English);
        AQ.askQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
