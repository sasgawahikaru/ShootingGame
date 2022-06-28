using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    //敵の数を数える用の変数
    private GameObject[] enemy;
    //パネルを登録する
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //一匹もEnemyが居なくなったら
        if (enemy.Length == 0)
        {
            //パネルを表示
            panel.SetActive(true);
        }
    }
}
