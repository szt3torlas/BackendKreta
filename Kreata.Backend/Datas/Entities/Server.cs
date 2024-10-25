using Kreata.Backend.Datas.Enums;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Kreata.Backend.Datas.Entities
{
    public class Server
    {
        public Server(Guid id, string serverName, DateTime created, int numOfUsers, string owner, bool isPrivate)
        {
            Id = id;
            ServerName = serverName;
            Created = created;
            NumOfUsers = numOfUsers;
            Owner = owner;
            IsPrivate = isPrivate;
        }

        public Server(string serverName, DateTime created, int numOfUsers, string owner, bool isPrivate)
        {
            Id = new Guid();
            ServerName = serverName;
            Created = created;
            NumOfUsers = numOfUsers;
            Owner = owner;
            IsPrivate = isPrivate;
        }

        public Server()
        {
            Id = new Guid();
            ServerName = string.Empty;
            Created = new DateTime();
            NumOfUsers = 9;
            Owner = string.Empty;
            IsPrivate = false;
        }

        public Guid Id { get; set; }
        public string ServerName { get; set; }
        public DateTime Created { get; set; }
        public int NumOfUsers { get; set; }
        public string Owner { get; set; }
        public bool IsPrivate { get; set; }

        public override string ToString()
        {
            return $"Servername: {ServerName}, Number of Users: ({NumOfUsers}), Created: ({String.Format("{0:yyyy.MM.dd.}", Created)}), Nationality: ({Owner})";
        }
    }
}
