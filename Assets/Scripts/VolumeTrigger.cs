using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeTrigger : MonoBehaviour
{
    public Button muteButton;
    public Image muteButtonImage; // Assign this manually in the Inspector
    public Sprite muteSprite;
    public Sprite unmuteSprite;
    public Slider volumeSlider;
    public TextMeshProUGUI volumeText;
    public AudioSource source;
    private bool isMuted = false;

    void Start()
    {
        source.volume = 0.25f; // Set initial volume to max
        source.Play();
        volumeSlider.value = source.volume;
        volumeSlider.maxValue = 1.0f; // Ensure max volume is 1
        UpdateVolumeText();
        UpdateMuteButtonSprite();
    }

    public void SetVolume()
    {
        source.volume = volumeSlider.value;
        isMuted = source.volume == 0;
        source.mute = isMuted;
        UpdateVolumeText();
        UpdateMuteButtonSprite();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        source.mute = isMuted;
        volumeSlider.value = isMuted ? 0 : source.volume;
        UpdateMuteButtonSprite();
    }

    private void UpdateVolumeText()
    {
        volumeText.text = Mathf.RoundToInt(source.volume * 100).ToString();
    }

    private void UpdateMuteButtonSprite()
    {
        if (muteButtonImage != null)
        {
            muteButtonImage.sprite = isMuted ? muteSprite : unmuteSprite;
        }
    }
}
