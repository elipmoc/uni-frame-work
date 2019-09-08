using BigBang.Scene;
using UniFrameWork.BigBang.Core;
using UniFrameWork.GameSystem.Core.Scene;
using UnityEngine;
using SceneChanger = Domain.SceneChanger;

namespace God
{
    public class God : MonoBehaviour
    {
        SceneManager sceneManager;

        void Start()
        {
            var firstSceneCreatorCreator = new SampleSceneCreatorCreator();
            var sceneChanger = new SceneChanger(firstSceneCreatorCreator);
            sceneManager = new SceneManagerCreator(
                firstSceneCreatorCreator.Create(sceneChanger)
            ).Create();
            sceneChanger.ChangedScene.Subscribe(sceneCreator => sceneManager.SetScene(sceneCreator));
        }

        void Update()
        {
            sceneManager.Update();
        }
    }
}