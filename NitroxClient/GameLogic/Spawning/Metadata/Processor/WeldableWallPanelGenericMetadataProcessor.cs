using NitroxClient.GameLogic.Spawning.Metadata.Processor.Abstract;
using NitroxModel.DataStructures.GameLogic.Entities.Metadata;
using UnityEngine;

namespace NitroxClient.GameLogic.Spawning.Metadata.Processor;

public class WeldableWallPanelGenericMetadataProcessor : IEntityMetadataProcessor<WeldableWallPanelGenericMetadata>
{
    public void ProcessMetadata(GameObject gameObject, WeldableWallPanelGenericMetadata metadata)
    {
        WeldableWallPanelGeneric weldableWallPanelGeneric = gameObject.GetComponent<WeldableWallPanelGeneric>();
        weldableWallPanelGeneric.liveMixin.health = metadata.LiveMixInHealth;
    }
}
