using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_program : MonoBehaviour
{
    // プレイヤーの移動速度
    // private にすると player の中でしか使えない
    // public にすると他のスクリプトからも使えるようになる
    public float speed = 1.0f;

    // Start is called before the first frame update
    // 起動直後に実行されるスクリプト（1番最初に1回だけ実行される命令）
    void Start()
    {

    }

    // Update is called once per frame
    // 毎フレーム実行されるスクリプト（永久に実行され続ける命令）
    void Update()
    {
        // 左矢印キーの操作
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 左壁まで player が来たら動かなくなる処理
            // Time.deltaTime はどのパソコンでも同じ速さで動くように制御する処理
            if (this.transform.position.x > -4)
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        // 右矢印キーの操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 右壁まで player が来たら動かなくなる処理
            if (this.transform.position.x < 4)
            {
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
