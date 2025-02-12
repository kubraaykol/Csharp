using FluentValidation;
using NTierArchitecture.UI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.UI.Business.Validators
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("Kategori alanı boş geçilemez")
                .MinimumLength(5).WithMessage("KAtegori adı min 5 karakter olmalıdır.")
                .MaximumLength(25).WithMessage("Kategori adı max 25 karakter olmalıdır ")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ\\s]+$").WithMessage("Lütfen sadece harf girişi yapınız");

            RuleFor(c => c.Descriptions).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
