using CineApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.Entities.Dtos.ChatDtos
{
    public class ChatListDto : DtoGetBase
    {
        public IEnumerable<ChatDto> Chats { get; set; }
    }
}
