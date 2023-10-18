﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace AiProStore.Promotions
{
    public class PromotionManufacturer : Entity<Guid>
    {
        public Guid ManufacturerId { get; set; }
        public Guid PromotionId { get; set; }
    }
}
