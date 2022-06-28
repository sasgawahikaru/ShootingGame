using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFixedShot : MonoBehaviour
{
    //プレイヤー
    private GameObject player;
    //弾のゲームオブジェクト
    public GameObject bullet;
    //1回で打ち出す弾の数を決める
    public int bulletWayNum = 3;
    //打ち出す弾の間隔を調整する
    public float bulletWaySpace = 30;
    //
    public int bulletWayAxis = 0;
    //打ち出す間隔
    public float time = 1;
    //最初に打ち出すまでの時間
    public float delayTime = 1;
    //現在のタイマー時間
    float nowtime = 0;
    // Start is called before the first frame update

    private void CreateShotObject(float axis)
    {
        //弾を生成する
        GameObject bulletClone =
        Instantiate(bullet, transform.position, Quaternion.identity);
        //EnemyBulletのゲットコンポーネントを変数として保存
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        //弾を打ち出したオブジェクトの情報を渡す
        bulletObject.SetCharacterObject(gameObject);
        //弾を打ち出す角度を変更する
        bulletObject.SetForwardAxis(Quaternion.AngleAxis(axis, Vector3.up));
    }
    void Start()
    {
        nowtime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        nowtime -= Time.deltaTime;

        if (nowtime <= 0)
        {
            float bulletWaySpaceSplit = 0;

            for (int i = 0; i < bulletWayNum; i++)
            {
                //弾を生成
                CreateShotObject(
                bulletWaySpace - bulletWaySpaceSplit + bulletWayAxis - transform.localEulerAngles.y);
                //角度を調整
                bulletWaySpaceSplit += (bulletWaySpace / (bulletWayNum - 1)) * 2;
            }
            nowtime = time;
        }
    }
}
