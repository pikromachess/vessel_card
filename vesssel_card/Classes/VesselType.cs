using System.Collections.ObjectModel;


namespace vesssel_card.Classes
{
    public class VesselType
    {
        public static ObservableCollection <string> GetAll ()
        {
            return new ObservableCollection <string> () { "Контейнеровоз", "Танкер", "Ро-Ро", "Балкер", "Газовоз", "Круизное судно"};
        }
    }
}
