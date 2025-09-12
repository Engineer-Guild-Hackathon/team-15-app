using UnityEngine;

public class GameStart : MonoBehaviour
{
    AskQuestion AQ;
    GameVar GV;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AQ = GetComponent<AskQuestion>();
        GV = GetComponent<GameVar>();
        AQ.askQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
