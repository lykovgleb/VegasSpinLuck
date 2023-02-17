using Leopotam.Ecs;
using UnityEngine;

namespace VegasSpinLuck
{
    public class ResultSystem : IEcsRunSystem, IEcsInitSystem
    {
        private readonly EcsFilter<GameControllerTag> gameControllerFilter = null;
        private readonly EcsFilter<WheelTag, TransformComponent> wheelFilter = null;

        private EcsEntity gameController;
        private int multiplier;

        public void Init()
        {
            foreach (var i in gameControllerFilter)
            {
                ref var entity = ref gameControllerFilter.GetEntity(i);

                gameController = entity;
            }
        }

        public void Run()
        {
            if (gameController.Has<WheelResults>())
            {
                foreach (var i in wheelFilter)
                {
                    ref var transformComponent = ref wheelFilter.Get2(i);

                    ref var transform = ref transformComponent.transform;

                    if (gameController.Has<MultiplierComponent>())
                    {
                        multiplier = 7;
                        gameController.Get<MultiplierComponent>().Multiplier--;
                        if (gameController.Get<MultiplierComponent>().Multiplier == 0)
                            gameController.Del<MultiplierComponent>();
                    }
                    else
                    {
                        multiplier = 1;
                    }

                    var result = Vector3.Angle(Vector3.up, transform.up);
                    if (transform.up.x < 0)
                    {
                        result = 360 - result;
                    }



                    switch (result)
                    {
                        case <= 45:
                            gameController.Get<DiamondsScore>().yellow += 4 * multiplier;
                            break;
                        case <= 90:
                            gameController.Get<DiamondsScore>().purple += 22 * multiplier;
                            break;
                        case <= 135:
                            gameController.Get<DiamondsScore>().red += 12 * multiplier;
                            break;
                        case <= 180:
                            gameController.Get<DiamondsScore>().orange += 6 * multiplier;
                            break;
                        case <= 225:
                            break;
                        case <= 270:
                            gameController.Get<DiamondsScore>().green += 9 * multiplier;
                            break;
                        case <= 315:
                            break;
                        case <= 360:
                            gameController.Get<DiamondsScore>().blue += 8 * multiplier;
                            break;
                        default:
                            Debug.Log($"{result}");
                            break;
                    }

                }
            }
        }
    }
}

