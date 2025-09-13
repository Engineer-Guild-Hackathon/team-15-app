using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultLevelBtn : MonoBehaviour
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
        SceneManager.LoadScene("ReLoadingScene");
    }
    public void AWbutton()
    {
        LevelVariable.PR_ = "AW";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void WAbutton()
    {
        LevelVariable.PR_ = "WA";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void WBbutton()
    {
        LevelVariable.PR_ = "WB"; 
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void WCbutton()
    {
        LevelVariable.PR_ = "WC";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void Vbutton()
    {
        LevelVariable.PR_ = "V";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void Nbutton()
    {
        LevelVariable.PR_ = "N";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void Obutton()
    {
        LevelVariable.PR_ = "O";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void AIbutton()
    {
        LevelVariable.PR_ = "AI";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void IAbutton()
    {
        LevelVariable.PR_ = "IA";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void IBbutton()
    {
        LevelVariable.PR_ = "IB";
        SceneManager.LoadScene("ReLoadingScene");

    }
    public void Rbutton()
    {
        LevelVariable.PR_ = "R";
        SceneManager.LoadScene("ReLoadingScene");

    }

}
