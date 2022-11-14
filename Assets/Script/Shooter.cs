using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    float move = 0.05f;//0.05の値で移動。moveはfloat型
    void Update()
    {
        Vector3 pos = transform.position; //posをVector3で宣言
        pos.x += move;//posにmoveを足す
        if (pos.x < -2.5f)
        {
            move = 0.05f;
            Debug.Log("ShooterをX軸で正の方向にで移動中");
        }
        if (pos.x > 2.5f)
        {
            move = -0.05f;
            Debug.Log("ShooterをX軸で負の方向にで移動中");
        }
        transform.position = pos;//posの値を変形設定の位置情報に入力

    }
}
