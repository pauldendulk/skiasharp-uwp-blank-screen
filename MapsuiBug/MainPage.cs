using System;
using Xamarin.Forms;
using SkiaSharp;

namespace MapsuiBug
{
    public class MainPage : ContentPage
    {
        Button btnButton;

        public MainPage() : base()
        {
            var mv = new SkiaSharp.Views.Forms.SKGLView();
            mv.PaintSurface += Mv_PaintSurface;
            mv.HorizontalOptions = LayoutOptions.FillAndExpand;
            mv.VerticalOptions = LayoutOptions.FillAndExpand;
            btnButton = new Button
            {
                Text = "Click Me"
            };
            btnButton.Clicked += BtnButton_Clicked;

            Content = new StackLayout
            {
                Children =
                    {
                        mv,
                        btnButton,
                    }
            };
        }

        private void Mv_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintGLSurfaceEventArgs e)
        {
            e.Surface.Canvas.DrawRect(100, 100, 500, 500, new SKPaint { Color = SKColors.Pink });
        }

        private void BtnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondForm());
        }
    }
}
