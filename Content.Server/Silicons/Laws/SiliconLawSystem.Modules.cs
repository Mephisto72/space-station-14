using Content.Shared.Examine;
using Content.Shared.Silicons.Laws.Components;

namespace Content.Server.Silicons.Laws;

public sealed partial class SiliconLawSystem
{
    public void InitializeLawModules()
    {
        SubscribeLocalEvent<LawModuleComponent, ExaminedEvent>(AddLaw);
    }

    private void AddLaw(EntityUid uid, LawModuleComponent component, ExaminedEvent args)
    {

    }
}
