namespace Models.Implementations
{
    public class RedundantPhotoModel : IRedundantPhotoModel
    {
        public RedundantPhotoModel()
        {
            IsChecked = false;
            Similarity = 70;
        }

        public string ImagePath { get; set; }
        public float Similarity { get; set; }
        public bool? IsChecked { get; set; }
    }
}