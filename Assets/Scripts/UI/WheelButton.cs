using Leopotam.Ecs;
using UnityEngine;
using VegasSpinLuck;
using Voody.UniLeo;


public class WheelButton : MonoBehaviour
{
    public void OnWheelButtonClick()
    {
        WorldHandler.GetWorld().GetFilter(typeof(EcsFilter<GameControllerTag>)).GetEntity(0).Get<StartSpining>();
    }
}
