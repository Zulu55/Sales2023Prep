using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Controllers;
using Sales.API.Data;
using Sales.Shared.DTOs;
using Sales.Shared.Entities;

namespace Sales.API.Test.CategoriesTests
{
    public class CategoriesControllerTests
    {
        private readonly CategoriesController _controller;
        private readonly DataContext _context;

        public CategoriesControllerTests()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "testDatabase")
                .Options;

            _context = new DataContext(options);
            _controller = new CategoriesController(_context);
        }

        [Fact]
        public async Task Get_ReturnsOkResult()
        {
            // Arrange
            var pagination = new PaginationDTO { Page = 1, RecordsNumber = 10 };

            // Act
            var result = await _controller.Get(pagination);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        public async Task GetPages_ReturnsOkResult()
        {
            // Arrange
            var pagination = new PaginationDTO { Page = 1, RecordsNumber = 10 };

            // Act
            var result = await _controller.GetPages(pagination);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsNotFound_WhenCategoryDoesNotExist()
        {
            // Arrange
            int id = 1;

            // Act
            var result = await _controller.Get(id);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Post_ReturnsBadRequest_WhenCategoryNameAlreadyExists()
        {
            // Arrange
            var category = new Category { Name = "Category1" };
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.Post(category);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task Put_ReturnsBadRequest_WhenCategoryNameAlreadyExists()
        {
            // Arrange
            var category = new Category { Id = 1, Name = "Category1" };
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            var categoryToUpdate = new Category { Id = 2, Name = "Category1" };

            // Act
            var result = await _controller.Put(categoryToUpdate);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNoContent_WhenCategoryIsDeleted()
        {
            // Arrange
            var category = new Category { Id = 1, Name = "Category1" };
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }
}
