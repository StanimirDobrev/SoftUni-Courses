using System.Data.Common;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            List<User> users = new List<User>();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] arguments = input.Split('=');
                string command = arguments[0];

                switch (command)
                {
                    case "Add":
                        string username = arguments[1];
                        int sent = int.Parse(arguments[2]);
                        int recieved = int.Parse(arguments[3]);

                        if (!users.Any(x => x.Username == username))
                        {
                            users.Add(new User(username, sent, recieved));
                        }
                        break;
                    case "Message":
                        string sender = arguments[1];
                        string reciever = arguments[2];

                        User senderUser = users.FirstOrDefault(x => x.Username == sender);
                        User recieverUser = users.FirstOrDefault(x => x.Username == reciever);

                        if (senderUser != null && recieverUser != null)
                        {
                            senderUser.SentMessages++;
                            recieverUser.RecievedMessages++;

                            CheckCapacity(users, sender, capacity);
                            CheckCapacity(users, reciever, capacity);
                        }
                        break;
                    case "Empty":
                        string userToRemove = arguments[1];
                        if (userToRemove == "All")
                        {
                            users.Clear();
                        }
                        else
                        {
                            User removedUser = users.FirstOrDefault(u => u.Username == userToRemove);
                            if (removedUser != null)
                            {
                                users.Remove(removedUser);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Username} - {user.SentMessages + user.RecievedMessages}");
            }
        }

        private static void CheckCapacity(List<User> users, string username, int capacity)
        {
            User user = users.FirstOrDefault(x => x.Username == username);

            if (user != null && (user.SentMessages + user.RecievedMessages >= capacity))
            {
                Console.WriteLine($"{username} reached the capacity!");
                users.Remove(user);
            }
        }
    }

    class User
    {
        public User(string username, int sent, int recieved)
        {
            Username = username;
            SentMessages = sent;
            RecievedMessages = recieved;
        }

        public string Username { get; set; }
        public int SentMessages { get; set; }
        public int RecievedMessages { get; set; }
    }
}
