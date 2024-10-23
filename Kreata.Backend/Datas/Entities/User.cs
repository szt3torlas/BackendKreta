using Kreata.Backend.Datas.Enums;

namespace Kreata.Backend.Datas.Entities
{
    public class User
    {
        public User(Guid id, string username, DateTime registered, int languages, string nationality, bool isWooman)
        {
            Id = id;
            Username = username;
            Registered = registered;
            Languages = languages;
            Nationality = nationality;
            IsWoomen = isWooman;
        }

        public User(string username, DateTime registered, int languages, string nationality, bool isWooman)
        {
            Id = new Guid();
            Username = username;
            Registered = registered;
            Languages = languages;
            Nationality = nationality;
            IsWoomen = isWooman;
        }

        public User()
        {
            Id = new Guid();
            Username = string.Empty;
            Registered = new DateTime();
            Languages = 9;
            Nationality = string.Empty;
            IsWoomen = false;
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public DateTime Registered { get; set; }
        public int Languages { get; set; }
        public string Nationality { get; set; }
        public bool IsWoomen { get; set; }

        public override string ToString()
        {
            return $"Username: {Username}, Spoken Languages: ({Languages}), Registered: ({String.Format("{0:yyyy.MM.dd.}", Registered)}), Nationality: ({Nationality})";
        }
    }
}
