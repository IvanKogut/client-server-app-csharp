﻿namespace API.Models
{
  public class ItemListApiModel
  {
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public int StatusId { get; set; }
    public string Text { get; set; }
    public int Priority { get; set; }
  }
}
