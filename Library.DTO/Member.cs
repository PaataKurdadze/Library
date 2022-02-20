using System;

namespace Library.DTO
{
  public class Member
  {
    public int MemberID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PersonalIDNumber { get; set; } = null;
    public string HomeAddress { get; set; } = null;
    public string PhoneNumber { get; set; } = null;
    public string MemberShipStatus { get; set; } = null;
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
  }
}
