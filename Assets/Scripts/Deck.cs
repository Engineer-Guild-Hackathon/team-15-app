using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    List<int> cards; //���X�g�̐錾�B

    public IEnumerable<int> GetCards() //�߂�l�ɗ񋓉\�ȃ��X�g�������\�b�h
    {
        foreach (int i in cards)�@//cards�̒��̗v�f���ꂼ��ɂ���
        {
            yield return i; //�v�f��߂�l�ɕԂ��܂�
        }
    }

    public void Shuffle()�@//shuffle���\�b�h�{�́B
    {
        if (cards == null)�@//cards����ł���΁B
        {
            cards = new List<int>();�@//card�̏������B

        }
        else�@//���̑��̏ꍇ�B
        {
            cards.Clear();�@//cards����ɂ���B
        }

        for (int i = 0; i < 52; i++)
        //�����li=0����52�ȉ��̏ꍇ���L���J��Ԃ�i���C���N�������g�B
        {
            cards.Add(i);�@//���X�g��i��������B
        }

        int n = cards.Count; //�������̏����l�̓J�[�h�̖����Ƃ���B
        while (n > 1)�@//n���P���傫���ꍇ���L���J��Ԃ��B
        {
            n--;�@//n���f�B�N�������g
            int k = Random.Range(0, n + 1);//k�͂O�`n+1�̊Ԃ̃����_���Ȑ��Ƃ���
            int temp = cards[k];�@//k�Ԗڂ̃J�[�h��temp�ɑ��
            cards[k] = cards[n];�@//k�Ԗڂ̃C���f�b�N�X��n�Ԗڂ̃C���f�b�N�X����
            cards[n] = temp;�@//n�Ԗڂ̃C���f�b�N�X��temp(k�Ԗڂ̃C���f�b�N�X�j����
        }
    }

    void Awake()
    {
        Shuffle();�@�@//shuffle���\�b�h�����s
    }
}
