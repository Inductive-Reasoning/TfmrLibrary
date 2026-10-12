namespace TfmrLib.Tests;

public class WindingGraphTests
{
    [Fact]
    public void SegmentGraphTest()
    {
        var tfmr = new Transformer();
        var wdg = new Winding();
        tfmr.AddWinding(wdg);
        var seg = new WindingSegment();
        wdg.Segments.Add(seg);
        seg.Geometry = new DiscSegmentGeometry();
        seg.Geometry.NumTurns = 5;
        seg.Geometry.NumParallelConductors = 2;
        tfmr.Initialize();

    }

}