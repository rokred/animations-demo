using System;
using System.Reactive.Disposables;
using ReactiveUI;
using Xamarin.Forms;

namespace AnimationsDemo.ViewModels
{
    public class BaseViewModel : ReactiveObject, IDisposable
    {
        private CompositeDisposable Disposables { get; }

        protected BaseViewModel()
        {
            Disposables = new CompositeDisposable();
        }
        public void Dispose()
        {
            Disposables.Dispose();
        }
        
        private INavigation Navigator => Application.Current.MainPage.Navigation;

        protected void NavigateTo<T>(T page) where T : Page
        {
            Navigator.PushAsync(page);
        }
    }
}