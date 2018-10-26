using System;
using System.Collections.Generic;
using System.Linq;

namespace identity.UserServices
{
    public class UserRepository : IUserRepository
    {
        // some dummy data. Replce this with your user persistence. 
        private readonly List<CustomUser> _users = new List<CustomUser>
        {
            new CustomUser{
                SubjectId = "123",
                UserName = "vpatel",
                Password = "vishal",
                Email = "vishal@dude.com"
            },
            new CustomUser{
                SubjectId = "124",
                UserName = "apatel",
                Password = "aarush",
                Email = "aarush@dude.com"
            },
            new CustomUser{
                SubjectId = "GDEACU\\VPATEL",
                UserName = "GDEACU\\VPATEL",
                Email = "vpatel@alliantcreditunion.com"
            }
        };

        public bool ValidateCredentials(string username, string password)
        {
            var user = FindByUsername(username);
            if (user != null)
            {
                return user.Password.Equals(password);
            }

            return false;
        }

        public CustomUser FindBySubjectId(string subjectId)
        {
            return _users.FirstOrDefault(x => string.Equals(x.SubjectId, subjectId, StringComparison.CurrentCultureIgnoreCase));
        }

        public CustomUser FindByUsername(string username)
        {
            return _users.FirstOrDefault(x => x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));
        }
    }
}
