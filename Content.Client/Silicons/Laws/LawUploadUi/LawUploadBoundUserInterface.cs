using Robust.Shared.Prototypes;
using Content.Shared.Silicons.Laws;
using Robust.Client.UserInterface;

namespace Content.Client.Silicons.Laws.LawUploadUi
{
    public sealed class LawUploadBoundUserInterface : BoundUserInterface
    {

        [Dependency] private readonly IPrototypeManager _prototypeManager = default!;

        private LawUploadUi? _window;

        public LawUploadBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
        }


        protected override void Open()
        {
            base.Open();

            _window = this.CreateWindow<LawUploadUi>();

            _window.OnClose += Close;
            _window.OpenCentered();
        }

    }
}
