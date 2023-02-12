using System.ComponentModel.DataAnnotations;

namespace Model_Binding_Validation_And_Routing.Models
{
    public class Student
    {
        //Validation của Name là ko được trống
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        //Validation của Email là ko được trống và theo định dạng Email
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Validation của Phone là ko được trống và theo định dạng Phone
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
