﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language()
                {
                    Id = "vi-VN",
                    Name = "Tiếng Việt",
                    IsDefault = true
                },
                new Language()
                {
                    Id = "en-US",
                    Name = "English",
                    IsDefault = false
                }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id=1,
                    IsShowOnHome = true, ParentId = null, SortOrder = 1,
                    Status = Enums.Status.Active,
                },
                new Category()
                {
                    Id=2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active,
                });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                        new CategoryTranslation(){Id=1, CategoryId=1, Name="Áo nam", LanguageId="vi-VN", SeoAlias="ao-nam",
                            SeoDescription="Sản phẩm áo thời trang nam",SeoTitle="Sản phẩm áo thời trang nam"},
                        new CategoryTranslation(){Id=2, CategoryId=1, Name="Men shirt", LanguageId="en-US", SeoAlias="men-shirt",
                            SeoDescription="The shirt products for men",SeoTitle="The shirt products for men"},
                    new CategoryTranslation()
                    {
                        Id=3,
                        CategoryId=2,
                        Name = "Áo nữ",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-nu",
                        SeoDescription = "Sản phẩm áo thời trang nữ",
                        SeoTitle = "Sản phẩm áo thời trang nữ"
                    },
                        new CategoryTranslation()
                        {
                            Id=4,
                            CategoryId=2,
                            Name = "Women shirt",
                            LanguageId = "en-US",
                            SeoAlias = "women-shirt",
                            SeoDescription = "The shirt products for women",
                            SeoTitle = "The shirt products for women"
                        }

                        );
                modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id=1,
                    DateCreated= DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock=0,
                    ViewCount=0,
                }
                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id=1,
                    ProductId=1,
                    Name = "Áo sơ mi nam trắng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                    SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                    Details = "Áo sơ mi nam trắng Việt Tiến",
                    Description = "Áo sơ mi nam trắng Việt Tiến"
                },
                        new ProductTranslation()
                        {
                            Id=2,
                            ProductId=1,
                            Name = "Men white T-shirt Viet Tien",
                            LanguageId = "en-US",
                            SeoAlias = "men-white-t-shirt-viet-tien",
                            SeoDescription = "Men white T-shirt Viet Tien",
                            SeoTitle = "Men white T-shirt Viet Tien",
                            Details = "Men white T-shirt Viet Tien",
                            Description = "Men white T-shirt Viet Tien"
                        }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}
