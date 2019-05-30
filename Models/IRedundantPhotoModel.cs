namespace Models
{
    public interface IRedundantPhotoModel
    {
        string ImagePath { get; set; }
        float Similarity { get; set; }
        bool? IsChecked { get; set; }
    }
}