using Noerlund.Application.Services;
using System;
using System.Reflection;
using System.Threading.Tasks;
using Moq;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;
using Noerlund.Domain.Repositories;
using Xunit;

namespace Noerlund.UnitTestMoq
{
    public class CategoryServiceTest
    {
        private readonly CategoryService _sut;
        // create mock of repository and use memory 
        private readonly Mock<ICategoryRepo> _categoryRepoMock = new Mock<ICategoryRepo>();

        public CategoryServiceTest()
        {
            _sut = new CategoryService(_categoryRepoMock.Object);
        }

        [Fact]
        public async Task GetByName_ShouldReturnCategory_IfCategoryExist()
        {
            // Arrange
            var categoryName = "Lars";
            var categoryId = Guid.NewGuid();
            var categoryDto = new Category(categoryId, categoryName);


            _categoryRepoMock.Setup(x => x.GetCategoryByGuidId(categoryName))
                .Returns(categoryDto);
            
            // Act
            var category = _sut.GetCategoryByGuidCategoryName(categoryName);

            // Assert
            Assert.Equal(categoryId, category.CategoryId);
            Assert.Equal(categoryName, category.CategoryName);
        }
    }
}
