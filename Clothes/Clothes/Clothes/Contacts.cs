using System.ComponentModel.DataAnnotations;
using NHibernate.Mapping;
using DocumentFormat.OpenXml.Wordprocessing;
using Xamarin.Forms;
using ServiceStack.DataAnnotations;
using System;

namespace Clothes
{
    class Content
    {
      
        [PrimaryKey, AutoIncrement]

            public int Id
            {
            get; set;
            }
            public string Name
            {
            get; internal set;
            }
            public string Type
            {
            get; internal set;
            }
            public string T-shirt size
            {
                get; internal set;
            }
            public string Gender
            {
                get; internal set;
            }
            public string T-shirt color
            {
                get; internal set;
            }
            public string Address 
            {
                get; internal set;
            }

            [MaxLength(10)]
            public string PhoneNumber 
            {  
            get; internal set;
            }

            public string Email
            {
                get; internal set;
            }

            public string Amount
            {
                get; internal set;
            }

            public string Color
            {
                get; internal set;
            }

       
    }

    }

