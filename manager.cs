using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text ClicksTotalText;
    public ParticleSystem cookieParticle;

    float TotalClicks;

    bool hasUpgrade;
    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUpgrade;

    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("Score: 0");
    }

    public void AutoClickUpgrade()
    {
        if(!hasUpgrade && TotalClicks >= minimumClicksToUnlockUpgrade)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade;
            hasUpgrade = true;
        }
    }

    public void OnMouseDown()
    {
            TotalClicks++;
            cookieParticle.Play();
    }

    private void Update()
    {
        if(hasUpgrade)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime;

            ClicksTotalText.text = TotalClicks.ToString("Score: 0");
        }
    }
}
