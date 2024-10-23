using Kreata.Backend.Datas.Enums;

namespace Kreata.Backend.Datas.Entities
{
    public class Admin
    {
        public Admin(Guid id, string username, DateTime registered, int securitylevel, string nationality, bool isWooman, bool isOwner)
        {
            Id = id;
            Username = username;
            Registered = registered;
            SecurityLevel = securitylevel;
            Nationality = nationality;
            IsWoomen = isWooman;
            IsOwner = isOwner;
        }

        public Admin(string username, DateTime registered, int securitylevel, string nationality, bool isWooman, bool isOwner)
        {
            Id = new Guid();
            Username = username;
            Registered = registered;
            SecurityLevel = securitylevel;
            Nationality = nationality;
            IsWoomen = isWooman;
            IsOwner = isOwner;
        }

        public Admin()
        {
            Id = new Guid();
            Username = string.Empty;
            Registered = new DateTime();
            SecurityLevel = 9;
            Nationality = string.Empty;
            IsWoomen = false;
            IsOwner = true;
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public DateTime Registered { get; set; }
        public int SecurityLevel { get; set; }
        public string Nationality { get; set; }
        public bool IsWoomen { get; set; }
        public bool IsOwner { get; set; }

        public override string ToString()
        {
            return $"Username: {Username}, Spoken Languages: ({SecurityLevel}), Registered: ({String.Format("{0:yyyy.MM.dd.}", Registered)}), Nationality: ({Nationality}, is Server Owner: {IsOwner})";
        }
    }
}
