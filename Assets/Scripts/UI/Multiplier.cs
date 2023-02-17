using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VegasSpinLuck;
using Voody.UniLeo;

public class Multiplier : MonoBehaviour
{
    [SerializeField] private GameObject count;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject multiplier;

    private void LateUpdate()
    {
        var controllerEntity = WorldHandler.GetWorld().GetFilter(typeof(EcsFilter<GameControllerTag>)).GetEntity(0);
        if (controllerEntity.Has<MultiplierComponent>())
        {
            count.SetActive(true);
            multiplier.SetActive(true);

            text.text = $"{controllerEntity.Get<MultiplierComponent>().Multiplier}/10 Games";
        }
        else
        {
            count.SetActive(false);
            multiplier.SetActive(false);
        }
    }
}
