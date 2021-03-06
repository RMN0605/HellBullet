//ル
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_Cross : Shot_Common
{
//--------------------------------------------------------------------------------------
//変数系

    public float rotation = 0.4f; //弾の回転する量だよ

    public bool is_direction;   //弾の回転する方向を示すよ　true：右,false:左

//--------------------------------------------------------------------------------------
//左右の移動

    void Update()
    {
        #region is_directionに合わせて方向を変える処理
        {
            if (is_direction)
            {
                transform.Rotate(new Vector3(0, 0, rotation));
            }
            else if (!is_direction)
            {
                transform.Rotate(new Vector3(0, 0, -rotation));
            }
        }
        #endregion
        transform.Translate(0, bullet_Speed * 0.01f, 0);    //弾を発射するよ
    }

//--------------------------------------------------------------------------------------
}
