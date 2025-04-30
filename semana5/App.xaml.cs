namespace semana5
{
    public partial class App : Application
    {
        public static Repository.PersonaRepository personaRepo {  get; set; }
        public App(Repository.PersonaRepository personaRepository)
        {
            InitializeComponent();
            personaRepo = personaRepository;

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Views.Home());
        }
    }
}