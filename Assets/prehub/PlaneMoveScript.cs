using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMoveScript : MonoBehaviour
{
    float speed = -3;

    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    void Update()
    {
        this.gameObject.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
    }
}