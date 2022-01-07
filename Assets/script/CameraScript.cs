using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //追いかけるターゲット
    public GameObject player;

    //自分とターゲットの座標の差分
    private Vector3 offset;

    void Start()
    {
        //自分とターゲットの座標の差分をメモする
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        //ターゲットの座標に、差分を追加した座標にカメラを移動させる
        transform.position = player.transform.position + offset;
    }
}
