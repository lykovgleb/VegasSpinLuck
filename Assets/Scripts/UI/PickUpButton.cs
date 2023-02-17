using Leopotam.Ecs;
using UnityEngine;
using VegasSpinLuck;
using Voody.UniLeo;

public class PickUpButton : MonoBehaviour
{
    [SerializeField] private GameObject dailyBonusLogo;
    [SerializeField] private GameObject dailyBonus;
    [SerializeField] private GameObject pickUpButton;

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject bonusButton;
    [SerializeField] private GameObject logo;

    public void OnPickUpClick()
    {
        dailyBonusLogo.SetActive(false);
        dailyBonus.SetActive(false);
        pickUpButton.SetActive(false);

        startButton.SetActive(true);
        bonusButton.SetActive(true);
        logo.SetActive(true);

        WorldHandler.GetWorld().GetFilter(typeof(EcsFilter<GameControllerTag>)).GetEntity(0).Get<MultiplierComponent>().Multiplier = 10;
    }
}
