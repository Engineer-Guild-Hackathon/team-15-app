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
            Debug.Log(LevelVariable.GR_);
            Debug.Log(LevelVariable.PF_);
            Debug.Log(LevelVariable.PR_);

        }
    }
}
