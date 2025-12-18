using HouseholdExpenses.Domain.Enums;

namespace HouseholdExpenses.Domain.Entity
{
    public class Transaction
    {
        public Guid IdTransaction { get; private set; }
        public string DescriptionTransaction { get; private set; }
        public decimal Value { get; private set; }
        public TransactionEnum Type { get; private set; }
        public Category Category { get; private set; }
        public User User { get; private set; }

        public Transaction() { }

        public Transaction(string descriptionTransaction, decimal value, TransactionEnum type, Category category, User user)
        {
            SetDescriptionTransaction(descriptionTransaction);
            SetValue(value);
            SetType(type);
            SetCategory(category);
            SetUser(user);
        }

        public void SetDescriptionTransaction(string descriptionTransaction)
        {
            if (string.IsNullOrEmpty(descriptionTransaction))
                throw new ArgumentException("Descrição é obrigatória");

            DescriptionTransaction = descriptionTransaction;
        }

        public void SetValue(decimal value)
        {
            if (value <= 0)
                throw new ArgumentException("Valor precisa ser maior que Zero!!");

            Value = value;
        }

        public void SetType(TransactionEnum type)
        {
            Type = type;
        }

        public void SetCategory(Category category)
        {
            if (category is null)
                throw new ArgumentException("Categoria é obrigatória.");

            if (category.Purpose != PurposeEnum.ambas && (TransactionEnum)category.Purpose != Type)
                throw new ArgumentException($"Não é possível usar uma categoria do tipo {category.Purpose} em uma transação do tipo {Type}.");

            Category = category;
        }

        public void SetUser(User user)
        {
            User = user;
        }
    }
}
