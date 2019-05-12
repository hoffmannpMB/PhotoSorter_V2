namespace Models
{
    public interface ICameraModel
    {
        string IconPath { get; set; }
        string Manufacturer { get; set; }
        int Offset { get; set; }
    }
}