﻿using api_mrp.Dto.Enums;

namespace api_mrp.Objects.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public int Maquina { get; set; }
        public string cargo { get; set; }
        public string hierarquia { get; set; }
        public string setor { get; set; }
        public UserStatus status { get; set; }
        public string senha { get; set; }

    }
}
