namespace Models
{
    public interface IImage
    {
        string ImageName { get; set; }
        string ImagePath { get; set; }
        string TmpImagePath { get; set; }
        float Rotation { get; set; }
    }
}