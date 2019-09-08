using UniFrameWork.Domain.Core;
using UniFrameWork.Domain.Core.Scene;
using UniFrameWork.Domain.Core.UniEvent;

namespace Domain
{
    public class SceneChanger
    {
        readonly UniEvent<SceneCreator> changedScene = new UniEvent<SceneCreator>();

        readonly ISceneCreatorCreator<SceneChanger> sampleSceneCreatorCreator;

        public IUniEventSubscriber<SceneCreator> ChangedScene => changedScene;

        public SceneChanger(
            ISceneCreatorCreator<SceneChanger> sampleSceneCreatorCreator
        )
        {
            this.sampleSceneCreatorCreator = sampleSceneCreatorCreator;
        }

        public void ChangeSampleScene()
        {
            changedScene.Raise(sampleSceneCreatorCreator.Create(this));
        }
    }
}