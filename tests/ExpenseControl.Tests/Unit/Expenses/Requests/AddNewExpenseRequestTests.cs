using ExpenseControl.Application.Expenses.Requests;
using ExpenseControl.Application.Expenses.Validators;
using Shouldly;

namespace ExpenseControl.Tests.Unit.Expenses.Requests
{
    public class AddNewExpenseRequestTests
    {
        [Fact]
        public void ShouldReturnSuccess()
        {
            // Arrange
            var request = new AddNewExpenseRequest
            {
                Description = "Description test",
                Amount = 1.1m,
                Date = DateTime.Now.AddDays(-2)
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(true);
        }

        [Fact]
        public void ShouldReturnErrorWhenIsFutureDate()
        {
            // Arrange
            var now = DateTime.Now;
            var other = now.AddDays(-1);

            var request = new AddNewExpenseRequest
            {
                Description = "Description test",
                Amount = 1.1m,
                Date = DateTime.Now.AddDays(10)
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(false);
            result.Errors.FirstOrDefault()?.ErrorMessage.ShouldBe("Invalid date");
        }

        [Fact]
        public void ShouldReturnErrorWhenDateGreaterThanNowMinus12()
        {
            // Arrange
            var now = DateTime.Now;
            var other = now.AddDays(-1);

            var request = new AddNewExpenseRequest
            {
                Description = "Description test",
                Amount = 1.1m,
                Date = DateTime.Now
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(false);
            result.Errors.FirstOrDefault()?.ErrorMessage.ShouldBe("Invalid date");
        }

        [Fact]
        public void ShouldReturnErrorWhenAmountIsLessZero()
        {
            // Arrange
            var request = new AddNewExpenseRequest
            {
                Description = "Description test",
                Amount = -1.1m,
                Date = DateTime.Now
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(false);
            result.Errors.FirstOrDefault()?.ErrorMessage.ShouldBe("Amount should be greater than zero");
        }

        [Fact]
        public void ShouldReturnErrorWhenAmountIsEqualZero()
        {
            // Arrange
            var request = new AddNewExpenseRequest
            {
                Description = "Description test",
                Amount = 0,
                Date = DateTime.Now
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(false);
            result.Errors.FirstOrDefault()?.ErrorMessage.ShouldBe("Amount should be greater than zero");
        }

        [Fact]
        public void ShouldReturnErrorWhenDescriptionLengthIsLong()
        {
            // Arrange
            var request = new AddNewExpenseRequest
            {
                Description = "Description is biggest length 1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890",
                Amount = 10,
                Date = DateTime.Now
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(false);
            result.Errors.FirstOrDefault()?.ErrorMessage.ShouldBe("Description length exceeded");
        }

        [Fact]
        public void ShouldReturnErrorWhenDescriptionIsNull()
        {
            // Arrange
            var request = new AddNewExpenseRequest
            {
                Description = null,
                Amount = 10,
                Date = DateTime.Now
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(false);
            result.Errors.FirstOrDefault()?.ErrorMessage.ShouldBe("Description is required");
        }

        [Fact]
        public void ShouldReturnErrorWhenDescriptionIsEmpty()
        {
            // Arrange
            var request = new AddNewExpenseRequest
            {
                Description = "",
                Amount = 10,
                Date = DateTime.Now
            };

            var validator = new AddNewExpenseRequestValidator();

            // Act
            var result = validator.Validate(request);

            // Assert
            result.IsValid.ShouldBe(false);
            result.Errors.FirstOrDefault()?.ErrorMessage.ShouldBe("Description is required");
        }
    }
}
