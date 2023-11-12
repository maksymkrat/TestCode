namespace P_Facade
{
    public class VisualStudioFacade
    {
        private TextEditor textEditor;
        private Compiller _compiller;
        private CLR clr;

        public VisualStudioFacade(TextEditor textEditor, Compiller compiller, CLR clr)
        {
            this.textEditor = textEditor;
            this._compiller = compiller;
            this.clr = clr;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            _compiller.Compile();
            clr.Execute();
        }

        public void Stop()
        {
            clr.Finish();
        }
    }
}