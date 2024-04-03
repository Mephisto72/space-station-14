using Robust.Shared.Serialization;

namespace Content.Silicons.Laws.Modules
{
    public sealed class LawEditingBoundUserInterfaceState : BoundUserInterfaceState
    {
        public string CurrentLaw { get; }

        public LawEditingBoundUserInterfaceState(string currentLaw)
        {
            CurrentLaw = currentLaw;
        }
    }

    [Serializable, NetSerializable]
    public sealed class LawEditingLawChangedMessage : BoundUserInterfaceMessage
    {
        public string Law { get; }

        public LawEditingLawChangedMessage(string law)
        {
            Law = law;
        }
    }
}
