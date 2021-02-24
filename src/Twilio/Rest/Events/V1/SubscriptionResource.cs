/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// SubscriptionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Events.V1
{

    public class SubscriptionResource : Resource
    {
        private static Request BuildReadRequest(ReadSubscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                "/v1/Subscriptions",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieve a paginated list of Subscriptions belonging to the account used to make the request.
        /// </summary>
        /// <param name="options"> Read Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static ResourceSet<SubscriptionResource> Read(ReadSubscriptionOptions options,
                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SubscriptionResource>.FromJson("subscriptions", response.Content);
            return new ResourceSet<SubscriptionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a paginated list of Subscriptions belonging to the account used to make the request.
        /// </summary>
        /// <param name="options"> Read Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SubscriptionResource>> ReadAsync(ReadSubscriptionOptions options,
                                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SubscriptionResource>.FromJson("subscriptions", response.Content);
            return new ResourceSet<SubscriptionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a paginated list of Subscriptions belonging to the account used to make the request.
        /// </summary>
        /// <param name="sinkSid"> Sink SID. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static ResourceSet<SubscriptionResource> Read(string sinkSid = null,
                                                             int? pageSize = null,
                                                             long? limit = null,
                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSubscriptionOptions(){SinkSid = sinkSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a paginated list of Subscriptions belonging to the account used to make the request.
        /// </summary>
        /// <param name="sinkSid"> Sink SID. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SubscriptionResource>> ReadAsync(string sinkSid = null,
                                                                                                     int? pageSize = null,
                                                                                                     long? limit = null,
                                                                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSubscriptionOptions(){SinkSid = sinkSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SubscriptionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SubscriptionResource>.FromJson("subscriptions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SubscriptionResource> NextPage(Page<SubscriptionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Events)
            );

            var response = client.Request(request);
            return Page<SubscriptionResource>.FromJson("subscriptions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SubscriptionResource> PreviousPage(Page<SubscriptionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Events)
            );

            var response = client.Request(request);
            return Page<SubscriptionResource>.FromJson("subscriptions", response.Content);
        }

        private static Request BuildFetchRequest(FetchSubscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific Subscription.
        /// </summary>
        /// <param name="options"> Fetch Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static SubscriptionResource Fetch(FetchSubscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Subscription.
        /// </summary>
        /// <param name="options"> Fetch Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<SubscriptionResource> FetchAsync(FetchSubscriptionOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Subscription.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Subscription. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static SubscriptionResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSubscriptionOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Subscription.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Subscription. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<SubscriptionResource> FetchAsync(string pathSid,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new FetchSubscriptionOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateSubscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                "/v1/Subscriptions",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Subscription.
        /// </summary>
        /// <param name="options"> Create Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static SubscriptionResource Create(CreateSubscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Subscription.
        /// </summary>
        /// <param name="options"> Create Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<SubscriptionResource> CreateAsync(CreateSubscriptionOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Subscription.
        /// </summary>
        /// <param name="description"> Subscription description </param>
        /// <param name="sinkSid"> Sink SID. </param>
        /// <param name="types"> Subscribed Event Types </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static SubscriptionResource Create(string description,
                                                  string sinkSid,
                                                  List<object> types,
                                                  ITwilioRestClient client = null)
        {
            var options = new CreateSubscriptionOptions(description, sinkSid, types);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Subscription.
        /// </summary>
        /// <param name="description"> Subscription description </param>
        /// <param name="sinkSid"> Sink SID. </param>
        /// <param name="types"> Subscribed Event Types </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<SubscriptionResource> CreateAsync(string description,
                                                                                          string sinkSid,
                                                                                          List<object> types,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new CreateSubscriptionOptions(description, sinkSid, types);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateSubscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Update a Subscription.
        /// </summary>
        /// <param name="options"> Update Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static SubscriptionResource Update(UpdateSubscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a Subscription.
        /// </summary>
        /// <param name="options"> Update Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<SubscriptionResource> UpdateAsync(UpdateSubscriptionOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a Subscription.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Subscription. </param>
        /// <param name="description"> Subscription description. </param>
        /// <param name="sinkSid"> Sink SID. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static SubscriptionResource Update(string pathSid,
                                                  string description = null,
                                                  string sinkSid = null,
                                                  ITwilioRestClient client = null)
        {
            var options = new UpdateSubscriptionOptions(pathSid){Description = description, SinkSid = sinkSid};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a Subscription.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Subscription. </param>
        /// <param name="description"> Subscription description. </param>
        /// <param name="sinkSid"> Sink SID. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<SubscriptionResource> UpdateAsync(string pathSid,
                                                                                          string description = null,
                                                                                          string sinkSid = null,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new UpdateSubscriptionOptions(pathSid){Description = description, SinkSid = sinkSid};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSubscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Events,
                "/v1/Subscriptions/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Delete a specific Subscription.
        /// </summary>
        /// <param name="options"> Delete Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static bool Delete(DeleteSubscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Subscription.
        /// </summary>
        /// <param name="options"> Delete Subscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSubscriptionOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Subscription.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Subscription. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Subscription </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSubscriptionOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Subscription.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Subscription. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Subscription </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSubscriptionOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SubscriptionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SubscriptionResource object represented by the provided JSON </returns>
        public static SubscriptionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SubscriptionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Account SID.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this Subscription.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The date this Subscription was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Subscription was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Subscription description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// Sink SID.
        /// </summary>
        [JsonProperty("sink_sid")]
        public string SinkSid { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private SubscriptionResource()
        {

        }
    }

}