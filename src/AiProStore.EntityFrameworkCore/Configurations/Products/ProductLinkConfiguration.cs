﻿using AiProStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiProStore.Products
{
    public class ProductLinkConfiguration : IEntityTypeConfiguration<ProductLink>
    {
        public void Configure(EntityTypeBuilder<ProductLink> builder)
        {
            builder.ToTable(AiProStoreConsts.DbTablePrefix + "ProductLinks");
            builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
        }
    }
}
