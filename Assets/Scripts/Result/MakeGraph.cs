using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using TMPro;
using Unity.Hierarchy;


public class MakeGraph : MonoBehaviour
{
    private RectTransform m_RectTransform;
    [SerializeField] Sprite circleSprite;

    private RectTransform m_templateLabelX;
    private RectTransform m_templateLabelY;

    private RectTransform m_templateBarVertical;
    private RectTransform m_templateBarHorizontal;
    private RectTransform m_templateLabelText;

    private void Awake()
    {
        m_RectTransform = transform.Find("view").GetComponent<RectTransform>();
        m_templateLabelX = transform.Find("view/labelX").GetComponent<RectTransform>();
        m_templateLabelY = transform.Find("view/labelY").GetComponent<RectTransform>();
        m_templateBarVertical = transform.Find("view/barVertical").GetComponent<RectTransform>();
        m_templateBarHorizontal = transform.Find("view/barHorizontal").GetComponent<RectTransform>();
        m_templateLabelText = transform.Find("view/LabelText").GetComponent<RectTransform>();
        ShowGraph();
    }

    private GameObject CreateDot(Vector2 _position)
    {
        GameObject obj = new GameObject("circle", typeof(Image));
        obj.GetComponent<Image>().color = Color.black;
        obj.GetComponent<Image>().sprite = circleSprite;
        obj.transform.SetParent(m_RectTransform, false);
        RectTransform rtDot = obj.GetComponent<RectTransform>();
        rtDot.anchoredPosition = _position;
        rtDot.sizeDelta = new Vector2(12.0f, 12.0f);
        rtDot.anchorMin = Vector2.zero;
        rtDot.anchorMax = Vector2.zero;
        return obj;
    }

    private void ShowGraph()
    {
        float fGraphHeight = m_RectTransform.sizeDelta.y;
        float fGraphWidth = m_RectTransform.sizeDelta.x;
        float fMaxY = 100.0f;
        float fPitchX = fGraphWidth/LevelVariable.ResultList_.Count;
        float fOffsetX = 50f;
        GameObject objLast = null;

        for(int i = 0; i < LevelVariable.ResultList_.Count; i++)
        {
            float fPosX = i * fPitchX + fOffsetX;
            float fPosY = ((float)LevelVariable.ResultList_[i].CArate / fMaxY) * fGraphHeight;
            GameObject objDot = CreateDot(new Vector2(fPosX, fPosY));

            if (objLast != null)
            {
                CreateLine(objLast.GetComponent<RectTransform>().anchoredPosition, objDot.GetComponent<RectTransform>().anchoredPosition);
            }
            objLast = objDot;

            RectTransform rtLabelX = Instantiate(m_templateLabelX, m_RectTransform);
            rtLabelX.gameObject.SetActive(true);
            rtLabelX.anchoredPosition = new Vector2(fPosX, 0f);
            rtLabelX.GetComponent<TMP_Text>().text = (i+1).ToString();

            RectTransform rtBarVertical = Instantiate(m_templateBarVertical, m_RectTransform);
            rtBarVertical.gameObject.SetActive(true);
            rtBarVertical.anchoredPosition = new Vector2(fPosX, 0f);

            RectTransform rtLabelText = Instantiate(m_templateLabelText, m_RectTransform);
            rtLabelText.gameObject.SetActive(true);
            rtLabelText.anchoredPosition = new Vector2(fPosX, fPosY+92f);
            rtLabelText.GetComponent<TMP_Text>().text = LevelVariable.ResultList_[i].CArate.ToString();


        }

        int verticalCount = 10;
        for (int i = 0; i <= verticalCount; i++)
        {
            RectTransform rtLabelY = Instantiate(m_templateLabelY, m_RectTransform);
            rtLabelY.gameObject.SetActive(true);
            float normalizedValue = i * 1.0f / verticalCount;
            float labelHeight = normalizedValue * fGraphHeight;
            rtLabelY.anchoredPosition = new Vector2(0f,labelHeight);
            rtLabelY.GetComponent<TMP_Text>().text =Mathf.RoundToInt( normalizedValue * fMaxY).ToString();

            RectTransform rtBarHorizontal = Instantiate(m_templateBarHorizontal, m_RectTransform);
            rtBarHorizontal.gameObject.SetActive(true);
            rtBarHorizontal.anchoredPosition = new Vector2(0f, labelHeight);

        }

    }

    private void CreateLine(Vector2 _pointA, Vector2 _pointB)
    {
        GameObject obj = new GameObject("dotLine", typeof(Image));
        obj.GetComponent<Image>().color = new Color(0,0,200,0.5f);
        obj.transform.SetParent(m_RectTransform, false);
        RectTransform rtLine = obj.GetComponent<RectTransform>();
        
        Vector2 dir = (_pointB - _pointA).normalized;
        float fDistance = Vector2.Distance(_pointA, _pointB);

        rtLine.anchorMin = Vector2.zero;
        rtLine.anchorMax = Vector2.zero;
        rtLine.sizeDelta = new Vector2(fDistance, 5.0f);
        rtLine.localEulerAngles = new Vector3(0,0,Vector2.SignedAngle(new Vector2(1.0f,0.0f), dir));
        rtLine.anchoredPosition = _pointA + dir*fDistance*0.5f;

    }

}
