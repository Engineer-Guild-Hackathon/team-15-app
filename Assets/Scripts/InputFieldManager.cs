using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    //InputFieldを格納するための変数
    TMP_InputField inputField;
    public string AnsJS;
    Judgment judgment;

    // Start is called before the first frame update
    void Start()
    {
        //InputFieldコンポーネントを取得
        inputField = GameObject.Find("InputField").GetComponent<TMP_InputField>();
    }


    //入力された名前情報を読み取ってコンソールに出力する関数
    public void GetInputName()
    {
        judgment = GetComponent<Judgment>();
        StartCoroutine("SomeCoroutine");
    }

    private IEnumerator SomeCoroutine()
    {
        //InputFieldからテキスト情報を取得する
        AnsJS = inputField.text;
        Debug.Log(AnsJS);
        judgment.JudgmentQuestion(AnsJS);
        //入力フォームのテキストを空にする
        inputField.text = "";
        yield return new WaitForSeconds(0.5f);
        inputField.ActivateInputField();
    }
}