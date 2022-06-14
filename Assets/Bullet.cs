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
        //��������̃^�O��Enemy�Ȃ�
        if(other.gameObject.tag=="Enemy")
        {
            //�_���[�W�֐������s������
            other.GetComponent<Enemy>().Damage();
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos= transform.position;

        pos.z += 0.05f;

        //�e�̈ړ�
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        if (pos.z >= 20)
        {
        Destroy(this.gameObject);
        }
    }
}
