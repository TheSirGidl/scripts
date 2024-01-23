using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public PlayerUI player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    void Update()
    {
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.healthSlider;
        coinsCounterText.text = player.coinsCounterText.loString();
    }
}
