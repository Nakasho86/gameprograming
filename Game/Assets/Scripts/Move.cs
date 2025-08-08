using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //移動量ベクトル
    private Vector3 vector_ = new Vector3(0, 0, 0);
    //移動量
    private const float scalar_ = 0.2f;

    // Update is called once per frame
    void Update()
    {
        //移動量ベクトルをリセット
        vector_.Set(0, 0, 0);

        //xの移動
        if (Input.GetKey(KeyCode.LeftArrow)) { vector_.x = -1.0f; }
        else if (Input.GetKey(KeyCode.RightArrow)) { vector_.x = 1.0f; }

        // Y の移動
        if (Input.GetKey(KeyCode.DownArrow)) { vector_.y = -1.0f; }
        else if (Input.GetKey(KeyCode.UpArrow)) { vector_.y = 1.0f; }

        // Z の移動
        if (Input.GetKey(KeyCode.W)) { vector_.z = 1.0f; }
        else if (Input.GetKey(KeyCode.S)) { vector_.z = -1.0f; }

        //ベクトルの長さを計算
        float length = Mathf.Sqrt((vector_.x * vector_.x) + (vector_.y * vector_.y) + (vector_.z * vector_.z));

        //ベクトルの長さがゼロの場合は計算しない
        if (0 < length)
        {
            //正規化(単位ベクトル化)する
            vector_ = vector_ / length;
            //速度をかける
            vector_ *= scalar_;
            //座標更新
            transform.position += vector_;
        }
    }
}