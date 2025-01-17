/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.FlexApi.V1
{

    /// <summary>
    /// FetchInteractionOptions
    /// </summary>
    public class FetchInteractionOptions : IOptions<InteractionResource>
    {
        /// <summary>
        /// The SID that identifies the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchInteractionOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        public FetchInteractionOptions(string pathSid)
        {
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
    /// Create a new Interaction.
    /// </summary>
    public class CreateInteractionOptions : IOptions<InteractionResource>
    {
        /// <summary>
        /// The Interaction's channel
        /// </summary>
        public object Channel { get; }
        /// <summary>
        /// The Interaction's routing logic
        /// </summary>
        public object Routing { get; }

        /// <summary>
        /// Construct a new CreateInteractionOptions
        /// </summary>
        /// <param name="channel"> The Interaction's channel </param>
        /// <param name="routing"> The Interaction's routing logic </param>
        public CreateInteractionOptions(object channel, object routing)
        {
            Channel = channel;
            Routing = routing;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Channel != null)
            {
                p.Add(new KeyValuePair<string, string>("Channel", Serializers.JsonObject(Channel)));
            }

            if (Routing != null)
            {
                p.Add(new KeyValuePair<string, string>("Routing", Serializers.JsonObject(Routing)));
            }

            return p;
        }
    }

}