﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HaberSistemi.Data.Model
{
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Rol Adı : ")]
        [MinLength(3, ErrorMessage = "Lütfen 3 karakterden fazla değer giriniz"), MaxLength(100, ErrorMessage = "100 karakterden fazla olamaz.")]
        public string RolAdi { get; set; }


    }
}
