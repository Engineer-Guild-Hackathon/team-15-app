using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelModel : MonoBehaviour
{

    [SerializeField] GameObject PFPanel;
    [SerializeField] GameObject PRPanel;

    public void SGbutton()
    {
        LevelVariable.GR_ = "SG";
        PFPanel.SetActive(true);
    }

    public void PFGbutton()
    {
        LevelVariable.GR_ = "PFG";
        PFPanel.SetActive(true);
    }

    public void JtoSbutton()
    {
        LevelVariable.PF_ = "JtoS";
        PRPanel.SetActive(true);

    }

    public void JtoE_4Cbutton()
    {
        LevelVariable.PF_ = "JtoE_4C";
        PRPanel.SetActive(true);
    }

    public void WIbutton()
    {
        LevelVariable.PR_ = "WI";
        SceneManager.LoadScene("LoadingScene");
    }
    public void AWbutton()
    {
        LevelVariable.PR_ = "AW";
        SceneManager.LoadScene("LoadingScene");
    }
    public void WAbutton()
    {
        LevelVariable.PR_ = "WA";
        SceneManager.LoadScene("LoadingScene");
    }
    public void WBbutton()
    {
        LevelVariable.PR_ = "WB";
        SceneManager.LoadScene("LoadingScene");

    }
    public void WCbutton()
    {
        LevelVariable.PR_ = "WC";
        SceneManager.LoadScene("LoadingScene");

    }
    public void Vbutton()
    {
        LevelVariable.PR_ = "V";
        SceneManager.LoadScene("LoadingScene");

    }
    public void Nbutton()
    {
        LevelVariable.PR_ = "N";
        SceneManager.LoadScene("LoadingScene");

    }
    public void Obutton()
    {
        LevelVariable.PR_ = "O";
        SceneManager.LoadScene("LoadingScene");

    }
    public void AIbutton()
    {
        LevelVariable.PR_ = "AI";
        SceneManager.LoadScene("LoadingScene");

    }
    public void IAbutton()
    {
        LevelVariable.PR_ = "IA";
        SceneManager.LoadScene("LoadingScene");

    }
    public void IBbutton()
    {
        LevelVariable.PR_ = "IB";
        SceneManager.LoadScene("LoadingScene");

    }
    public void Rbutton()
    {
        LevelVariable.PR_ = "R";
        SceneManager.LoadScene("LoadingScene");

    }

}
