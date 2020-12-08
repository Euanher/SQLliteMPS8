using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLitePCL;
using Microsoft.Data.Sqlite;
using SendGrid.Helpers.Mail;
using Android.App;

namespace Clothes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainVeiwModel();
        }
         void Savebutton_Clicked(object sender, System.EventArgs e)
        {
            Content content = new Content()
            {
                Name = nameEntry.Text,
                Email = emailEntry.Text,
                Type = typeEntry.Text,
                Amount = amountEntry.Text,
                PhoneNumber = phonenumberEntry.Text,
                Color = colorEntry.Text,


            };
           
            {

            }
        }
        
    
    }
}

