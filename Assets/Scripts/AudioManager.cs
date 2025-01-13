using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager audioManager;
    private AudioSource audioSound;

    void Awake()
    {
        // ���� �̹� �ν��Ͻ��� �����Ѵٸ�
        if (audioManager != null)
        {
            // ���ο� �ν��Ͻ��� �����Ͽ� �ߺ��� ����
            Destroy(gameObject);
            return;
        }

        // �ν��Ͻ��� ���ٸ�, �ش� ������Ʈ�� �ν��Ͻ��� ����
        audioManager = this;

        // ����� �ҽ� ������Ʈ�� ��������
        audioSound = GetComponent<AudioSource>();

        // �� ��ȯ �Ŀ��� �ش� ������Ʈ�� �ı����� �ʵ��� ����
        DontDestroyOnLoad(gameObject);
    }

    // �ٸ� ��ũ��Ʈ���� ȣ���� �� �ִ�, �Ҹ��� ����ϴ� �޼���
    public void PlaySound(AudioClip clip)
    {
        audioSound.clip = clip;
        audioSound.Play();
    }

    // AudioManager�� �ν��Ͻ��� ��ȯ�ϴ� ������Ƽ
    public static AudioManager Instance
    {
        get
        {
            return audioManager;
        }
    }


}
