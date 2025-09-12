using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void GoToLevelScene()
    {
        SceneManager.LoadScene("LevelScene");
    }
}
