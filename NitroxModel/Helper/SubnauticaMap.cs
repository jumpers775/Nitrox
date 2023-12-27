using System.Collections.Generic;
using NitroxModel.DataStructures;
using NitroxModel.DataStructures.GameLogic;

namespace NitroxModel.Helper;

/// <summary>
///     Static information about the game world loaded by Subnautica that shouldn't be retrieved from the game directly.
/// </summary>
public static class SubnauticaMap
{
    private const int BATCH_SIZE = 160;
    private const int SKYBOX_METERS_ABOVE_WATER = 160;

    /// <summary>
    ///     TechType can't be introspected at runtime in RELEASE mode because its reflection info is elided.
    /// </summary>
    public static readonly List<NitroxTechType> GLOBAL_ROOT_TECH_TYPES =
    [
        new NitroxTechType("Pipe"),
        new NitroxTechType("Constructor"),
        new NitroxTechType("Flare"),
        new NitroxTechType("Gravsphere"),
        new NitroxTechType("PipeSurfaceFloater"),
        new NitroxTechType("SmallStorage"),
        new NitroxTechType("CyclopsDecoy"),
        new NitroxTechType("LEDLight"),
        new NitroxTechType("Beacon")
    ];

    public static int ItemLevelOfDetail => 3;
    public static int BatchSize => 160;
    public static NitroxInt3 BatchDimensions => new NitroxInt3(BatchSize, BatchSize, BatchSize);
    public static NitroxInt3 DimensionsInMeters => new NitroxInt3(4096, 3200, 4096);
    public static NitroxInt3 DimensionsInBatches => NitroxInt3.Ceil(DimensionsInMeters / BATCH_SIZE);
    public static NitroxInt3 BatchDimensionCenter => new NitroxInt3(DimensionsInMeters.X / 2, DimensionsInMeters.Y - SKYBOX_METERS_ABOVE_WATER, DimensionsInMeters.Z / 2);
}
