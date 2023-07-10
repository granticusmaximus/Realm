using System;
using System.Collections.Generic;
using System.Linq;
using Realm.Data.Models;
using System.Threading.Tasks;

namespace Realm.Services.Interfaces
{
    public interface IChatServices
    {
        void CreateChat(Chat chat);
        List<Chat> GetChats();
        void DeleteChat(int chatId);
    }
}