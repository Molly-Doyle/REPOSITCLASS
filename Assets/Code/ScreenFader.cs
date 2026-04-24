using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class ScreenFader : MonoBehaviour
{
    public static ScreenFader Instance;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] float fadeDuration = 0.5f;

    private void Awake()
    {
        if(Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    
    async Task Fade(float targetTransparency)
        {
            flat start = canvasGroup.alpha, t=0;
            while(t < fadeDuration)
            {
                t += Time.deltaTime;
                canvasGroup.alpha = Mathf.Lerp(start, targetTransparency, t / fadeDuration);
                await Task.Yield();
            }
            
            canvasGroup.alpha = targetTransparency;
        }
    public async Task FadeOut()
    {
        await Fade(1); //fades to black
    }

        public async Task FadeIn()
    {
        await Fade(0); //fades to gamescreen
    }
}
