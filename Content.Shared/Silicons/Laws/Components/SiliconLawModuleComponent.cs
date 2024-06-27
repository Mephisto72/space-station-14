namespace Content.Shared.Silicons.Laws.Components;


[RegisterComponent]

public sealed partial class LawModuleComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("Custom Laws")]
    public bool LawEditingEnabled;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("Custom Priority")]
    public bool PriorityEditingEnabled;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("Law Priority")]
    public int? LawPriority { get; set; } = null;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("Specific Lawset")]
    public string? SpecificLawset { get; set; } = null;
}
