using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForwardShot : MonoBehaviour
{
    //プレイヤー
    private GameObject player;
    //弾のゲームオブジェクト
    public GameObject bullet;
    //打ち出す間隔
    public float time = 1;
    //最初に打ち出すまでの時間
    public float delayTime = 1;
    //現在のタイマー時間
    float nowtime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //タイマー初期化
        nowtime = delayTime;
    }
    private void CreateShotObject(float axis)
    {
        //ベクトルを取得
        var direction = player.transform.position - transform.position;
        //yを初期化
        direction.y = 0;
        //向きを取得する
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        //弾を生成する
        GameObject bulletClone =
        Instantiate(bullet, transform.position, Quaternion.identity);
        //EnemyBulletのゲットコンポーネントを変数として保存
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        //弾を打ち出したオブジェクトの情報を渡す
        bulletObject.SetCharacterObject(gameObject);
        //弾を打ち出す角度を変更する
        bulletObject.SetForwardAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
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
            CreateShotObject(-transform.localEulerAngles.y);
            nowtime = time;
        }
    }
}
