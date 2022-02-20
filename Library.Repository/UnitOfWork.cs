using DatabaseHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.Repository
{
  public sealed class UnitOfWork
  {
    private readonly Database _database;
    private readonly Lazy<BooksRepository> _booksRepository;
    private readonly Lazy<AuthorsRepository> _authorsRepository;
    private readonly Lazy<OrdersRepository> _ordersRepository;
    // private readonly Lazy<CategoriesRepository> _categoriesRepository;
    private readonly Lazy<EmployeesRepository> _employeesRepository;
    //  private readonly Lazy<MembersRepository> _membersRepository;
    private readonly Lazy<PositionRepository> _positionRepository;


    public UnitOfWork()
    {
      _database = new Database(true);
      _booksRepository = new Lazy<BooksRepository>(() => new BooksRepository(_database));
      _authorsRepository = new Lazy<AuthorsRepository>(() => new AuthorsRepository(_database));
      _ordersRepository = new Lazy<OrdersRepository>(() => new OrdersRepository(_database));
      // _categoriesRepository = new Lazy<CategoriesRepository>(() => new CategoriesRepository(_database));
      _employeesRepository = new Lazy<EmployeesRepository>(() => new EmployeesRepository(_database));
      // _membersRepository = new Lazy<MembersRepository>(() => new MembersRepository(_database));
      _positionRepository = new Lazy<PositionRepository>(() => new PositionRepository(_database));
    }


    public BooksRepository BooksRepository => _booksRepository.Value;
    public AuthorsRepository AuthorsRepository => _authorsRepository.Value;
    public OrdersRepository OrdersRepository => _ordersRepository.Value;
    //  public CategoriesRepository CategoriesRepository => _categoriesRepository.Value;
    public EmployeesRepository EmployeesRepository => _employeesRepository.Value;
    //  public MembersRepository MembersRepository => _membersRepository.Value;
    public PositionRepository PositionRepository => _positionRepository.Value;
  }
}
