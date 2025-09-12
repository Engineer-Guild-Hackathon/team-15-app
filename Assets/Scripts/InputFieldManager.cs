using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    //InputField���i�[���邽�߂̕ϐ�
    TMP_InputField inputField;
    public string AnsJS;
    Judgment judgment;

    // Start is called before the first frame update
    void Start()
    {
        //InputField�R���|�[�l���g���擾
        inputField = GameObject.Find("InputField").GetComponent<TMP_InputField>();
    }


    //���͂��ꂽ���O����ǂݎ���ăR���\�[���ɏo�͂���֐�
    public void GetInputName()
    {
        judgment = GetComponent<Judgment>();
        StartCoroutine("SomeCoroutine");
    }

    private IEnumerator SomeCoroutine()
    {
        //InputField����e�L�X�g�����擾����
        AnsJS = inputField.text;
        Debug.Log(AnsJS);
        judgment.JudgmentQuestion(AnsJS);
        //���̓t�H�[���̃e�L�X�g����ɂ���
        inputField.text = "";
        yield return new WaitForSeconds(0.5f);
        inputField.ActivateInputField();
    }
}