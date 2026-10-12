namespace TfmrLib
{
    public class MultiStartSegmentGeometry : HelicalSegmentGeometry
    {
        public int NumberOfStarts { get; set; }

        public int NumberOfTurnsPerStart { get; set; }

        public override int NumTurns => NumberOfStarts * NumberOfTurnsPerStart;

        public override int NumMechTurns => NumberOfStarts * (NumberOfTurnsPerStart + 1); // Total mechanical turns in the winding

        public MultiStartSegmentGeometry()
        {
            Type = SegmentType.MultiStart;
        }

        public MultiStartSegmentGeometry(WindingSegment parentSegment) : base(parentSegment)
        {
            Type = SegmentType.MultiStart;
        }
    }

    
}
