

namespace vesssel_card.Classes
{
    public class Document
    {
        public int Id { get; set; } = -1;

        public string PathFile { get; set; }

        public string VesselType { get; set; }

        public int JournalYear { get; set; }

        public string LengthType { get; set; }

        public double? LengthValue { get; set; }

        public double? Width { get; set; }

        public double? SideHeight { get; set; }

        public double? Draught { get; set; }

        public double? Displacement { get; set; }

        public double? Deadweight { get;  set; }

        public double? Speed { get;  set; }

        public Document(string vesselType, int journalYear, string lengthType, double? length, double? width, double? sideHeight, double? draught, double? displacement, double? deadweight, double? speed, string pathFile)
        {
            VesselType = vesselType;
            JournalYear = journalYear;
            LengthType = lengthType;
            LengthValue = length;
            Width = width;
            SideHeight = sideHeight;
            Draught = draught;
            Displacement = displacement;
            Deadweight = deadweight;
            Speed = speed;
            PathFile = pathFile;
        }
        public Document() { }

        public void Save(int? id)
        {
            if (id.HasValue)
                 Id = id.Value; 

            DocumentCollection collection = DocumentCollection.GetCollection();
            collection.AddUpdate(this);
        }
    }
}
