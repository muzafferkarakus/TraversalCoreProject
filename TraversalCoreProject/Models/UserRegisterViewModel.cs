using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Adınızı giriniz")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen Soyadınızı giriniz")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı giriniz")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Lütfen E-Posta adresini giriniz")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Lütfen Şifreyi giriniz")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen Şifreyi tekrar giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler Uyumlu değil")]
		public string ConfirmPassword { get; set; }
	}
}
