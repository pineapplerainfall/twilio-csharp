/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// MediaRecordingResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Media.V1
{

    public class MediaRecordingResource : Resource
    {
        public sealed class FormatEnum : StringEnum
        {
            private FormatEnum(string value) : base(value) {}
            public FormatEnum() {}
            public static implicit operator FormatEnum(string value)
            {
                return new FormatEnum(value);
            }

            public static readonly FormatEnum Mp4 = new FormatEnum("mp4");
            public static readonly FormatEnum Webm = new FormatEnum("webm");
        }

        public sealed class OrderEnum : StringEnum
        {
            private OrderEnum(string value) : base(value) {}
            public OrderEnum() {}
            public static implicit operator OrderEnum(string value)
            {
                return new OrderEnum(value);
            }

            public static readonly OrderEnum Asc = new OrderEnum("asc");
            public static readonly OrderEnum Desc = new OrderEnum("desc");
        }

        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Deleted = new StatusEnum("deleted");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        private static Request BuildDeleteRequest(DeleteMediaRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Media,
                "/v1/MediaRecordings/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Deletes a MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="options"> Delete MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static bool Delete(DeleteMediaRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Deletes a MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="options"> Delete MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMediaRecordingOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Deletes a MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteMediaRecordingOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Deletes a MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteMediaRecordingOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchMediaRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                "/v1/MediaRecordings/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Returns a single MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="options"> Fetch MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static MediaRecordingResource Fetch(FetchMediaRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns a single MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="options"> Fetch MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<MediaRecordingResource> FetchAsync(FetchMediaRecordingOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns a single MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static MediaRecordingResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchMediaRecordingOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a single MediaRecording resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<MediaRecordingResource> FetchAsync(string pathSid,
                                                                                           ITwilioRestClient client = null)
        {
            var options = new FetchMediaRecordingOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadMediaRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                "/v1/MediaRecordings",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Returns a list of MediaRecordings.
        /// </summary>
        /// <param name="options"> Read MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static ResourceSet<MediaRecordingResource> Read(ReadMediaRecordingOptions options,
                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
            return new ResourceSet<MediaRecordingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of MediaRecordings.
        /// </summary>
        /// <param name="options"> Read MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaRecordingResource>> ReadAsync(ReadMediaRecordingOptions options,
                                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
            return new ResourceSet<MediaRecordingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Returns a list of MediaRecordings.
        /// </summary>
        /// <param name="order"> The sort order of the list </param>
        /// <param name="status"> Status to filter by </param>
        /// <param name="processorSid"> MediaProcessor to filter by </param>
        /// <param name="sourceSid"> Source SID to filter by </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static ResourceSet<MediaRecordingResource> Read(MediaRecordingResource.OrderEnum order = null,
                                                               MediaRecordingResource.StatusEnum status = null,
                                                               string processorSid = null,
                                                               string sourceSid = null,
                                                               int? pageSize = null,
                                                               long? limit = null,
                                                               ITwilioRestClient client = null)
        {
            var options = new ReadMediaRecordingOptions(){Order = order, Status = status, ProcessorSid = processorSid, SourceSid = sourceSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of MediaRecordings.
        /// </summary>
        /// <param name="order"> The sort order of the list </param>
        /// <param name="status"> Status to filter by </param>
        /// <param name="processorSid"> MediaProcessor to filter by </param>
        /// <param name="sourceSid"> Source SID to filter by </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaRecordingResource>> ReadAsync(MediaRecordingResource.OrderEnum order = null,
                                                                                                       MediaRecordingResource.StatusEnum status = null,
                                                                                                       string processorSid = null,
                                                                                                       string sourceSid = null,
                                                                                                       int? pageSize = null,
                                                                                                       long? limit = null,
                                                                                                       ITwilioRestClient client = null)
        {
            var options = new ReadMediaRecordingOptions(){Order = order, Status = status, ProcessorSid = processorSid, SourceSid = sourceSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<MediaRecordingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<MediaRecordingResource> NextPage(Page<MediaRecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Media)
            );

            var response = client.Request(request);
            return Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<MediaRecordingResource> PreviousPage(Page<MediaRecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Media)
            );

            var response = client.Request(request);
            return Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a MediaRecordingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MediaRecordingResource object represented by the provided JSON </returns>
        public static MediaRecordingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MediaRecordingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The duration of the MediaRecording
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; private set; }
        /// <summary>
        /// The format of the MediaRecording
        /// </summary>
        [JsonProperty("format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaRecordingResource.FormatEnum Format { get; private set; }
        /// <summary>
        /// The URLs of related resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The SID of the MediaProcessor
        /// </summary>
        [JsonProperty("processor_sid")]
        public string ProcessorSid { get; private set; }
        /// <summary>
        /// The dimensions of the video image in pixels
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; private set; }
        /// <summary>
        /// The SID of the resource that generated the original media
        /// </summary>
        [JsonProperty("source_sid")]
        public string SourceSid { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The size of the recording media
        /// </summary>
        [JsonProperty("media_size")]
        public long? MediaSize { get; private set; }
        /// <summary>
        /// The status of the MediaRecording
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaRecordingResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The URL to which Twilio will send MediaRecording event updates
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The HTTP method Twilio should use to call the `status_callback` URL
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private MediaRecordingResource()
        {

        }
    }

}