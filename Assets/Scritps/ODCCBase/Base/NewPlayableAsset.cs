using UnityEngine;
using UnityEngine.Playables;

namespace BC.OdccBase
{
    [System.Serializable]
    public class NewPlayableAsset : PlayableAsset
    {
        // Factory method that generates a playable based on this asset
        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            return Playable.Create(graph);
        }
    }
}
