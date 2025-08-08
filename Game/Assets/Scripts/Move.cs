using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //�ړ��ʃx�N�g��
    private Vector3 vector_ = new Vector3(0, 0, 0);
    //�ړ���
    private const float scalar_ = 0.2f;

    // Update is called once per frame
    void Update()
    {
        //�ړ��ʃx�N�g�������Z�b�g
        vector_.Set(0, 0, 0);

        //x�̈ړ�
        if (Input.GetKey(KeyCode.LeftArrow)) { vector_.x = -1.0f; }
        else if (Input.GetKey(KeyCode.RightArrow)) { vector_.x = 1.0f; }

        // Y �̈ړ�
        if (Input.GetKey(KeyCode.DownArrow)) { vector_.y = -1.0f; }
        else if (Input.GetKey(KeyCode.UpArrow)) { vector_.y = 1.0f; }

        // Z �̈ړ�
        if (Input.GetKey(KeyCode.W)) { vector_.z = 1.0f; }
        else if (Input.GetKey(KeyCode.S)) { vector_.z = -1.0f; }

        //�x�N�g���̒������v�Z
        float length = Mathf.Sqrt((vector_.x * vector_.x) + (vector_.y * vector_.y) + (vector_.z * vector_.z));

        //�x�N�g���̒������[���̏ꍇ�͌v�Z���Ȃ�
        if (0 < length)
        {
            //���K��(�P�ʃx�N�g����)����
            vector_ = vector_ / length;
            //���x��������
            vector_ *= scalar_;
            //���W�X�V
            transform.position += vector_;
        }
    }
}