namespace Content.Shared.Silicons.Laws.Components;


[RegisterComponent]

public sealed partial class LawModuleComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("currentLaw")]
    public string CurrentLaw { get; set; } = string.Empty;
}
