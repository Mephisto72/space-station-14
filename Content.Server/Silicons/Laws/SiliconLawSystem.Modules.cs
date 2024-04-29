using Content.Server.Construction.Completions;
using Content.Shared.Administration.Logs;
using Content.Shared.Database;
using Content.Shared.Examine;
using Content.Shared.Interaction;
using Content.Shared.Silicons.Laws.Components;
using Content.Silicons.Laws.Modules;
using Robust.Server.GameObjects;

namespace Content.Server.Silicons.Laws;

public sealed partial class SiliconLawSystem
{
    [Dependency] private readonly UserInterfaceSystem _userInterfaceSystem = default!;

    [Dependency] private readonly ISharedAdminLogManager _adminLogger = default!;
    public void InitializeLawModules()
    {
        SubscribeLocalEvent<LawModuleComponent, InteractEvent>(AddLaw);
    }

    private void AddLaw(EntityUid uid, LawModuleComponent component, InteractEvent args)
    {
        Console.WriteLine("Test");
    }
}
