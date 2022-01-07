using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{

    //�@���g�Ƃ̋������v�Z����^�[�Q�b�g�I�u�W�F�N�g
    [SerializeField]
    private Transform targetObj;
    //�@������\������e�L�X�gUI
    [SerializeField]
    private Text distanceUI;
    //�@�R���C�_���l�������I�t�Z�b�g�l
    private float colliderOffset;

    private void Start()
    {
        colliderOffset = GetComponent<CharacterController>().radius + targetObj.GetComponent<CharacterController>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        //�@�������v�Z
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