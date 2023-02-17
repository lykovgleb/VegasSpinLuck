using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VegasSpinLuck;
using Voody.UniLeo;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI yellow;
    [SerializeField] private TextMeshProUGUI sky;
    [SerializeField] private TextMeshProUGUI purple;
    [SerializeField] private TextMeshProUGUI green;
    [SerializeField] private TextMeshProUGUI blue;
    [SerializeField] private TextMeshProUGUI orange;
    [SerializeField] private TextMeshProUGUI red;

    private void LateUpdate()
    {
        var scoreComponent = WorldHandler.GetWorld().GetFilter(typeof(EcsFilter<DiamondsScore>)).GetEntity(0).Get<DiamondsScore>();

        yellow.text = scoreComponent.yellow.ToString();
        sky.text = scoreComponent.sky.ToString();
        purple.text = scoreComponent.purple.ToString();
        green.text = scoreComponent.green.ToString();
        blue.text = scoreComponent.blue.ToString();
        orange.text = scoreComponent.orange.ToString();
        red.text = scoreComponent.red.ToString();

    }
}
