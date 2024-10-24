using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class Score_Script : MonoBehaviour
{
    // �N���X�̗B��̃C���X�^���X��ێ�����ÓI�ϐ�
    public static Score_Script instance;

    // �X�R�A��\�����邽�߂�Text�R���|�[�l���g
    public GameObject scoreText;
    private int totalScore = 0;

    // Awake���\�b�h�ŃC���X�^���X�̏��������s��
    void Awake()
    {
        // �C���X�^���X�����݂��Ȃ��ꍇ�͂��̃C���X�^���X��ݒ�
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // �V�[�����܂����ł��C���X�^���X��ێ�
        }
        else
        {
            Destroy(gameObject); // ���ɃC���X�^���X�����݂���ꍇ�͐V�����C���X�^���X��j��
        }
    }

    // �X�R�A���X�V���AText�R���|�[�l���g�ɔ��f���郁�\�b�h
    public void ScoreManager(int score)
    {
        totalScore += score;
        UpdateScoreText();
    }

    // �X�R�A��Text�R���|�[�l���g�ɕ\�����郁�\�b�h
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + totalScore.ToString();
    }

    //�g�[�^���̃X�R�A
    public int GetCurrentScore()
    {
        return totalScore;
    }
}