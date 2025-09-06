using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugChangeCard : MonoBehaviour
{

    CardModel cardModel;
    Cardflipper flipper;
    //CardModel�N���X���Q�Ƃ��܂���B
    int cardIndex = 0;
    //cardIndex�̒l��錾

    public GameObject card;
    //�O������Q�Ƃ���\���card�Ƃ����I�u�W�F�N�g�̐錾�i��Ƀh���b�O�A���h�h���b�v�j�B

    private void Awake()
    {
        cardModel = card.GetComponent<CardModel>();
        flipper = card.GetComponent<Cardflipper>();
        //card�ɃA�^�b�`����Ă���CardModel���擾���Ďg�p���܂��B
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 28), "Hit me!"))  //����hitme!�{�^���������ꂽ�ꍇ���L�����s
        {
            if (cardIndex >= cardModel.faces.Length)
            // �����@cardIndex �� cardModel��faces�̃��X�g�̒����i�T�Q�j�Ɠ������傫�������牺�L�����s�i�Ō�̃J�[�h�̎��̏����j
            {
                cardIndex = 0;      // cardIndex �ɂO����
                flipper.FlipCard(cardModel.faces[cardModel.faces.Length - 1], cardModel.cardBack, -1);
                // flipCard�̎��s�A�����Ƀf�b�L�̍Ō�̃J�[�h,���݂̃J�[�h,�C���f�b�N�X��-1(CardFlipper�ŗ��ʃ����_�[�����j
            }
            else //����ȊO�̎�
            {
                if (cardIndex > 0)
                {
                    flipper.FlipCard(cardModel.faces[cardIndex - 1], cardModel.faces[cardIndex], cardIndex);
                    // flipCard�̎��s�A�����Ɉ�O�̃J�[�h,���݂̃J�[�h,�C���f�b�N�X
                }
                else //cardindex���O�̎�
                {
                    flipper.FlipCard(cardModel.cardBack, cardModel.faces[cardIndex], cardIndex);
                    //flipCard�̎��s�A�����ɗ���,���݂̃J�[�h,�C���f�b�N�X
                }
                cardIndex++;    //cardIndex���C���N�������g
            }

        }

    }

}