using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text gameOverText;//�Q�[���I�[�o�[�p�e�L�X�g
    public Text scoreText;//�X�R�A�p�e�L�X�g
    private int _score = 0;//�X�R�A

    private void Start()
    {
        //�Q�[���J�n���̃X�R�A�X�V
        scoreText.text = "Score:" + _score;
        gameOverText.text = "";
    }

    public void ChangeScore(int score)//�ǉ��X�R�A���󂯎��
    {
        _score = _score + score;//�󂯎�����X�R�A�����̃X�R�A�ɑ���
        scoreText.text = "Score:" + _score.ToString();
        //score.ToString()�ŁA�ʓ|����score�Ƃ���int�^��
        //�킴�킴String�^�Ƃ���������̌^�ɒ����Ă���
        //�����Score:�Ƃ���������ƌ������Ă���
    }
    public void ShowGameOver()
    {
        //GameOver��UI��\��������
        gameOverText.text = "GameOver";
    }
}
