using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    // キューブの位置を知る為に変数を用意する
    public GameObject target_;

    // Update is called once per frame
    void Update()
    {
        // キューブが設定されていない場合の保険
        if (!target_) { return; }


        // スフィアからキューブまでのベクトルを計算
        var dist = target_.transform.position - transform.position;

        // ベクトルの長さを計算
        var length = Mathf.Sqrt((dist.x * dist.x) + (dist.y * dist.y) + (dist.z * dist.z));

        // 長さがゼロなら処理しない
        if (0 < length)
        {

            // ベクトルを正規化して単位ベクトルを作る
            var vector = dist / length;
            // 単位ベクトルに速さ（ベクトルの長さの1/20）を反映して移動ベクトルを作る
            vector *= (length / 20.0f);
            // 移動ベクトルで移動する
            transform.position += vector;
        }
    }
}
