using System;
using System.Collections.ObjectModel;

namespace vesssel_card.Classes
{
    public class JournalYear
    {
        public static ObservableCollection<int> GetAll()
        { 
            var list = new ObservableCollection<int>();
            int minYear = 2014;

            for (int year = minYear; year <= DateTime.Now.Year; year++) 
            { 
                list.Add(year);
            }

            return list;
        }
    }
}
