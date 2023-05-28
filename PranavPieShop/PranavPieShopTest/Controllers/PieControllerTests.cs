﻿using Microsoft.AspNetCore.Mvc;

using PranavPieShop.Controllers;
using PranavPieShop.ViewModels;

using PranavPieShopTest.Mocks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace PranavPieShopTest.Controllers
{
    public class PieControllerTests
    {
        [Fact]
        public void List_EmptyCategory_ReturnsAllPies()
        {
            //arrange
            var mockPieRepository = RepositoryMocks.GetPieRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

            var pieController = new PieController(mockPieRepository.Object, mockCategoryRepository.Object);

            //act
            var result = pieController.List("");

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
            Assert.Equal(10, pieListViewModel.Pies.Count());
        }

    }
}
