using Microsoft.VisualBasic;

namespace LoggingKata
{
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }

    }
}