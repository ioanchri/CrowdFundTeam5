﻿using System;
using System.Collections.Generic;
using System.Text;
using CrowdFundCore.Models;

namespace CrowdFundCore.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Reward { get; set; }
        public int ProjectId { get; set; }
        public int Count { get; set; }
        public Project Project { get; set; }
    }
}

