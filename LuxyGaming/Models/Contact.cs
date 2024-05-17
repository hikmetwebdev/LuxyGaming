namespace LuxyGaming.Models
{
    public class Contact : Base
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string title, string text, string desc, string adress, string phone, string email)
        {
            Title = title;
            Text = text;
            Description = desc;
            Address = adress;
            Phone = phone;
            Email = email;

        }
    }
}
