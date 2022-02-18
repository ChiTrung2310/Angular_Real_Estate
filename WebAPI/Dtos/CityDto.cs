using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class CityDto
    {
        public int Id { get ; set ;}

        [Required(ErrorMessage="Lỗi bỏ trống")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(".*[a-zA-Z]+.*", ErrorMessage="Chỉ có số không có chữ")]
        public string Name { get ; set ;}

        [Required]
        public string Country { get ; set ;}

    }
}