using Domain.Model;

namespace Domain.Dto
{
    public class ClienteDto : Cliente
    {
        public List<string> errorMessages { get; set; }

        public ClienteDto()
        {
            errorMessages = new List<string>();
        }
    }
}
