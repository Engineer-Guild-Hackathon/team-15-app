using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    //InputField���i�[���邽�߂̕ϐ�
    private TMP_InputField inputField;
    public string AnsJS;
    public Judgment judgment;

    // Start is called before the first frame update
    void Start()
    {
        // InputField�R���|�[�l���g���擾
        // �G�f�B�^���public�ϐ��ɐݒ肵���ق������ǂ��ł�
        inputField = GameObject.Find("InputField").GetComponent<TMP_InputField>();

    }

    // ���͂��ꂽ���O����ǂݎ���ăR���\�[���ɏo�͂���֐�
    // OnEndEdit�C�x���g�̈������󂯎��悤�ɕύX
    public void GetInputName(string text)
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            inputField.ActivateInputField();
            StartCoroutine(ReloadInputField());
        }
        // Enter�L�[�Ŋm�肳�ꂽ���̂ݏ��������s
        if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
        {
            // AnsJS�Ƀe�L�X�g���i�[
            AnsJS = text;
            Debug.Log("Enter�L�[�œ��͂���܂���: " + AnsJS);

            // Judgment�X�N���v�g���擾���A�֐����Ăяo��
            // GetComponent�͖���Ăяo���ƃp�t�H�[�}���X�ɉe�����邽�߁AStart()�Ŏ擾���Ă����Ɨǂ��ł�
            judgment = GetComponent<Judgment>();
            judgment.JudgmentQuestion(AnsJS);

            // ���̓t�H�[���̃e�L�X�g����ɂ���
            inputField.text = "";

            // 0.5�b��ɍĂ�InputField���A�N�e�B�u�ɂ���R���[�`�����J�n
            StartCoroutine(ActivateInputFieldAfterDelay());
        }
    }

    // InputField���ēx�A�N�e�B�u�ɂ��邽�߂̃R���[�`��
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