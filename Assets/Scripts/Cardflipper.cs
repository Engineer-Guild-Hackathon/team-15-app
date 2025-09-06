using UnityEngine;
using System.Collections;

public class Cardflipper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;  //SpriteRender�N���X���Q�Ƃ��܂��B
    CardModel model;�@�@�@//CardModel�N���X���Q�Ƃ��܂��B

    public AnimationCurve scaleCurve;�@�@//AnimationCurve���O���Q�Ƃ��܂��@scaleCurve�Ƃ������ňȉ��̃X�N���v�g�ł͋L�ڂ��܂��B
    public float duration = 0.5f;�@�@�@�@// duration �Ƃ����t���[�g�̒l�i�̐錾�j��0.5�ł��B

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();�@�@//SpriteRenderer�̎擾�B
        model = GetComponent<CardModel>();�@�@//CardModel.cs ���擾�B
    }

    public void FlipCard(Sprite startImage, Sprite endImage, int cardIndex)�@�@//���\�b�h�̐錾FlipCard()
    {
        StopCoroutine(Flip(startImage, endImage, cardIndex));     //���ݓ����Ă���R�[���[�`���i���̏ꍇ�O��̃A�j���[�V���������j���~�߂܂��B
        StartCoroutine(Flip(startImage, endImage, cardIndex));�@�@�@//�V���ɃR�[���[�`���i���̏ꍇ����̃A�j���[�V���������j���n�߂܂��B
    }
    IEnumerator Flip(Sprite startImage, Sprite endImage, int cardIndex)�@�@//�R�[���[�`���œ������\�b�hFlip�̒�`�B
    {
        spriteRenderer.sprite = startImage;�@�@�@// SpriteRender�ŃX�v���C�g�̍ŏ��̃C���[�W�i�����ŗ^����ꂽ���́j�������_�[

        float time = 0f;�@�@�@�@�@�@�@// �����_�̒l�̐錾�ƂO�̑��
        while (time <= 1f)�@�@�@�@�@�@// time ���P�Ɠ��������������ꍇ���L�������J��Ԃ�
        {
            float scale = scaleCurve.Evaluate(time);�@�@�@�@//�����_scale �̐錾��time�ɑΉ�����AnimationCurve�O���t�ł�Scale�̒l�̑���B
            time = time + Time.deltaTime / duration;�@�@�@�@//time �Ɂ@time+PC�̒P�ʎ��Ԃ�duration�Ŋ��������̂���

            Vector3 localScale = transform.localScale;�@�@//localScale�Ƃ���Vector3�̐錾�ƌ��݂�transformlocalScale�̒l�̑���B
            localScale.x = scale;�@�@�@�@�@�@�@�@�@�@�@�@�@//localScale��x����������Œ�`����scale��������B
            transform.localScale = localScale;�@�@�@�@�@�@//���݂�transform��x�����ύX���localscale��������B

            if (time >= 0.5f)                     //����time��0.5�ȏ�̏ꍇ
            {
                spriteRenderer.sprite = endImage;�@�@//���̖ʂ������_�[
            }

            yield return new WaitForFixedUpdate();�@�@// ���Ԋu�҂��Ď���while�����Ɉڂ�܂��B
        }
        if (cardIndex == -1)�@�@//����cardIndex ��-1�Ɠ������ꍇ
        {
            model.ToggleFace(false);�@//���ʂ������_�[���܂�
        }
        else�@�@�@�@//����ȊO�̏ꍇ��
        {
            model.cardIndex = cardIndex;�@�@//  model�̃J�[�h�C���f�b�N�X�̒l��cardIndex �Ƃ��A
            model.ToggleFace(true);�@�@// �\�ʂ������_�[���܂�
        }
    }
}
