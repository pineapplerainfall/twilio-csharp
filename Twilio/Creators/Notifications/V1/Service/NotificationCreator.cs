using System.Collections.Generic;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Creators;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Notifications.V1.Service;

namespace Twilio.Creators.Notifications.V1.Service {

    public class NotificationCreator : Creator<NotificationResource> {
        private string serviceSid;
        private List<string> identity;
        private List<string> tag;
        private string body;
        private string priority;
        private int? ttl;
        private string title;
        private string sound;
        private string action;
        private string data;
        private string apn;
        private string gcm;
    
        /**
         * Construct a new NotificationCreator
         * 
         * @param serviceSid The service_sid
         */
        public NotificationCreator(string serviceSid) {
            this.serviceSid = serviceSid;
        }
    
        /**
         * The identity
         * 
         * @param identity The identity
         * @return this
         */
        public NotificationCreator setIdentity(List<string> identity) {
            this.identity = identity;
            return this;
        }
    
        /**
         * The identity
         * 
         * @param identity The identity
         * @return this
         */
        public NotificationCreator setIdentity(string identity) {
            return setIdentity(Promoter.ListOfOne(identity));
        }
    
        /**
         * The tag
         * 
         * @param tag The tag
         * @return this
         */
        public NotificationCreator setTag(List<string> tag) {
            this.tag = tag;
            return this;
        }
    
        /**
         * The tag
         * 
         * @param tag The tag
         * @return this
         */
        public NotificationCreator setTag(string tag) {
            return setTag(Promoter.ListOfOne(tag));
        }
    
        /**
         * The body
         * 
         * @param body The body
         * @return this
         */
        public NotificationCreator setBody(string body) {
            this.body = body;
            return this;
        }
    
        /**
         * The priority
         * 
         * @param priority The priority
         * @return this
         */
        public NotificationCreator setPriority(string priority) {
            this.priority = priority;
            return this;
        }
    
        /**
         * The ttl
         * 
         * @param ttl The ttl
         * @return this
         */
        public NotificationCreator setTtl(int? ttl) {
            this.ttl = ttl;
            return this;
        }
    
        /**
         * The title
         * 
         * @param title The title
         * @return this
         */
        public NotificationCreator setTitle(string title) {
            this.title = title;
            return this;
        }
    
        /**
         * The sound
         * 
         * @param sound The sound
         * @return this
         */
        public NotificationCreator setSound(string sound) {
            this.sound = sound;
            return this;
        }
    
        /**
         * The action
         * 
         * @param action The action
         * @return this
         */
        public NotificationCreator setAction(string action) {
            this.action = action;
            return this;
        }
    
        /**
         * The data
         * 
         * @param data The data
         * @return this
         */
        public NotificationCreator setData(string data) {
            this.data = data;
            return this;
        }
    
        /**
         * The apn
         * 
         * @param apn The apn
         * @return this
         */
        public NotificationCreator setApn(string apn) {
            this.apn = apn;
            return this;
        }
    
        /**
         * The gcm
         * 
         * @param gcm The gcm
         * @return this
         */
        public NotificationCreator setGcm(string gcm) {
            this.gcm = gcm;
            return this;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created NotificationResource
         */
        public override async Task<NotificationResource> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                Domains.NOTIFICATIONS,
                "/v1/Services/" + this.serviceSid + "/Notifications"
            );
            
            addPostParams(request);
            Response response = await client.RequestAsync(request);
            
            if (response == null) {
                throw new ApiConnectionException("NotificationResource creation failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_CREATED) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return NotificationResource.FromJson(response.GetContent());
        }
        #endif
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created NotificationResource
         */
        public override NotificationResource Execute(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                Domains.NOTIFICATIONS,
                "/v1/Services/" + this.serviceSid + "/Notifications"
            );
            
            addPostParams(request);
            Response response = client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("NotificationResource creation failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_CREATED) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return NotificationResource.FromJson(response.GetContent());
        }
        #endif
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (identity != null) {
                request.AddPostParam("Identity", identity.ToString());
            }
            
            if (tag != null) {
                request.AddPostParam("Tag", tag.ToString());
            }
            
            if (body != "") {
                request.AddPostParam("Body", body);
            }
            
            if (priority != "") {
                request.AddPostParam("Priority", priority);
            }
            
            if (ttl != null) {
                request.AddPostParam("Ttl", ttl.ToString());
            }
            
            if (title != "") {
                request.AddPostParam("Title", title);
            }
            
            if (sound != "") {
                request.AddPostParam("Sound", sound);
            }
            
            if (action != "") {
                request.AddPostParam("Action", action);
            }
            
            if (data != "") {
                request.AddPostParam("Data", data);
            }
            
            if (apn != "") {
                request.AddPostParam("Apn", apn);
            }
            
            if (gcm != "") {
                request.AddPostParam("Gcm", gcm);
            }
        }
    }
}