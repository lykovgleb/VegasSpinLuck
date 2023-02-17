using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

namespace VegasSpinLuck
{
    public class StartUpEcs : MonoBehaviour
    {
        private EcsWorld ecsWorld;
        private EcsSystems ecsSystems;

        private void Start()
        {
            ecsWorld = new EcsWorld();
            ecsSystems = new EcsSystems(ecsWorld);

            ecsSystems.ConvertScene();


            AddSystems();
            AddOneFrames();

            ecsSystems.Init();
        }

        private void AddSystems()
        {
            ecsSystems.
                Add(new InitSystem()).
                Add(new SpinWheelSystem()).
                Add(new ResultSystem());
        }

        private void AddOneFrames()
        {
            ecsSystems.
                OneFrame<WheelResults>();
        }

        private void Update()
        {
            ecsSystems.Run();
        }

        private void OnDestroy()
        {
            ecsSystems.Destroy();
            ecsSystems = null;
            ecsWorld.Destroy();
            ecsWorld = null;
        }
    }
}

