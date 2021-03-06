﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APITarea.Models
{
    public enum StatusTypeS
    {
        Activo,
        Inactivo
    }
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}