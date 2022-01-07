using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{

    //　自身との距離を計算するターゲットオブジェクト
    [SerializeField]
    private Transform targetObj;
    //　距離を表示するテキストUI
    [SerializeField]
    private Text distanceUI;
    //　コライダを考慮したオフセット値
    private float colliderOffset;

    private void Start()
    {
        colliderOffset = GetComponent<CharacterController>().radius + targetObj.GetComponent<CharacterController>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        //　距離を計算
        var distance = Vector3.Distance(transform.position, targetObj.position) - colliderOffset;

        if (distanceUI != null)
        {
            distanceUI.text = distance.ToString("0.00m");
        }
        else
        {
            Debug.Log(distance.ToString("0.00m"));
        }
    }
}