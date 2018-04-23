using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    //prop -> cria propriedade e getters e setters
    //ctor -> cria construtor


    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public DateTime data_nascimento { get; set; }
        
        
    }


    
    
}
