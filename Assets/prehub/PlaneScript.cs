using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
//ここまではおまじないみたいなものだと思ってくれればOK。
{
    public GameObject Plane;
    //ここでpublicと宣言することで後でInspectorビューから操作できる
    float timer = 0;
    float spowntime = 2; //2秒ごとに生成させる
    int i = 0;

    void Update()
    {
        
        timer += Time.deltaTime; //timerの値を1秒に1のペースで増やす
        if (timer > spowntime)
        {
            PlaneGenerate(); //PlaneGenerate関数を呼び出す。
            timer = 0; //timerを0に戻す。
            i += 3;
        }
    }

    void PlaneGenerate()
    {
        Instantiate(Plane, new Vector3(1, -3, 0+i), Quaternion.identity);
        /*Planeを(1,0,0)の場所に生成する。
        Quaternion.identityは回転させないことを示す言葉*/
    }
}