using System;

public class WordlistClass
{
    String PoF; //品詞
    String Rank; //パス単におけるランク（A,B,C）
    String English; //英訳
    String Japanese; //日本語訳
    String Number; //パス単における順番
    Double Random; //乱数

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
