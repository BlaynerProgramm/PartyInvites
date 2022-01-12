using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage = "Введи своё имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введи свой Email")]
        public string Email { get; set; }
        [Required (ErrorMessage = "Подтверди свой статус")]
        public bool? AcceptStatus { get; set; }
    }
}