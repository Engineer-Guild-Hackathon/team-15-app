using System;

public class WordlistClass
{
    public String PoF; //品詞
    public String Rank; //パス単におけるランク（A,B,C）
    public String English; //英訳
    public String Japanese; //日本語訳
    public String Number; //パス単における順番

    public WordlistClass(String PoF, String Rank, String English, String Japanese, String Number)
    {
        this.PoF = PoF;
        this.Rank = Rank;
        this.English = English;
        this.Japanese = Japanese;
        this.Number = Number;
    }

}
