using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MyFirstUnityPackage
{
    public class GraphicFadeOut : MonoBehaviour
    {
        [SerializeField] private Graphic graphic = default;
        [SerializeField] private float  duration = 1f;
        [SerializeField] private float delay = 0f;
        
        public IEnumerator FadeOut()
        {
            yield return new WaitForSeconds(delay);
            var elapsedTime = 0f;
            while (elapsedTime < duration)
            {
                graphic.color = Color.Lerp(Color.white, Color.clear, elapsedTime / duration);
                yield return null;
                elapsedTime += Time.deltaTime;
            }
            
            graphic.color = Color.clear;
        }
    }
}