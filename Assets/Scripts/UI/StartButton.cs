using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject wheel;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject diamondScore;
    [SerializeField] private GameObject staticParts;
    [SerializeField] private GameObject multiplier;

    [SerializeField] private GameObject thisButton;
    [SerializeField] private GameObject bonusButton;
    [SerializeField] private GameObject logo;


    public void OnStartButtonClick()
    {
        wheel.SetActive(true);
        button.SetActive(true);
        diamondScore.SetActive(true);
        staticParts.SetActive(true);
        multiplier.SetActive(true);

        thisButton.SetActive(false);
        bonusButton.SetActive(false);
        logo.SetActive(false);
    }
}
