using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyBonusButton : MonoBehaviour
{
    [SerializeField] private GameObject dailyBonusLogo;
    [SerializeField] private GameObject dailyBonus;
    [SerializeField] private GameObject pickUpButton;

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject bonusButton;
    [SerializeField] private GameObject logo;


    public void OnDailyBonusButtonClick()
    {
        startButton.SetActive(false);
        bonusButton.SetActive(false);
        logo.SetActive(false);

        dailyBonusLogo.SetActive(true);
        dailyBonus.SetActive(true);
        pickUpButton.SetActive(true);
    }
}
