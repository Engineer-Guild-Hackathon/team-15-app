using System;

public class WordlistClass
{
    public String PoF; //�i��
    public String Rank; //�p�X�P�ɂ����郉���N�iA,B,C�j
    public String English; //�p��
    public String Japanese; //���{���
    public String Number; //�p�X�P�ɂ����鏇��

    public WordlistClass(String PoF, String Rank, String English, String Japanese, String Number)
    {
        this.PoF = PoF;
        this.Rank = Rank;
        this.English = English;
        this.Japanese = Japanese;
        this.Number = Number;
    }

}
