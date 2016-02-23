using Logic.Data.Connection;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data
{
    public static class Messages
    {
        public static List<Message> Get(Int32 userId)
        {
            var messages = new List<Message>();
            using (var connection = Database.Connect())
            using (var command = Database.Command(@"EXEC [dbo].[GetMessages] @UserId;", connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        messages.Add(new Message
                        {
                            MessageId = reader.GetInt32("MessageId"),
                            AuthorId = reader.GetInt32("FromUserId"),
                            ThreadId = reader.GetGuid("ThreadId"),
                            CreatedDate = reader.GetString("Created"),
                            Text = reader.GetString("Text"),
                            MessageStatus = reader.GetInt32("Status"),
                            UserName = reader.GetString("Username")
                        });
                    }
                }
            }
            return messages;
        }

        /// <summary>
        /// Return Message detials by userid and messageId
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns></returns>
        public static Message GetMessageById(Int32 messageId)
        {
            var message = new Message();
            using (var connection = Database.Connect())
            using (var command = Database.Command(@"EXEC [dbo].[GetMessage] @MessageId;", connection))
            {
             command.Parameters.AddWithValue("@MessageId", messageId);
               

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                      
                        message.MessageId = reader.GetInt32("MessageId");
                        message.AuthorId = reader.GetInt32("FromUserId");
                        message.ThreadId = reader.GetGuid("ThreadId");
                        message.CreatedDate = reader.GetString("Created");
                        message.Text = reader.GetString("Text");
                        message.MessageStatus = reader.GetInt32("Status");
                        message.UserName = reader.GetString("Username");
                    }
                }
            }
            return message;
        }
    }
}
