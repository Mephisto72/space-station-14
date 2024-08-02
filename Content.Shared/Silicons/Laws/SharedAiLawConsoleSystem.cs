using Content.Shared.Containers.ItemSlots;
using Content.Shared.Silicons.Laws.Components;
using JetBrains.Annotations;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;
using Robust.Shared.Prototypes;

namespace Content.Shared.Silicons.Laws
{
    [UsedImplicitly]

    public abstract class SharedAiLawConsoleSystem : EntitySystem
    {
        [Dependency] private readonly ItemSlotsSystem _itemSlotsSystem = default!;

        [Dependency] private readonly ILogManager _log = default!;

        public const string Sawmill = "ailawconsole";
        protected ISawmill _sawmill = default!;

        public override void Initialize()
        {
            base.Initialize();
            _sawmill = _log.GetSawmill(Sawmill);

            SubscribeLocalEvent<AiLawConsoleComponent, ComponentInit>(OnComponentInit);
            SubscribeLocalEvent<AiLawConsoleComponent, ComponentRemove>(OnComponentRemove);
        }

        private void OnComponentInit(EntityUid uid, AiLawConsoleComponent component, ComponentInit args)
        {
            _itemSlotsSystem.AddItemSlot(uid, AiLawConsoleComponent.LawModuleSlotId, component.LawModuleSlot);
        }

        private void OnComponentRemove(EntityUid uid, AiLawConsoleComponent component, ComponentRemove args)
        {
            _itemSlotsSystem.RemoveItemSlot(uid, component.LawModuleSlot);
        }
    }
}
