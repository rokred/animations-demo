using System;
using System.Reactive.Linq;
using AnimationsDemo.ViewModels;
using ReactiveUI.XamForms;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimationsDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EdgarNavigationsView : ReactiveContentPage<EdgarAnimationsViewModel>
    {
        public EdgarNavigationsView()
        {
            InitializeComponent();

            RokredSkiaButton.EnableTouchEvents = true;


            RokredSkiaButton.Touch += RokredSkiaButtonOnTouch;

//            Observable.FromEventPattern<SKTouchEventArgs>(x => RokredSkiaButton.Touch += x,
//                    x => RokredSkiaButton.Touch -= x).Throttle(TimeSpan.FromSeconds(5))
//                .Where(c => c.EventArgs.ActionType == SKTouchAction.Released).Subscribe(
//                    x =>
//                    {
//                        BackgroundColor = Color.Red;
//                    });
        }

        private void RokredSkiaButtonOnTouch(object sender, SKTouchEventArgs e)
        {
            switch (e.ActionType)
            {
                case SKTouchAction.Entered:
                    break;
                case SKTouchAction.Pressed:
                    break;
                case SKTouchAction.Moved:
                    break;
                case SKTouchAction.Released:
                    break;
                case SKTouchAction.Cancelled:
                    break;
                case SKTouchAction.Exited:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}