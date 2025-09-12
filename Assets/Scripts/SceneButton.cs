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
        SceneManager.LoadScene("SampleScene");
    }
}
