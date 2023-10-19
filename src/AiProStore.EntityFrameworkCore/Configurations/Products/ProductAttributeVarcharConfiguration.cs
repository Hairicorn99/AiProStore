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
    public class ProductAttributeVarcharConfiguration : IEntityTypeConfiguration<ProductAttributeVarchar>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeVarchar> builder)
        {
            builder.ToTable(AiProStoreConsts.DbTablePrefix + "ProductAttributeDateTimes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Value).HasMaxLength(500);
        }
    }
}