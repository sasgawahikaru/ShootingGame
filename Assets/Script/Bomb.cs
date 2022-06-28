using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�L�[�{�[�h��B�L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.B))
        {
            //�^�O�������I�u�W�F�N�g��S�Ĕz�u����
            GameObject[] enemyBulletObjects =
            GameObject.FindGameObjectsWithTag("EnemyBullet");
            //��Ŋl���������ׂẴI�u�W�F�N�g�����ł�����
            for (int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i].gameObject);
            }
            //
            Instantiate(particle, Vector3.zero, Quaternion.identity);
        }
    }
}
