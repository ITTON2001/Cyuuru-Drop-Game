using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public Text scoretext;//パブリック設定でText型の変数scoretextを作成
    int score = 0;//int型で作成した変数scoreに入れる
    void OnTriggerEnter2D(Collider2D other){//Collider2D型の引数otherを受け取る「OnTriggerEnter2D」という名前のメソッドを作成
    Cyuuru.Type typeA = GetComponent<Cyuuru>().type;//Cyuuru型のコンポーネントを取得し、そのパブリック変数typeの内容を,Cyuuru.Type型の変数typeAに入れる。
    Cyuuru.Type typeB = other.GetComponent<Cyuuru>().type;//引数otherからCyuuru型のコンポーネントを取得し、そのパブリック変数typeの内容を,Cyuuru.Type型の変数typeAに入れる

    if (typeA == typeB){//もしも「変数typeAと変数typeBが等しい]が真なら以下を実行
        score++;//変数scoreを1増やす
        scoretext.text = score.ToString();//変数scoreを文字列に変換した結果を、変数scoretextのテキストに入れる
        Destroy(other.gameObject);//引数otherのゲームオブジェクトを削除
        Debug.Log("BOXにちゅーるが入りました");
    }
    }
}

