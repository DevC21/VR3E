using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public float animTime = 2f;         // Fade �ִϸ��̼� ��� �ð� (����:��).  

    private Image fadeImage;            // UGUI�� Image������Ʈ ���� ����.  

    private float start = 0f;           // Mathf.Lerp �޼ҵ��� ù��° ��.  
    private float end = 1f;             // Mathf.Lerp �޼ҵ��� �ι�° ��.  
    private float time = 0f;            // Mathf.Lerp �޼ҵ��� �ð� ��.  

    void Awake()
    {
        // Image ������Ʈ�� �˻��ؼ� ���� ���� �� ����.  
        fadeImage = GetComponent<Image>();
    }

    void Update()
    {
        // Fade �ִϸ��̼� ���.  
        PlayFadeIn();
    }

    // Fade �ִϸ��̼� �Լ�.  
    void PlayFadeIn()
    {
        // ��� �ð� ���.  
        // 2��(animTime)���� ����� �� �ֵ��� animTime���� ������.  
        time += Time.deltaTime / animTime;

        // Image ������Ʈ�� ���� �� �о����.  
        Color color = fadeImage.color;
        // ���� �� ���.  
        color.a = Mathf.Lerp(start, end, time);
        // ����� ���� �� �ٽ� ����.  
        fadeImage.color = color;
    }
}
