using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_program : MonoBehaviour
{
    // ball の速さ
    public float speed = 1.0f;

    // ball の物理エンジン
    private Rigidbody myRigid;

    // Start is called before the first frame update
    void Start()
    {
        // 始まったら斜め前にボールが出る
        // ball のコンポーネント（Rigidbody）を取得
        myRigid = this.GetComponent<Rigidbody>();
        // 右斜め前にボールを突き飛ばす（力を与える）
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
