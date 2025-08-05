using System;
using System.Threading.Tasks;
using DXApplication2.Entities;
using DXApplication2.Repositories;


namespace DXApplication2.DataAccess;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> UsersRepository { get; }
    IRepository<Item> ItemsRepository { get; }
    IRepository<Employee> EmployeesRepository { get; }
    IRepository<ItemAssignment> ItemsAssignmentRepository { get; }
    Task CommitAsync();
}