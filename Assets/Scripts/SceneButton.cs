using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public void JtoSScenebutton()
    {
        SceneManager.LoadScene("JtoSScene");
    }

    public void TitleScenebutton()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void LevelScenebutton()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void ResultScenebutton()
    {
        SceneManager.LoadScene("ResultScene");
    }

    public void GraphScenebutton()
    {
        SceneManager.LoadScene("GraphScene");
    }

    public void EndGamebutton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
}
