using UnityEngine;

public class DeckView : MonoBehaviour
{
    Deck deck; //Deck�N���X���Q�Ƃ��܂�
    public Vector3 start;  //�ŏ��̃J�[�h�̈ʒu
    public float cardOffset;�@//�J�[�h�����炷��
    public GameObject cardPrefab;�@//instantiate����v���t�@�u
    private void Start()
    {
        deck = GetComponent<Deck>();�@//Deck.cs�̎擾
        ShowCards();�@//���L���\�b�h�̎��s
    }
    void ShowCards()�@//���\�b�h�{��
    {
        int cardCount = 0;�@//�����Ŏg���lcardCount�̐錾
        foreach (int i in deck.GetCards())
        {
            float co = cardOffset * cardCount; //�I�t�Z�b�g���̌v�Z
            GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
            //�J�[�h�v���t�@�u�̃R�s�[
            Vector3 temp = start + new Vector3(co, 0f);
            //temp�Ƃ����I�t�Z�b�g�����ʒu�̌v�Z
            cardCopy.transform.position = temp;
            //���݂̈ʒu��temp����
            cardCount++;�@//cardCount���C���N�������g

            CardModel cardModel = cardCopy.GetComponent<CardModel>();
            //�R�s�[�����J�[�h�v���t�@�u��CardModel�N���X���擾
            cardModel.cardIndex = i;
            //�C���f�b�N�X��i����
            cardModel.ToggleFace(true);
            //�\�ʂ������_�[�i�J�[�h�Q�[������肽����2��ڂō쐬�����X�N���v�g���g�p�j
        }

    }
}
