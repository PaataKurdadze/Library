using Library.DTO;
using Library.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Library.Test
{
  [TestClass]
  public class RepositoryTest
  {
    private readonly UnitOfWork _unitOfWork;
    public int _id;
    public string errorMessage = "";

    public RepositoryTest()
    {
      _unitOfWork = new UnitOfWork();
    }


    [TestMethod]
    public void A_Insert()
    {
      try
      {
        _id = _unitOfWork.AuthorsRepository.Insert(new Author
        {
          FirstName = "ლუკა",
          MiddleName = "ვაჟა-ფშაველა",
          LastName = "რაზიკაშვილი"
        });

        LocalStorage.SetValue("AuthorID", _id);

        //int id = (int)LocalStorage.GetValue("AuthorID");
      }
      catch (Exception ex)
      {
        _id = 0;
        LocalStorage.SetValue("AuthorID", 0);
        errorMessage = ex.Message;
      }

      Assert.AreNotEqual(0, _id, $"Authot Insert doesn't work. {errorMessage}");
    }


    [TestMethod]
    public void B_GetByID()
    {
      Author author = new Author();
      try
      {
        _id = (int)LocalStorage.GetValue("AuthorID");

        author = _unitOfWork.AuthorsRepository.GetByID(_id, false);
      }
      catch (Exception ex)
      {
        _id = 0;
        LocalStorage.SetValue("AuthorID", 0);
        errorMessage = ex.Message;
      }

      Assert.AreEqual(_id, author.AuthorID, errorMessage);
    }


    [TestMethod]
    public void C_Update()
    {
      try
      {
        _unitOfWork.AuthorsRepository.Update(new Author
        {
          FirstName = "ლუკა2",
          MiddleName = "ვაჟა-ფშაველა2",
          LastName = "რაზიკაშვილი2"
        });

        _id = (int)LocalStorage.GetValue("AuthorID");
      }
      catch (Exception ex)
      {
        _id = 0;
        LocalStorage.SetValue("AuthorID", 0);
        errorMessage = ex.Message;
      }

      Assert.AreNotEqual(0, _id, errorMessage);
    }


    [TestMethod]
    public void D_Delete()
    {
      try
      {
        _unitOfWork.AuthorsRepository.Delete(Convert.ToInt32(_id));

        _id = (int)LocalStorage.GetValue("AuthorID");
      }
      catch (Exception ex)
      {
        _id = 0;
        LocalStorage.SetValue("AuthorID", 0);
        errorMessage = ex.Message;
      }

      Assert.AreNotEqual(0, _id, errorMessage);
    }



    /*
		[TestMethod]
		public void LoginSuccessfulTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admin", "1234");
		  Assert.IsTrue(result, "Valid username and password didn't login");
		}

		[TestMethod]
		public void LoginWrongPasswordTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admin", "123");
		  Assert.IsFalse(result, "Wrong password logged");
		}

		[TestMethod]
		public void LoginWrongUsernameTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admi", "1234");
		  Assert.IsFalse(result, "Wrong username logged");
		}

		[TestMethod]
		public void LoginWrongUsernameAndPasswordTest()
		{
		  bool result = _unitOfWork.EmployeesRepository.Login("admi", "123");
		  Assert.IsFalse(result, "Wrong username and password logged");
		}
		*/
  }
}
