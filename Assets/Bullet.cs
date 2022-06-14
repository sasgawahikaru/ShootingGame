using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //もし相手のタグがEnemyなら
        if(other.gameObject.tag=="Enemy")
        {
            //ダメージ関数を実行させる
            other.GetComponent<Enemy>().Damage();
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos= transform.position;

        pos.z += 0.05f;

        //弾の移動
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        if (pos.z >= 20)
        {
        Destroy(this.gameObject);
        }
    }
}
