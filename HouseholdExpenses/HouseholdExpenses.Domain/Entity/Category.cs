using HouseholdExpenses.Domain.Enums;

namespace HouseholdExpenses.Domain.Entity
{
    public class Category
    {
        public Guid IdCategory { get; private set; }
        public string DescriptionCategory { get; private set; }
        public PurposeEnum Purpose { get; private set; }

        public Category() { }

        public Category(string descriptionCategory, PurposeEnum purpose)
        {
            SetDescriptionCategory(descriptionCategory);
            SetPurpose(purpose);
        }

        public void SetDescriptionCategory(string descriptionCategory)
        {
            if (string.IsNullOrEmpty(descriptionCategory))
                throw new ArgumentException("Descrição é obrigatória");

            DescriptionCategory = descriptionCategory;
        }

        public void SetPurpose(PurposeEnum purpose)
        {
            Purpose = purpose;
        }
    
    }
}
