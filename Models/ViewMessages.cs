namespace MVCChat.Models
{
    public class ViewMessages
    {
        public ViewMessages(string name, string text)
        {
            Name = name;
            Text = text;
            Message = new Message(name, text);
        }
        public ViewMessages()
        {
        }

        public string? Name { get; set; }
        public string? Text { get; set; }

        public Message Message { get; set; }
        public IEnumerable<Message>? Messages { get; set; }
    }
}
