/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Api.V2010.Account.Sip.CredentialList;

namespace Twilio.Tests.Rest.Api.V2010.Account.Sip.CredentialList
{

    [TestFixture]
    public class CredentialTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SIP/CredentialLists/CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Credentials.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CredentialResource.Read("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"credentials\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"credential_list_sid\": \"CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"date_updated\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials/CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\",\"username\": \"1440013725.28\"}],\"end\": 0,\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials.json?PageSize=50&Page=0\",\"next_page_uri\": null,\"page\": 0,\"page_size\": 50,\"previous_page_uri\": null,\"start\": 0,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials.json?PageSize=50&Page=0\"}"
                                     ));

            var response = CredentialResource.Read("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"credentials\": [],\"end\": 0,\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials.json?PageSize=50&Page=0\",\"next_page_uri\": null,\"page\": 0,\"page_size\": 50,\"previous_page_uri\": null,\"start\": 0,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials.json?PageSize=50&Page=0\"}"
                                     ));

            var response = CredentialResource.Read("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SIP/CredentialLists/CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Credentials.json",
                ""
            );
            request.AddPostParam("Username", Serialize("username"));
            request.AddPostParam("Password", Serialize("password"));
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CredentialResource.Create("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "username", "password", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"credential_list_sid\": \"CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"date_updated\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials/CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\",\"username\": \"1440013725.28\"}"
                                     ));

            var response = CredentialResource.Create("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "username", "password", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SIP/CredentialLists/CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Credentials/CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CredentialResource.Fetch("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"credential_list_sid\": \"CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"date_updated\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials/CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\",\"username\": \"1440013725.28\"}"
                                     ));

            var response = CredentialResource.Fetch("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SIP/CredentialLists/CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Credentials/CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CredentialResource.Update("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"credential_list_sid\": \"CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"date_updated\": \"Wed, 19 Aug 2015 19:48:45 +0000\",\"sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SIP/CredentialLists/CLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Credentials/CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\",\"username\": \"username\"}"
                                     ));

            var response = CredentialResource.Update("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SIP/CredentialLists/CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Credentials/CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CredentialResource.Delete("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = CredentialResource.Delete("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "CRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}