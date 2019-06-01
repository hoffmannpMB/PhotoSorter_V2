namespace Models
{
    public interface IRedundantPhotoModel : IImage
    {
        float Similarity { get; set; }
    }
}