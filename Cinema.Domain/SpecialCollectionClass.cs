﻿using Cinema.Domain.DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Domain
{
    public class SpecialCollectionClass
    {
        // results of search query
        public List<Ticket> SearchResults { get; set; }

        public SelectList TypeOptions { get; set; }

        // Selected search options
        [Required]
        public string SearchGenre { get; set; }
        public string CurrentFilter { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
    
}
