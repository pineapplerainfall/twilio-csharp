/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Verify.V2
{

    /// <summary>
    /// Get a summary of how many attempts were made and how many were converted.
    /// </summary>
    public class FetchVerificationAttemptsSummaryOptions : IOptions<VerificationAttemptsSummaryResource>
    {
        /// <summary>
        /// Filter the verification attempts considered on the summary by verify service.
        /// </summary>
        public string ServiceSid { get; set; }
        /// <summary>
        /// Consider verification attempts create after this date on the summary.
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }
        /// <summary>
        /// Consider verification attempts created before this date on the summary.
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }
        /// <summary>
        /// Filter verification attempts considered on the summary by destination country.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Filter verification attempts considered on the summary by communication channel.
        /// </summary>
        public VerificationAttemptsSummaryResource.ChannelsEnum Channel { get; set; }
        /// <summary>
        /// Filters the attempts considered on the summary by destination prefix.
        /// </summary>
        public string DestinationPrefix { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ServiceSid", ServiceSid.ToString()));
            }

            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }

            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }

            if (Country != null)
            {
                p.Add(new KeyValuePair<string, string>("Country", Country.ToString()));
            }

            if (Channel != null)
            {
                p.Add(new KeyValuePair<string, string>("Channel", Channel.ToString()));
            }

            if (DestinationPrefix != null)
            {
                p.Add(new KeyValuePair<string, string>("DestinationPrefix", DestinationPrefix));
            }

            return p;
        }
    }

}