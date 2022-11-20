using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public bool clockwise = true;//bool型で作成した変数clockwiseにtrueを入れる
    void Update()
    {
        if (clockwise){
            transform.Rotate(
                new Vector3(0,0,-1)//Vector3型のインスタンスを新規作成し、それを指定して-1の方向に回転（時計回り）
            );
        }else{
            transform.Rotate(
                new Vector3(0,0,1)//Vector3型のインスタンスを新規作成し、それを指定して1の方向に回転（反時計回り）
            );
        }
    }
}
