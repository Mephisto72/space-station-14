using Content.Shared.Silicons.Laws;
using Robust.Shared.GameStates;
using Content.Shared.Containers.ItemSlots;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Silicons.Laws.Components;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedAiLawConsoleSystem))]

public sealed partial class AiLawConsoleComponent : Component
{
    public static string LawModuleSlotId = "AiLawConsole-lawModule";

    [DataField]
    public ItemSlot LawModuleSlot = new();
}
