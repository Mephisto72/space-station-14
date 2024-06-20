namespace Content.Shared.Silicons.Laws.Components;


[RegisterComponent]

public sealed partial class LawModuleComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("Custom Laws")]
    public bool LawEditingEnabled;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("Law Priority")]
    public float? LawPriority { get; set; } = 0f;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("Specific Lawset")]
    public string? SpecificLawset { get; set; } = null;
}
