using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //�ǂ�������^�[�Q�b�g
    public GameObject player;

    //�����ƃ^�[�Q�b�g�̍��W�̍���
    private Vector3 offset;

    void Start()
    {
        //�����ƃ^�[�Q�b�g�̍��W�̍�������������
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        //�^�[�Q�b�g�̍��W�ɁA������ǉ��������W�ɃJ�������ړ�������
        transform.position = player.transform.position + offset;
    }
}
