﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdFundCore.Models
{
    public class FundingProject
    {
        public int Id { get; set; }
        public int Projectid { get; set; }
        public int Packageid { get; set; }
        public int Userid { get; set; }
        public decimal Reward { get; set; } 
    }
}
