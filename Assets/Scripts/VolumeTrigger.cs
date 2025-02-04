using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeTrigger : MonoBehaviour
{
    public Button VolumeTriggerButton;

    public Text volumeText;
    public bool On;
   // public Sprite OnSprite;
   // public Sprite OffSprite;
    public int currentVolume;

    public AudioSource source;

    void Start()
    {
        source.volume = 0.25f;
        currentVolume = 1;
        volumeText.text = currentVolume.ToString();
    }

    void Update()
    {
        if (On)
        { 
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
        else
        {
            source.Stop();
        }
    }

    public void IncreaseVolume()
    {
        if (source.volume < 1)
        {
            source.volume += 0.25f;
            currentVolume += 1;
            volumeText.text = currentVolume.ToString();
        }
    }

    public void DecreaseVolume()
    {
        if (source.volume > 0.25)
        {
            source.volume -= 0.25f;
            currentVolume -= 1;
            volumeText.text = currentVolume.ToString();
        }
    }


    public void ToggleTick()
    {
        /*
        if (!On)
        {
            VolumeTriggerButton.GetComponent<Image>().sprite = OnSprite;
        }
        else
        {
            VolumeTriggerButton.GetComponent<Image>().sprite = OffSprite;
        }
        */
        On=!On;
    }
}
