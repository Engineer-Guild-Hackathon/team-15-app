using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    //InputFieldを格納するための変数
    private TMP_InputField inputField;
    public string AnsJS;
    public Judgment judgment;

    // Start is called before the first frame update
    void Start()
    {
        // InputFieldコンポーネントを取得
        // エディタ上でpublic変数に設定したほうがより良いです
        inputField = GameObject.Find("InputField").GetComponent<TMP_InputField>();

    }

    // 入力された名前情報を読み取ってコンソールに出力する関数
    // OnEndEditイベントの引数を受け取るように変更
    public void GetInputName(string text)
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            inputField.ActivateInputField();
            StartCoroutine(ReloadInputField());
        }
        // Enterキーで確定された時のみ処理を実行
        if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
        {
            // AnsJSにテキストを格納
            AnsJS = text;
            Debug.Log("Enterキーで入力されました: " + AnsJS);

            // Judgmentスクリプトを取得し、関数を呼び出し
            // GetComponentは毎回呼び出すとパフォーマンスに影響するため、Start()で取得しておくと良いです
            judgment = GetComponent<Judgment>();
            judgment.JudgmentQuestion(AnsJS);

            // 入力フォームのテキストを空にする
            inputField.text = "";

            // 0.5秒後に再びInputFieldをアクティブにするコルーチンを開始
            StartCoroutine(ActivateInputFieldAfterDelay());
        }
    }

    // InputFieldを再度アクティブにするためのコルーチン
    private IEnumerator ActivateInputFieldAfterDelay()
    {
        yield return new WaitForSeconds(0.5f);
        inputField.ActivateInputField();
    }

    private IEnumerator ReloadInputField()
    {
        yield return null;
        inputField.MoveTextEnd(true);
    }
}