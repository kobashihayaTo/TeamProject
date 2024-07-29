using UnityEngine;
using UnityEngine.UI;

public class FlushController : MonoBehaviour
{
    Image img;
    [SerializeField]
    Light playerlight;

    void Start()
    {
        img = GetComponent<Image>();
        img.color = Color.clear;
    }

    void Update()
    {
        if (playerlight.intensity <= 0.2) 
        {
            this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
            
        }
        else
        {
            this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
        }
    }
}