using AutoFixture;
using FluentAssertions;
using Moq;
using ToDoListAPI.Core.Domain.Entities;
using ToDoListAPI.Core.Domain.RepositoryContracts;
using ToDoListAPI.Core.DTO.Task;
using ToDoListAPI.Core.Services;
using ToDoListAPI.Core.ServicesContracts;

namespace ToDoListAPI.ServiceTests
{
    public class TodoTaskServiceTest
    {
        private readonly IFixture _fixture;
        private readonly IAddTodoTaskService _addTodoTaskService;
        private readonly IUpdateTodoTaskService _updateTodoTaskService;
        private readonly IDeleteTodoTaskService _deleteTodoTaskService;
        private readonly IGetTodoTaskService _getTodoTaskService;
        private readonly ITasksRepository _tasksRepository;
        private readonly Mock<ITasksRepository> _tasksRepositoryMock;


        public TodoTaskServiceTest()
        {
            _fixture = new Fixture();
            _tasksRepositoryMock = new Mock<ITasksRepository>();
            _tasksRepository = _tasksRepositoryMock.Object;
            _addTodoTaskService = new AddTodoTaskService(_tasksRepository);
            _updateTodoTaskService = new UpdateTodoTaskService(_tasksRepository);
            _deleteTodoTaskService = new DeleteTodoTaskService(_tasksRepository);
            _getTodoTaskService = new GetTodoTaskService(_tasksRepository);

        }

        /// <summary>
        /// Returns null exception on empty task
        /// </summary>

        [Fact]
        public async Task AddTaskService_EmptyTask_NullException()
        {
            //Arrange
            AddTaskRequestDTO? addTaskRequest = null;


            //Act
            Func<Task> action = async () => await _addTodoTaskService.AddTask(addTaskRequest);

            await action.Should().ThrowAsync<ArgumentNullException>();


        }

        /// <summary>
        /// Test a valid task, returns the created task.
        /// </summary>

        [Fact]
        public async Task AddTaskService_ValidTask_Success()
        {
            //Arrange
            var addTaskRequest = _fixture.Create<AddTaskRequestDTO>();

            _tasksRepositoryMock.Setup(x => x.AddTask(It.IsAny<TodoTask>())).ReturnsAsync(new TodoTask());

            //Act
            var result = await _addTodoTaskService.AddTask(addTaskRequest);

            //Assert
            result.Should().NotBeNull();
            result.Id.Should().NotBeEmpty();

        }

        [Fact]
        public async Task UpdateTaskService_EmptyTask_NullException()
        {
            //Arrange
            UpdateTaskRequestDTO? updateTaskRequest = null;

            //Act
            Func<Task> action = async () => await _updateTodoTaskService.UpdateTask(updateTaskRequest);

            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task UpdateTaskService_ValidTask_Success()
        {
            //Arrange
            var updateTaskRequest = _fixture.Create<UpdateTaskRequestDTO>();

            _tasksRepositoryMock.Setup(x => x.GetTaskById(It.IsAny<Guid>())).ReturnsAsync(new TodoTask());
            _tasksRepositoryMock.Setup(x => x.UpdateTask(It.IsAny<TodoTask>())).ReturnsAsync(new TodoTask());

            //Act
            var result = await _updateTodoTaskService.UpdateTask(updateTaskRequest);

            //Assert
            result.Should().BeTrue();
        }
        [Fact]
        public async Task DeleteTaskService_EmptyTask_NullException()
        {
            //Arrange
            Guid? taskId = null;

            //Act
            Func<Task> action = async () => await _deleteTodoTaskService.DeleteTask(taskId);

            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task DeleteTaskService_ValidTask_Success()
        {
            //Arrange
            var taskId = _fixture.Create<Guid>();

            _tasksRepositoryMock.Setup(x => x.DeleteTask(It.IsAny<Guid>())).ReturnsAsync(true);

            //Act
            var result = await _deleteTodoTaskService.DeleteTask(taskId);

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public async Task GetTaskService_ValidTask_Success()
        {
            //Arrange
            var taskId = _fixture.Create<Guid>();

            _tasksRepositoryMock.Setup(x => x.GetTaskById(It.IsAny<Guid>())).ReturnsAsync(new TodoTask());

            //Act
            var result = await _getTodoTaskService.GetTaskById(taskId);

            //Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetTasksService_ValidTask_Success()
        {
            //Arrange
            _tasksRepositoryMock.Setup(x => x.GetTasks()).ReturnsAsync(new List<TodoTask>());

            //Act
            var result = await _getTodoTaskService.GetTasks();

            //Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetTasksService_EmptyTask_Success()
        {
            //Arrange
            _tasksRepositoryMock.Setup(x => x.GetTasks()).ReturnsAsync(new List<TodoTask>());

            //Act
            var result = await _getTodoTaskService.GetTasks();

            //Assert
            result.Should().NotBeNull();


        }

        [Fact]
        public async Task GetTaskService_EmptyTask_Success()
        {
            //Arrange
            var taskId = _fixture.Create<Guid>();

            _tasksRepositoryMock.Setup(x => x.GetTaskById(It.IsAny<Guid>())).ReturnsAsync(new TodoTask());

            //Act
            var result = await _getTodoTaskService.GetTaskById(taskId);

            //Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetTaskService_EmptyTask_NullException()
        {
            //Arrange
            Guid? taskId = null;

            //Act
            Func<Task> action = async () => await _getTodoTaskService.GetTaskById(taskId);

            await action.Should().ThrowAsync<ArgumentNullException>();
        }


        
        
    }
}