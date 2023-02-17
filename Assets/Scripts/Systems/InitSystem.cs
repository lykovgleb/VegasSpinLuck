using Leopotam.Ecs;

namespace VegasSpinLuck
{
    public class InitSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;

        private EcsEntity gameControllerEntity;

        public void Init()
        {
            gameControllerEntity = _world.NewEntity();
            gameControllerEntity.Get<GameControllerTag>();
            gameControllerEntity.Get<DiamondsScore>();

        }
    }
}

