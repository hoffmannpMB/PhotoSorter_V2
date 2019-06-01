namespace Models.Implementations
{
    public class RedundantPhotoModel : IRedundantPhotoModel
    {
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public float Rotation { get; set; }
        public float Similarity { get; set; }
    }
}