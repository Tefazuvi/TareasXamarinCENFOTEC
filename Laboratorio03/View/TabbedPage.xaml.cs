using System;
using System.Collections.Generic;
using Laboratorio03.ViewModel;
using Xamarin.Forms;

namespace Laboratorio03.View
{
    public partial class TabbedPageView : TabbedPage
    {
        public TabbedPageView()
        {
            InitializeComponent();
            BindingContext = new Lab03ViewModel();
        }
    }
}
