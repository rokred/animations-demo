using System.Reactive;
using System.Reactive.Linq;
using AnimationsDemo.Views;
using ReactiveUI;

namespace AnimationsDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ReactiveCommand<Unit, Unit> EdgarAnimationCommand { get; }

        public MainViewModel()
        {
            EdgarAnimationCommand = ReactiveCommand.Create(GoToEdgarAnimations, Observable.Return(true));
        }

        private void GoToEdgarAnimations()
        {
            NavigateTo(new EdgarNavigationsView());
        }
    }
}