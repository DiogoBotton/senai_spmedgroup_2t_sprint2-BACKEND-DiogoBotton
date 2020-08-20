using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SpMedicalGroup_backend.Application.InputRequests
{
    [DataContract]
    public class UsuarioInput
    {
        [DataMember]
        [Required]
        public string Nome { get; set; }
        [DataMember]
        [Required]
        public string Email { get; set; }
        [DataMember]
        [Required]
        public string Senha { get; set; }
        [DataMember]
        [Required]
        public long TipoUsuarioId { get; set; }
    }
}
