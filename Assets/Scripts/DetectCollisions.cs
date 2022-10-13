using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public UIManager UIManager;

    private void Start()
    {
        UIManager = GameObject.Find("UIManager").
            GetComponent<UIManager>();
    }

    //���蔲�����N�����u�Ԃɂ̂݌Ă΂��
    private void OnTriggerEnter(Collider other)
    {//�����Fother = �i�X�N���v�g���t���Ă��镨�̂ɂƂ��Ắj���蔲��������

        //�Ԃ��������������
        Destroy(other.gameObject);
        //���̃X�N���v�g��t���Ă��鎩�����g������
        Destroy(gameObject);

        //�o�i�i�ɂƂ��āA�G�ƂԂ��邱�Ƃ��ł�����
        if (other.gameObject.CompareTag("enemy"))
        {
            //UI�}�l�[�W�����Ăяo���āA�X�R�A���Z
            UIManager.ChangeScore(100);
        }

        if (other.gameObject.CompareTag("enemy2"))
        {
            //UI�}�l�[�W�����Ăяo���āA�X�R�A���Z
            UIManager.ChangeScore(1000);
        }

        if (other.gameObject.CompareTag("enemy3"))
        {
            //UI�}�l�[�W�����Ăяo���āA�X�R�A���Z
            UIManager.ChangeScore(2000);
        }
    }
}
