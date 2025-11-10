using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundChanger : MonoBehaviour
{
    public SpriteRenderer targetRenderer; // Arkaplanın SpriteRenderer'ı
    public Sprite[] backgrounds; // 4 farklı sprite'ı buraya ekle
    public float changeInterval = 30f; // Her 30 saniyede değişsin

    private int currentIndex = 0;

    void Start()
    {
        if (backgrounds.Length == 0 || targetRenderer == null)
        {
            Debug.LogWarning("BackgroundChanger: Ayarlar eksik");
            return;
        }

        // Başlangıçta ilk sprite'ı ayarla
        targetRenderer.sprite = backgrounds[currentIndex];
        // Belirli aralıklarla değiştirmeye başla
        InvokeRepeating(nameof(ChangeBackground), changeInterval, changeInterval);
    }

    void ChangeBackground()
    {
        currentIndex++;
        if (currentIndex >= backgrounds.Length)
            currentIndex = 0;

        targetRenderer.sprite = backgrounds[currentIndex];
    }
}
