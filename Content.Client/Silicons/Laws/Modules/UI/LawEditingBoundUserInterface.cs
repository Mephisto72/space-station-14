using Content.Silicons.Laws.Modules;

namespace Content.Client.Silicons.Laws.Modules.UI
{
    public sealed class LawEditingBoundUserInterface : BoundUserInterface
    {
        [ViewVariables]
        private LawEditingWindow? _window;

        public LawEditingBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
        }

        protected override void Open()
        {
            base.Open();

            _window = new LawEditingWindow();
            if (State != null)
                UpdateState(State);

            _window.OpenCentered();

            _window.OnClose += Close;
            _window.OnLawChanged += OnLawChanged;
        }

        private void OnLawChanged(string newLabel)
        {
            SendMessage(new LawEditingLawChangedMessage(newLabel));
        }

        /// <summary>
        /// Update the UI state based on server-sent info
        /// </summary>
        /// <param name="state"></param>
        protected override void UpdateState(BoundUserInterfaceState state)
        {
            base.UpdateState(state);
            if (_window == null || state is not LawEditingBoundUserInterfaceState cast)
                return;

            _window.SetCurrentLaw(cast.CurrentLaw);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (!disposing) return;
            _window?.Dispose();
        }
    }

}
