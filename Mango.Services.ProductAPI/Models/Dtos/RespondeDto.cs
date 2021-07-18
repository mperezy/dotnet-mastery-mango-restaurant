using System.Collections.Generic;

namespace Mango.Services.ProductAPI.Models.Dtos
{
    public class RespondeDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessages { get; set; }
    }
}