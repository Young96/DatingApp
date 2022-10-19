using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public bool IsMain { get; set; }

        public string PublicId { get; set; }

        //Fully defining the realtion ship between photos and app user becoz
        //if we do migrations directly it does not allow cascade deletion which we want as a functionality
        //because if we delete the user we dont want its photos to remain in db forever
        public AppUser AppUser { get; set; }

        public int AppUserId { get; set; }

    }
}