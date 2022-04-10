using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BookingApp
{
    public class ExampleModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Client { get; set; }
        public string Frizer { get; set; }
        public DateTime Data { get;set; }
        public string Comentarii { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
