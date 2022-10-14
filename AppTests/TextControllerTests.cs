//using ApplicationCore.Domain.Entities;
//using AutoMapper;
//using HT3.Controllers;
//using HT3.Dtos;
//using HT3.Repositories;
//using HT3.Services;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc.Testing;
//using Moq;
//using TYPO.ApplicationCore.Domain;
//using TYPO.Hometask_3.Dtos;
//using TYPO;
//using System.Net.Http.Json;

//namespace AppTests
//{
//    public class TextControllerTests
//    {
//        private TextController _textController;
//        private IRepo<Text> _repo;
//        private ITextService _textService;
//        private TypoDbContext _fakeContext;
//        private Mock<IMapper> _mockMapper;

//        public TextControllerTests()
//        {
//            _fakeContext = new TypoDbContext();
//            _mockMapper = new Mock<IMapper>();
//            _repo = new Repo<Text>(_fakeContext);
//            _textService = new TextService(_repo);
//            _textController = new TextController(_textService, _mockMapper.Object);


//            var webAppFactory = new WebApplicationFactory<Program>();
//            _httpClient = webAppFactory.CreateDefaultClient();
//        }

//        [Fact]
//        public void GetAllText_ChecksTheTypeAndCountOfTexts()
//        {
//            // arrange
//            // act
//            var result = _textController.Get();

//            // assert
//            Assert.IsType<OkObjectResult>(result);

//            var list = result as OkObjectResult;
//            Assert.IsType<List<Text>>(list.Value);


//            var listBooks = list.Value as List<Text>;
//            Assert.Equal(16, listBooks.Count);
//        }

//        [Fact]
//        public void AddNewText_ChecksIfAddedAndIfExactData()
//        {
//            // arrange
//            var newTextDto = new CreateTextDto()
//            {
//                TextContent = "xUnitTesting",
//                Author = "Dima",
//                Level = 2,
//                Language = "English"
//            };

//            // act
//            var createdResponse = _textController.Post(newTextDto);

//            // assert
//            Assert.IsType<CreatedAtActionResult>(createdResponse);

//            var item = createdResponse as CreatedAtActionResult;
//            Assert.IsType<Text>(item.Value);

//            var textItemCheck = item.Value as Text;
//            Assert.Equal(newTextDto.Author, textItemCheck.Author);
//            Assert.Equal(newTextDto.TextContent, textItemCheck.TextContent);
//            Assert.Equal(newTextDto.Level, textItemCheck.Level);
//            Assert.Equal(newTextDto.Language, textItemCheck.Language);
//        }

//        [Fact]
//        public void RemoveTextById_ReturnsEitherOkAndCountOrNotFound()
//        {
//            // arrange
//            //int realId = 31;

//            //// act
//            //var deletingResponse = _textController.Delete(realId);

//            //// assert
//            //Assert.IsType<OkResult>(deletingResponse);
//            //Assert.Equal(17, _textService.GetAllTexts().Count);

//            // arrange
//            int fakeId = 343;

//            // act
//            var fakeDeletingResponse = _textController.Delete(fakeId);

//            // assert
//            Assert.IsType<NotFoundResult>(fakeDeletingResponse);
//        }

//        [Fact]
//        public void UpdateTextById_ReturnsEitherNoContentOrBadRequest()
//        {
//            // arrange
//            int realId = 26;
//            UpdateTextDto updateTextDto = new UpdateTextDto()
//            {
//                TextContent = "----------",
//                Author = "-----",
//                Level = 3,
//                Language = "English"
//            };

//            // act
//            var updatedResponse = _textController.Put(realId, updateTextDto);

//            // assert
//            Assert.IsType<NoContentResult>(updatedResponse);

            


//            //// arrange
//            //int fakeId = 3524;
            

//            //// act
//            //var fakeUpdatedResponse = _textController.Put(fakeId, updateTextDto);

//            //// assert
//            //Assert.IsType<BadRequestResult>(fakeUpdatedResponse);
//        }



//        private HttpClient _httpClient;
//        [Fact]
//        public async Task DefaultRoute()
//        {
//            var response = await _httpClient.GetAsync("");
//            var stringResult = await response.Content.ReadAsStringAsync();
//            Assert.Equal("Hello World!", stringResult);
//        }

//        [Fact]
//        public async Task Get_CheckIfAPIGetMethodWorks()
//        {
//            var response = await _httpClient.GetAsync("/api/Text");

//            response.EnsureSuccessStatusCode();

//            var responseString = await response.Content.ReadAsStringAsync();

//            Assert.Contains("admin", responseString);
//        }

//        [Fact]
//        public async Task Post_CheckIfAPIGetMethodWorks()
//        {
//            var postReq = new HttpRequestMessage(HttpMethod.Post, "/api/Text");

//            postReq.Content = JsonContent.Create(new
//            {
//                TextContent = "TestHomeTask",
//                Author = "AuAuAu",
//                Level = 2
//            });

//            var response = await _httpClient.SendAsync(postReq);

//            response.EnsureSuccessStatusCode();

//            var responseString = await response.Content.ReadAsStringAsync();

//            Assert.Contains("TestHomeTask", responseString);
//        }

//    }
//}