using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{
    public class UserInfo {
        public int Id { get; set; }  

        [Required(ErrorMessage = "İsim alanı boş olmamalı...")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş olmamalı...")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Mail adresi alanı boş olmamalı...")]
        [EmailAddress(ErrorMessage = "Mail adresi formatı hatalı...")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım durumu seçmelisiniz...")]
        public bool? WillAttend { get; set; }
    }
}