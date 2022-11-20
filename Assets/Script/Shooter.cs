using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    float move = 0.008f;//0.05の値で移動。moveはfloat型
    public GameObject[] prefabs = new GameObject[3];//GameObject[]型を新規作成、パブリック設定でGameObject[]型で作成した変数prefabsに入れる
    int Cyuuru = 0;//int型の変数Cyuuruに整数0を入れる
    void Update()
    {
        Vector3 pos = transform.position; //posをVector3で宣言
        pos.x += move;//posにmoveを足す
        if (pos.x < -2.5f)
        {
            move = 0.008f;
            Debug.Log("ShooterをX軸で正の方向にで移動中");
        }
        if (pos.x > 2.5f)
        {
            move = -0.008f;
            Debug.Log("ShooterをX軸で負の方向にで移動中");
        }
        transform.position = pos;//posの値を変形設定の位置情報に入力

        //ちゅーるを落すプログラム
        if (Input.GetMouseButtonUp(0)){//もし整数ゼロを指定してマウスのボタンアップを取得した結果が真なら以下を実行
            Instantiate(prefabs[Cyuuru],pos,Quaternion.identity);//変数prefabsの要素0,変数pos,無回転を指定し、インスタンスを作成（Instantiate(プレハブ,位置情報,回転情報)）
                     　//プレハブ,  位置,回転情報
            Debug.Log("ちゅーるを落します");
            Cyuuru++;//変数Cyuuruを1追加
            if (Cyuuru == 1)
            {
                Debug.Log("まぐろ味を落しました");
            }
            else if(Cyuuru == 2)
            {
                Debug.Log("チキン味を落しました");
            }
            else if(Cyuuru == 3)
            {
                Debug.Log("カツオ味を落しました");
            }
            else{
                Debug.Log("エラーが発生しています");
            }
            Cyuuru %= 3;//変数Cyuuruを整数3で割り、その余りを入れる
        }

    }
}
