using Domain;
using GameSystem.Scene;
using UniFrameWork.Domain.Core;
using UniFrameWork.Domain.Core.Scene;

namespace BigBang.Scene
{
    public class SampleSceneCreatorCreator : ISceneCreatorCreator<SceneChanger>
    {
        public SceneCreator Create(SceneChanger sceneChanger)
        {
            return () => new SampleScene(sceneChanger);
        }
    }
}