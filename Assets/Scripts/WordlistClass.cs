using System;

public class WordlistClass
{
    String PoF; //�i��
    String Rank; //�p�X�P�ɂ����郉���N�iA,B,C�j
    String English; //�p��
    String Japanese; //���{���
    String Number; //�p�X�P�ɂ����鏇��
    Double Random; //����

    WordlistClass(String PoF, String Rank, String English, String Japanese, String Number, Double Random)
    {
        this.PoF = PoF;
        this.Rank = Rank;
        this.English = English;
        this.Japanese = Japanese;
        this.Number = Number;
        this.Random = Random;
    }

}
