using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using AnimationsDemo.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace AnimationsDemo.Views

{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ReactiveContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();

            this.WhenActivated(disposable =>
            {
                this.BindCommand(ViewModel, vm => vm.EdgarAnimationCommand, v => v.EdgarAnimationsButton)
                    .DisposeWith(disposable);
            });
        }
    }
}