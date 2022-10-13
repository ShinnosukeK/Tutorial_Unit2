using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;//���E�L�[�̒l
    public float speed = 10.0f;//����
    public float xRange = 10.0f;//�����W�͈̔�
    public GameObject projectilePrefab;//�H�ו��̃v���n�u
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //transform.position = ���W�i�R�����x�N�g���j
        //new ���
        //Vector3(*,*,*)���R�����x�N�g��
        //�P�Ȃ鐔�����}�W�b�N�i���o�[
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }

        //�X�y�[�X�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�H�ו��𐶐�
            Instantiate(projectilePrefab,
                transform.position,
                projectilePrefab.transform.rotation);
        }
    }
}
