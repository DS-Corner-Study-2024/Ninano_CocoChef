using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager audioManager;
    private AudioSource audioSound;

    void Awake()
    {
        // 만약 이미 인스턴스가 존재한다면
        if (audioManager != null)
        {
            // 새로운 인스턴스를 삭제하여 중복을 방지
            Destroy(gameObject);
            return;
        }

        // 인스턴스가 없다면, 해당 오브젝트를 인스턴스로 설정
        audioManager = this;

        // 오디오 소스 컴포넌트를 가져오기
        audioSound = GetComponent<AudioSource>();

        // 씬 전환 후에도 해당 오브젝트가 파괴되지 않도록 설정
        DontDestroyOnLoad(gameObject);
    }

    // 다른 스크립트에서 호출할 수 있는, 소리를 재생하는 메서드
    public void PlaySound(AudioClip clip)
    {
        audioSound.clip = clip;
        audioSound.Play();
    }

    // AudioManager의 인스턴스를 반환하는 프로퍼티
    public static AudioManager Instance
    {
        get
        {
            return audioManager;
        }
    }


}
