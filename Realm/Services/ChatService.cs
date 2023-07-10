using System;
using System.Collections.Generic;
using System.Linq;
using Realm.Services.Interfaces;
using System.Threading.Tasks;
using Realm.Data.Models;

namespace Realm.Services
{
    public class ChatService : IChatServices
    {
        private readonly List<Chat> _chats;

        public ChatService()
        {
            // Initialize an empty list of tweets
            _chats = new List<Chat>();
        }

        public void CreateChat(Chat chat)
        {
            chat.Id = GetNextChatId();
            chat.Timestamp = DateTime.Now;
            _chats.Add(chat);
        }

        public List<Chat> GetChats()
        {
            return _chats.OrderByDescending(t => t.Timestamp).ToList();
        }

        public void DeleteChat(int chatId)
        {
            Chat tweet = _chats.FirstOrDefault(t => t.Id == chatId);
            if (tweet != null)
            {
                _chats.Remove(tweet);
            }
        }

        private int GetNextChatId()
        {
            return _chats.Count > 0 ? _chats.Max(t => t.Id) + 1 : 1;
        }
    }
}
