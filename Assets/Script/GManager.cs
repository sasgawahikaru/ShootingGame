using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    //�G�̐��𐔂���p�̕ϐ�
    private GameObject[] enemy;
    //�p�l����o�^����
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //��C��Enemy�����Ȃ��Ȃ�����
        if (enemy.Length == 0)
        {
            //�p�l����\��
            panel.SetActive(true);
        }
    }
}
