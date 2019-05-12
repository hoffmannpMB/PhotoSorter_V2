namespace Models.Implementations
{
    public class CameraModel : ICameraModel
    {
        public string IconPath { get; set; }
        public string Manufacturer { get; set; }
        public int Offset { get; set; }
    }
}