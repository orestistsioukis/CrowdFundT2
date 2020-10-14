﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdFundT2.Core.Services.Options
{
    public class UpdatePackageOptions
    {
        public int? ProjectId { get; set; }
        public string Description { get; set; }
        public decimal? Reward { get; set; }
        public bool? IsActive { get; set; }
    }
}
