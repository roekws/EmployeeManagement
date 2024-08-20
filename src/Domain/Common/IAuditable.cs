namespace Domain.Common
{
  internal interface IAuditable
  {
    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }
  }
}
