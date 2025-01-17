/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.FlexApi.V1.Interaction.InteractionChannel
{

    /// <summary>
    /// Invite an Agent or a TaskQueue to a Channel.
    /// </summary>
    public class CreateInteractionChannelInviteOptions : IOptions<InteractionChannelInviteResource>
    {
        /// <summary>
        /// The Interaction SID for this Channel
        /// </summary>
        public string PathInteractionSid { get; }
        /// <summary>
        /// The Channel SID for this Invite
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The Interaction's routing logic
        /// </summary>
        public object Routing { get; }

        /// <summary>
        /// Construct a new CreateInteractionChannelInviteOptions
        /// </summary>
        /// <param name="pathInteractionSid"> The Interaction SID for this Channel </param>
        /// <param name="pathChannelSid"> The Channel SID for this Invite </param>
        /// <param name="routing"> The Interaction's routing logic </param>
        public CreateInteractionChannelInviteOptions(string pathInteractionSid, string pathChannelSid, object routing)
        {
            PathInteractionSid = pathInteractionSid;
            PathChannelSid = pathChannelSid;
            Routing = routing;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Routing != null)
            {
                p.Add(new KeyValuePair<string, string>("Routing", Serializers.JsonObject(Routing)));
            }

            return p;
        }
    }

    /// <summary>
    /// List all Invites for a Channel.
    /// </summary>
    public class ReadInteractionChannelInviteOptions : ReadOptions<InteractionChannelInviteResource>
    {
        /// <summary>
        /// The Interaction SID for this Channel
        /// </summary>
        public string PathInteractionSid { get; }
        /// <summary>
        /// The Channel SID for this Participant
        /// </summary>
        public string PathChannelSid { get; }

        /// <summary>
        /// Construct a new ReadInteractionChannelInviteOptions
        /// </summary>
        /// <param name="pathInteractionSid"> The Interaction SID for this Channel </param>
        /// <param name="pathChannelSid"> The Channel SID for this Participant </param>
        public ReadInteractionChannelInviteOptions(string pathInteractionSid, string pathChannelSid)
        {
            PathInteractionSid = pathInteractionSid;
            PathChannelSid = pathChannelSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}