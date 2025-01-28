using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        if (volumeSlider == null)
        {
            Debug.LogError("VolumeSlider referansı atanmadı!");
            return;
        }

        // Varsayılan ses seviyesini yükle
        float defaultVolume = PlayerPrefs.GetFloat("Volume", 0.5f);
        AudioListener.volume = defaultVolume;
        volumeSlider.value = defaultVolume;

        // Slider değişikliklerini dinle
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume; // Ses seviyesini ayarla
        PlayerPrefs.SetFloat("Volume", volume); // Ayarı kaydet
    }
}
