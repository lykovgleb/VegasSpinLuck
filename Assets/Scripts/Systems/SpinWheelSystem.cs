using Leopotam.Ecs;
using UnityEngine;

namespace VegasSpinLuck
{
    public class SpinWheelSystem : IEcsRunSystem, IEcsInitSystem
    {
        private readonly EcsFilter<WheelTag, TransformComponent, WheelConfigComponent> wheelFilter = null;
        private readonly EcsFilter<GameControllerTag> gameControllerFilter = null;

        private EcsEntity gameController;

        public void Init()
        {
            foreach(var i in gameControllerFilter)
            {
                ref var entity = ref gameControllerFilter.GetEntity(i);

                gameController = entity;
            }

            foreach(var i in wheelFilter)
            {
                ref var configComponent = ref wheelFilter.Get3(i);

                ref var timer = ref configComponent.timer;
                ref var minTime = ref configComponent.minTime;

                timer = minTime;
            }
        }

        public void Run()
        {
            if (gameController.Has<StartSpining>())
            {
                var randomOffset = Random.Range(0f, 3f);

                foreach(var i in wheelFilter)
                {
                    ref var transformComponent = ref wheelFilter.Get2(i);
                    ref var configComponent = ref wheelFilter.Get3(i);

                    ref var transform = ref transformComponent.transform;
                    ref var timer = ref configComponent.timer;
                    ref var minTime = ref configComponent.minTime;
                    ref var speed = ref configComponent.speed;

                    timer -= Time.deltaTime;
                    transform.Rotate(0, 0, speed * Time.deltaTime);

                    if (timer <= 0f)
                    {
                        gameController.Del<StartSpining>();
                        gameController.Get<WheelResults>();
                        timer = minTime + randomOffset;
                    }
                }
            }
        }
    }
}

