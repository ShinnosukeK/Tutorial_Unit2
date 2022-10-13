using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;//�Q�[����ʏ�[
    private float lowerBound = -10.0f;//�Q�[����ʉ��[
    public UIManager UIManager;

    private void Start()
    {
        UIManager = GameObject.Find("UIManager").
            GetComponent<UIManager>();
    }
    void Update()
    {
        //�H�ו���z���W�����l�𒴂�����
        if (transform.position.z > topBound)
        {
            //�H�ו������� �����FgameObject�Ƃ���
            //����������n�܂�gameObject�͕ϐ��ŁA
            //�������g�̎����w��
            Destroy(gameObject);
        }
        //������z���W�����l�����������
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            UIManager.ShowGameOver();
        }

    }
}
