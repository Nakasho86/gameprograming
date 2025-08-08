using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    // �L���[�u�̈ʒu��m��ׂɕϐ���p�ӂ���
    public GameObject target_;

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ݒ肳��Ă��Ȃ��ꍇ�̕ی�
        if (!target_) { return; }


        // �X�t�B�A����L���[�u�܂ł̃x�N�g�����v�Z
        var dist = target_.transform.position - transform.position;

        // �x�N�g���̒������v�Z
        var length = Mathf.Sqrt((dist.x * dist.x) + (dist.y * dist.y) + (dist.z * dist.z));

        // �������[���Ȃ珈�����Ȃ�
        if (0 < length)
        {

            // �x�N�g���𐳋K�����ĒP�ʃx�N�g�������
            var vector = dist / length;
            // �P�ʃx�N�g���ɑ����i�x�N�g���̒�����1/20�j�𔽉f���Ĉړ��x�N�g�������
            vector *= (length / 20.0f);
            // �ړ��x�N�g���ňړ�����
            transform.position += vector;
        }
    }
}
