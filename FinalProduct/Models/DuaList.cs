using System;
using SQLite;

namespace FinalProduct.Views
{
    public class DuaList 
    {
        
        public string Name { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    }
