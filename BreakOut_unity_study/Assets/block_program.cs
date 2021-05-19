using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_program : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // block が ball に当たったら消える処理
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
