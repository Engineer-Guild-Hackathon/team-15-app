using UnityEngine;

public class _Debug : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            for (int i = 0; i < LevelVariable.ResultList_.Count; i++)
            {
                Debug.Log(LevelVariable.ResultList_[i].CACount);
            }

        }

    }
}
