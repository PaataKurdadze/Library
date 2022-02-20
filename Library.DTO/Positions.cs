using System;

namespace Library.DTO
{
  public class Positions
  {
    public int PositionID { get; set; }
    public string PositionName { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
  }
}
