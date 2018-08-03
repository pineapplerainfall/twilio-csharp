/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2.Service.Channel 
{

    /// <summary>
    /// FetchMessageOptions
    /// </summary>
    public class FetchMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// Sid of the Service this message belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this message belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Key that uniquely defines the message to fetch.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this message belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this message belongs to. </param>
        /// <param name="pathSid"> Key that uniquely defines the message to fetch. </param>
        public FetchMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateMessageOptions
    /// </summary>
    public class CreateMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// Sid of the Service this message belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this message belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The identity of the message's author. Defaults to system if not specified.
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// The attributes metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Message should be set as being created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Message should be set as having been last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// Specify the Identity of the User that last updated the Message
        /// </summary>
        public string LastUpdatedBy { get; set; }
        /// <summary>
        /// The message body string.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        ///  The Media Sid to be attached to this Message.
        /// </summary>
        public string MediaSid { get; set; }

        /// <summary>
        /// Construct a new CreateMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this message belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this message belongs to. </param>
        public CreateMessageOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (LastUpdatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("LastUpdatedBy", LastUpdatedBy));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (MediaSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MediaSid", MediaSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadMessageOptions
    /// </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource> 
    {
        /// <summary>
        /// Sid of the Service this message belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this message belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Specifies sorting order for messages list, possible values are: `asc` or `desc`.
        /// </summary>
        public MessageResource.OrderTypeEnum Order { get; set; }

        /// <summary>
        /// Construct a new ReadMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this message belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this message belongs to. </param>
        public ReadMessageOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteMessageOptions
    /// </summary>
    public class DeleteMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// Sid of the Service this message belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this message belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Key that uniquely defines the message to delete.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this message belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this message belongs to. </param>
        /// <param name="pathSid"> Key that uniquely defines the message to delete. </param>
        public DeleteMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateMessageOptions
    /// </summary>
    public class UpdateMessageOptions : IOptions<MessageResource> 
    {
        /// <summary>
        /// Sid of the Service this message belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this message belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Key that uniquely defines the message to update.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The message body string.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The attributes metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Message should be set as being created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Message should be set as having been last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// Specify the Identity of the User that last updated the Message
        /// </summary>
        public string LastUpdatedBy { get; set; }
        /// <summary>
        /// The identity of the message's author.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Construct a new UpdateMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this message belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this message belongs to. </param>
        /// <param name="pathSid"> Key that uniquely defines the message to update. </param>
        public UpdateMessageOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (LastUpdatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("LastUpdatedBy", LastUpdatedBy));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            return p;
        }
    }

}