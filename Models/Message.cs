namespace MVCChat.Models
{
    public class Message
    {
        public Message(string name, string text) 
        {
            Name = name;
            Text = text;
        }
        public Message()
        {
        }

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }
    }
}
