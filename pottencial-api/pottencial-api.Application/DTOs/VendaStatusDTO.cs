using pottencial-api.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace pottencial-api.Application.DTOs
{
    public class VendaStatusDTO
    {
        [Required]
        public VendaStatus VendaStatus { get; set; }
    }
}
