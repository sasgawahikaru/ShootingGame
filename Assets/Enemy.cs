using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int EnemyHp;
    void Start()
    {
        EnemyHp = 3;
    }
    public void Damage()
    {
        EnemyHp = EnemyHp - 1;
        Debug.Log(EnemyHp);
    }
    void Update()
    {
        if(EnemyHp<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
