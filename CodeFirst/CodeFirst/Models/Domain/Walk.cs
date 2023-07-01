namespace CodeFirst.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }


        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //Navigation Property

        public Region Region { get; set; } //connect back to Region **green punya
        public WalkDifficulty WalkDifficulty { get; set; }  //connect back to WalkDifficulty **green punya
    }
}
