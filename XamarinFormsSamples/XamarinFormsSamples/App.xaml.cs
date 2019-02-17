using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinFormsSamples.ExpandableListView;
using XamarinFormsSamples.TabbedPageDemo;

namespace XamarinFormsSamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new TabbedPageContainer();
            MainPage = new ListViewPage();
        }

        private void SetMainPage()
        {
            //var tabbedpage = new TabbedPage();
            //var contentpage = new ContentPage()
            //{
            //    Title = "Tab 3",
            //    BackgroundColor = Color.LightSteelBlue,
            //    Content = new StackLayout()
            //    {
            //        HorizontalOptions = LayoutOptions.CenterAndExpand,
            //        VerticalOptions = LayoutOptions.CenterAndExpand,
            //        Children = { new Label { Text = "Content of Page3" } }
            //    }
            //};

            //tabbedpage.Children.Add(new TabbedPage1());
            //tabbedpage.Children.Add(new TabbedPage2());
            //tabbedpage.Children.Add(contentpage);

            //MainPage = tabbedpage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
