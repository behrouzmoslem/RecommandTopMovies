namespace RandomRecommended
{
    internal class RecommandedMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public bool Accepted { get; set; }
    }
}