using System;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System.Diagnostics;

namespace MapsuiBug
{
    public class MainPage : ContentPage
    {
        Button btnButton;
        Button btnRefresh;
        SKGLView mv;

        public MainPage() : base()
        {
            mv = new SKGLView();
            mv.PaintSurface += Mv_PaintSurface;
            mv.HorizontalOptions = LayoutOptions.FillAndExpand;
            mv.VerticalOptions = LayoutOptions.FillAndExpand;
            btnButton = new Button
            {
                Text = "Click Me"
            };
            btnButton.Clicked += BtnButton_Clicked;

            btnRefresh = new Button
            {
                Text = "Refresh"
            };
            btnRefresh.Clicked += BtnRefresh_Clicked; ;

            Content = new StackLayout
            {
                Children =
                    {
                        mv,
                        new StackLayout 
                        { 
                            Orientation = StackOrientation.Horizontal,
                            Children = 
                                {                       
                                   btnButton,
                                   btnRefresh
                                }
                        }  
                    }
            };
        }

        private void BtnRefresh_Clicked(object sender, EventArgs e)
        {
            mv.InvalidateSurface();
        }

        private void Mv_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintGLSurfaceEventArgs e)
        {
            e.Surface.Canvas.DrawRect(100, 100, 500, 500, new SKPaint { Color = SKColors.Pink });
            Debug.WriteLine($"GRContext: {mv.GRContext}");
        }

        private void BtnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondForm());
        }
    }
}
