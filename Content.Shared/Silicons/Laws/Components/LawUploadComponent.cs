using Robust.Shared.Serialization;
using Robust.Shared.GameStates;

namespace Content.Shared.Silicons.Laws.Components;

[RegisterComponent, NetworkedComponent]

public sealed partial class LawUploadComponent : Component
{
    [Serializable, NetSerializable]
    public enum LawUploadUiKey : byte
    {
        Key,
    }
}
