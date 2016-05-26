using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Creators;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Trunking.V1.Trunk;

namespace Twilio.Creators.Trunking.V1.Trunk {

    public class PhoneNumberCreator : Creator<PhoneNumberResource> {
        private string trunkSid;
        private string phoneNumberSid;
    
        /**
         * Construct a new PhoneNumberCreator
         * 
         * @param trunkSid The trunk_sid
         * @param phoneNumberSid The phone_number_sid
         */
        public PhoneNumberCreator(string trunkSid, string phoneNumberSid) {
            this.trunkSid = trunkSid;
            this.phoneNumberSid = phoneNumberSid;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created PhoneNumberResource
         */
        public override async Task<PhoneNumberResource> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                Domains.TRUNKING,
                "/v1/Trunks/" + this.trunkSid + "/PhoneNumbers"
            );
            
            addPostParams(request);
            Response response = await client.RequestAsync(request);
            
            if (response == null) {
                throw new ApiConnectionException("PhoneNumberResource creation failed: Unable to connect to server");
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
            
            return PhoneNumberResource.FromJson(response.GetContent());
        }
        #endif
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created PhoneNumberResource
         */
        public override PhoneNumberResource Execute(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                Domains.TRUNKING,
                "/v1/Trunks/" + this.trunkSid + "/PhoneNumbers"
            );
            
            addPostParams(request);
            Response response = client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("PhoneNumberResource creation failed: Unable to connect to server");
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
            
            return PhoneNumberResource.FromJson(response.GetContent());
        }
        #endif
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (phoneNumberSid != "") {
                request.AddPostParam("PhoneNumberSid", phoneNumberSid);
            }
        }
    }
}