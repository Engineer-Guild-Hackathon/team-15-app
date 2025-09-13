using UnityEngine;

public class PanelBtn : MonoBehaviour
{
    [SerializeField] GameObject[] Groups;
    [SerializeField] GameObject PFPanel;
    [SerializeField] GameObject PRPanel;
    int i = 0;
    public void RightBtn()
    {
        Groups[i].gameObject.SetActive(false);
        i++;
        if (i >= Groups.Length) i = Groups.Length - 1;
        Groups[i].gameObject.SetActive(true);
    }

    public void LeftBtn()
    {
        Groups[i].gameObject.SetActive(false);
        i--;
        if (i <= 0) i = 0;
        Groups[i].gameObject.SetActive(true);
    }

    public void ReturnGRBtn()
    {
        PFPanel.SetActive(false);
    }

    public void ReturnPFBtn()
    {
        PRPanel.SetActive(false);
    }
}
