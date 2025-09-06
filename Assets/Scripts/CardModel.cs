using UnityEngine;

public class CardModel : MonoBehaviour
{
    public Sprite[] faces;  // 外部から参照できる（インスペクターからいじれる）facesという表面のリストの宣言。
    public Sprite cardBack; // 外部から参照できる（インスペクターからいじれる）cardBackという裏面の宣言。

    public int cardIndex;
    SpriteRenderer spriteRenderer;

    public void ToggleFace(bool showFace)　//外部アクセス可能なToggleFaceというメソッドの定義　引数に真偽値としてshowFaceを取る。
    {

        if (showFace)　// もし showface がtrueであれば、
        {
            spriteRenderer.sprite = faces[cardIndex];  //②で取得したspriteにfaces[与えられたインデックス値]をレンダーさせる。
        }
        else
        {
            spriteRenderer.sprite = cardBack;　　//②で取得したspriteにcardbackをレンダーさせる。
        }
    }
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //このスクリプトがアタッチされているオブジェクトのインスペクター上のspriteRendererを取得します。①とセット。②
    }
}
