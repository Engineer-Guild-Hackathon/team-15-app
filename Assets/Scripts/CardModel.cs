using UnityEngine;

public class CardModel : MonoBehaviour
{
    public Sprite[] faces;  // �O������Q�Ƃł���i�C���X�y�N�^�[���炢�����jfaces�Ƃ����\�ʂ̃��X�g�̐錾�B
    public Sprite cardBack; // �O������Q�Ƃł���i�C���X�y�N�^�[���炢�����jcardBack�Ƃ������ʂ̐錾�B

    public int cardIndex;
    SpriteRenderer spriteRenderer;

    public void ToggleFace(bool showFace)�@//�O���A�N�Z�X�\��ToggleFace�Ƃ������\�b�h�̒�`�@�����ɐ^�U�l�Ƃ���showFace�����B
    {

        if (showFace)�@// ���� showface ��true�ł���΁A
        {
            spriteRenderer.sprite = faces[cardIndex];  //�A�Ŏ擾����sprite��faces[�^����ꂽ�C���f�b�N�X�l]�������_�[������B
        }
        else
        {
            spriteRenderer.sprite = cardBack;�@�@//�A�Ŏ擾����sprite��cardback�������_�[������B
        }
    }
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //���̃X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g�̃C���X�y�N�^�[���spriteRenderer���擾���܂��B�@�ƃZ�b�g�B�A
    }
}
