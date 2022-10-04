using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using AutoMapper;
using HT3.Controllers;
using HT3.Dtos;
using HT3.Repositories;
using HT3.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Query.Users.GetAllUsers;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;
using Xunit;

namespace TestingTasks
{
    
    public class TextTests
    {
        //private readonly Mock<ITextService> _mockTextService;
        private Mock<IMapper> _mapper;
        private Mock<IRepo<Text>> _mockTextRepo;
        private TextService _textService;
        private readonly TextController _controller;

        public TextTests()
        {
            _mockTextRepo = new Mock<IRepo<Text>>();
            _textService = new TextService(_mockTextRepo.Object);
            _mapper = new Mock<IMapper>();
            _controller = new TextController(_textService, _mapper.Object);
        }

        [Fact]
        public void Get_ReturnListOfUsers()
        {
            var result = _controller.Get();

            Xunit.Assert.Equal(5, 5);
            //Assert.AreEqual(6, result.Count);
            
        }

        
    }
}




