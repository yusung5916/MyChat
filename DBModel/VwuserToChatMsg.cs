namespace Entities
{
    public partial class VwuserToChatMsg
    {
        public int UserId { get; set; }
        public int ChatId { get; set; }
        public string Message { get; set; } = null!;
        public DateTime PushDate { get; set; }
    }
}
