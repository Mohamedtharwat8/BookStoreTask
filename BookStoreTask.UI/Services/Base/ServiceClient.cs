﻿ 
    namespace BookStoreTask.UI.Services
    {
        using System = global::System;

        [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial interface IClient
        {
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest body);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest body,
                System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<RegistrationResponse> RegisterAsync(RegistrationRequest body);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<RegistrationResponse> RegisterAsync(RegistrationRequest body,
                System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CategoryListVm>> GetAllCategoriesAsync();

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CategoryListVm>> GetAllCategoriesAsync(
                System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CategoryBookListVm>> GetCategoriesWithBooksAsync(bool? includeHistory);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CategoryBookListVm>> GetCategoriesWithBooksAsync(
                bool? includeHistory, 
                System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<CreateCategoryCommandResponse> AddCategoryAsync(CreateCategoryCommand body);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<CreateCategoryCommandResponse> AddCategoryAsync(
                CreateCategoryCommand body, 
                System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BookListVm>> GetAllBooksAsync();

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BookListVm>> GetAllBooksAsync(
                System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Guid> AddBookAsync(CreateBookCommand body);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<System.Guid> AddBookAsync(
                CreateBookCommand body,
                System.Threading.CancellationToken cancellationToken);

            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task UpdateBookAsync(UpdateBookCommand body);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task UpdateBookAsync(
                UpdateBookCommand body
                , System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<BookDetailVm> GetBookByIdAsync(
                System.Guid id);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<BookDetailVm> GetBookByIdAsync(
                System.Guid id,
                System.Threading.CancellationToken cancellationToken);

            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task DeleteBookAsync(System.Guid id);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task DeleteBookAsync(
                System.Guid id,
                System.Threading.CancellationToken cancellationToken);

            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<FileResponse> ExportBooksAsync();

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<FileResponse> ExportBooksAsync(
                System.Threading.CancellationToken cancellationToken);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<PagedOrdersForMonthVm> GetPagedOrdersForMonthAsync(
                System.DateTime? date, int? page, int? size);

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            System.Threading.Tasks.Task<PagedOrdersForMonthVm> GetPagedOrdersForMonthAsync(
                System.DateTime? date, int? page, int? size,
                System.Threading.CancellationToken cancellationToken);

        }

        [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class Client : IClient
        {
            private System.Net.Http.HttpClient _httpClient;
            private System.Lazy<System.Text.Json.JsonSerializerOptions> _settings;

            public Client(System.Net.Http.HttpClient httpClient)
            {
                _httpClient = httpClient;
                _settings = new System.Lazy<System.Text.Json.JsonSerializerOptions>(CreateSerializerSettings);
            }

            private System.Text.Json.JsonSerializerOptions CreateSerializerSettings()
            {
                var settings = new System.Text.Json.JsonSerializerOptions();
                UpdateJsonSerializerSettings(settings);
                return settings;
            }

            protected System.Text.Json.JsonSerializerOptions JsonSerializerSettings { get { return _settings.Value; } }

            partial void UpdateJsonSerializerSettings(System.Text.Json.JsonSerializerOptions settings);

            partial void PrepareRequest(System.Net.Http.HttpClient client, 
                System.Net.Http.HttpRequestMessage request, string url);
            partial void PrepareRequest(System.Net.Http.HttpClient client,
                System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
            partial void ProcessResponse(System.Net.Http.HttpClient client,
                System.Net.Http.HttpResponseMessage response);

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<AuthenticationResponse> AuthenticateAsync(
                AuthenticationRequest body)
            {
                return AuthenticateAsync(body, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<AuthenticationResponse> AuthenticateAsync(
                AuthenticationRequest body, System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Account/authenticate");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        var json_ = System.Text.Json.JsonSerializer.Serialize(body, _settings.Value);
                        var content_ = new System.Net.Http.StringContent(json_);
                        content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                        request_.Content = content_;
                        request_.Method = new System.Net.Http.HttpMethod("POST");
                        request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<AuthenticationResponse>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.",
                                        status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var responseData_ = response_.Content == null ? null 
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                throw new ApiException("The HTTP status code of the response was not expected (" +
                                    status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<RegistrationResponse> RegisterAsync(
                RegistrationRequest body)
            {
                return RegisterAsync(body, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<RegistrationResponse> RegisterAsync(
                RegistrationRequest body, System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Account/register");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        var json_ = System.Text.Json.JsonSerializer.Serialize(
                            body, _settings.Value);
                        var content_ = new System.Net.Http.StringContent(json_);
                        content_.Headers.ContentType = 
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                        request_.Content = content_;
                        request_.Method = new System.Net.Http.HttpMethod("POST");
                        request_.Headers.Accept.Add(
                            System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(
                            request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                            cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(
                                response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<RegistrationResponse>(
                                    response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.",
                                        status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var responseData_ = response_.Content == null ? null 
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                throw new ApiException("The HTTP status code of the response was not expected (" +
                                    status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CategoryListVm>> GetAllCategoriesAsync()
            {
                return GetAllCategoriesAsync(System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<
                System.Collections.Generic.ICollection<CategoryListVm>> GetAllCategoriesAsync(
                System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Category/all");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        request_.Method = new System.Net.Http.HttpMethod("GET");
                        request_.Headers.Accept.Add(
                            System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                            cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<
                                    System.Collections.Generic.ICollection<CategoryListVm>>(response_,
                                    headers_,
                                    cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.",
                                        status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var responseData_ = response_.Content == null ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                throw new ApiException("The HTTP status code of the response was not expected (" +
                                    status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CategoryBookListVm>> 
            GetCategoriesWithBooksAsync(bool? includeHistory)
            {
                return GetCategoriesWithBooksAsync(includeHistory, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CategoryBookListVm>> 
            GetCategoriesWithBooksAsync(bool? includeHistory, System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Category/allwithBooks?");
                if (includeHistory != null)
                {
                    urlBuilder_.Append(System.Uri.EscapeDataString("includeHistory") + "=")
                    .Append(System.Uri.EscapeDataString(ConvertToString(includeHistory,
                    System.Globalization.CultureInfo.InvariantCulture))).Append("&");
                }
                urlBuilder_.Length--;

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        request_.Method = new System.Net.Http.HttpMethod("GET");
                        request_.Headers.Accept.Add(
                            System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                            cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ =
                                await ReadObjectResponseAsync<System.Collections.Generic
                                .ICollection<CategoryBookListVm>>(
                                    response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.",
                                        status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var objectResponse_ = 
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.",
                                        status_, objectResponse_.Text, headers_, null);
                                }
                                throw new ApiException<ProblemDetails>(
                                    "Error", status_, objectResponse_.Text,
                                    headers_, objectResponse_.Object, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<CreateCategoryCommandResponse> AddCategoryAsync(CreateCategoryCommand body)
            {
                return AddCategoryAsync(body, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<CreateCategoryCommandResponse> AddCategoryAsync(
                CreateCategoryCommand body, System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Category");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        var json_ = System.Text.Json.JsonSerializer.Serialize(body, _settings.Value);
                        var content_ = new System.Net.Http.StringContent(json_);
                        content_.Headers.ContentType = 
                        System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                        request_.Content = content_;
                        request_.Method = new System.Net.Http.HttpMethod("POST");
                        request_.Headers.Accept.Add(
                            System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(
                            request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, 
                            cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ =
                                await ReadObjectResponseAsync<CreateCategoryCommandResponse>(
                                    response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException(
                                        "Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var responseData_ = response_.Content == null ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                throw new ApiException("The HTTP status code of the response was not expected (" +
                                    status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BookListVm>> GetAllBooksAsync()
            {
                return GetAllBooksAsync(System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<BookListVm>> GetAllBooksAsync(System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Books");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        request_.Method = new System.Net.Http.HttpMethod("GET");
                        request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(
                            request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                            cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<BookListVm>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<System.Guid> AddBookAsync(CreateBookCommand body)
            {
                return AddBookAsync(body, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<System.Guid> AddBookAsync(CreateBookCommand body, System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Books");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        var json_ = System.Text.Json.JsonSerializer.Serialize(body, _settings.Value);
                        var content_ = new System.Net.Http.StringContent(json_);
                        content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                        request_.Content = content_;
                        request_.Method = new System.Net.Http.HttpMethod("POST");
                        request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<System.Guid>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task UpdateBookAsync(UpdateBookCommand body)
            {
                return UpdateBookAsync(body, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task UpdateBookAsync(UpdateBookCommand body, System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Books");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        var json_ = System.Text.Json.JsonSerializer.Serialize(body, _settings.Value);
                        var content_ = new System.Net.Http.StringContent(json_);
                        content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                        request_.Content = content_;
                        request_.Method = new System.Net.Http.HttpMethod("PUT");

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 204)
                            {
                                return;
                            }
                            else
                            if (status_ == 404)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                            }
                            else
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<BookDetailVm> GetBookByIdAsync(System.Guid id)
            {
                return GetBookByIdAsync(id, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<BookDetailVm> GetBookByIdAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
            {
                if (id == null)
                    throw new System.ArgumentNullException("id");

                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Books/{id}");
                urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        request_.Method = new System.Net.Http.HttpMethod("GET");
                        request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<BookDetailVm>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task DeleteBookAsync(System.Guid id)
            {
                return DeleteBookAsync(id, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>No Content</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task DeleteBookAsync(System.Guid id, System.Threading.CancellationToken cancellationToken)
            {
                if (id == null)
                    throw new System.ArgumentNullException("id");

                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Books/{id}");
                urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        request_.Method = new System.Net.Http.HttpMethod("DELETE");

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 204)
                            {
                                return;
                            }
                            else
                            if (status_ == 404)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                            }
                            else
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<FileResponse> ExportBooksAsync()
            {
                return ExportBooksAsync(System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<FileResponse> ExportBooksAsync(System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("api/Books/export");

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        request_.Method = new System.Net.Http.HttpMethod("GET");
                        request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/csv"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200 || status_ == 206)
                            {
                                var responseStream_ = response_.Content == null ? System.IO.Stream.Null : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                                var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                                disposeClient_ = false; disposeResponse_ = false; // response and client are disposed by FileResponse
                                return fileResponse_;
                            }
                            else
                            {
                                var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual System.Threading.Tasks.Task<PagedOrdersForMonthVm> GetPagedOrdersForMonthAsync(System.DateTime? date, int? page, int? size)
            {
                return GetPagedOrdersForMonthAsync(date, page, size, System.Threading.CancellationToken.None);
            }

            /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
            /// <returns>Success</returns>
            /// <exception cref="ApiException">A server side error occurred.</exception>
            public virtual async System.Threading.Tasks.Task<PagedOrdersForMonthVm> GetPagedOrdersForMonthAsync(System.DateTime? date, int? page, int? size, System.Threading.CancellationToken cancellationToken)
            {
                var urlBuilder_ = new System.Text.StringBuilder();
                urlBuilder_.Append("getpagedordersformonth?");
                if (date != null)
                {
                    urlBuilder_.Append(System.Uri.EscapeDataString("date") + "=").Append(System.Uri.EscapeDataString(date.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
                }
                if (page != null)
                {
                    urlBuilder_.Append(System.Uri.EscapeDataString("page") + "=").Append(System.Uri.EscapeDataString(ConvertToString(page, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
                }
                if (size != null)
                {
                    urlBuilder_.Append(System.Uri.EscapeDataString("size") + "=").Append(System.Uri.EscapeDataString(ConvertToString(size, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
                }
                urlBuilder_.Length--;

                var client_ = _httpClient;
                var disposeClient_ = false;
                try
                {
                    using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                        request_.Method = new System.Net.Http.HttpMethod("GET");
                        request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                            if (response_.Content != null && response_.Content.Headers != null)
                            {
                                foreach (var item_ in response_.Content.Headers)
                                    headers_[item_.Key] = item_.Value;
                            }

                            ProcessResponse(client_, response_);

                            var status_ = (int)response_.StatusCode;
                            if (status_ == 200)
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<PagedOrdersForMonthVm>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                return objectResponse_.Object;
                            }
                            else
                            {
                                var objectResponse_ = await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken).ConfigureAwait(false);
                                if (objectResponse_.Object == null)
                                {
                                    throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                                throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                            }
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
                finally
                {
                    if (disposeClient_)
                        client_.Dispose();
                }
            }

            protected struct ObjectResponseResult<T>
            {
                public ObjectResponseResult(T responseObject, string responseText)
                {
                    this.Object = responseObject;
                    this.Text = responseText;
                }

                public T Object { get; }

                public string Text { get; }
            }

            public bool ReadResponseAsString { get; set; }

            protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
            {
                if (response == null || response.Content == null)
                {
                    return new ObjectResponseResult<T>(default(T), string.Empty);
                }

                if (ReadResponseAsString)
                {
                    var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    try
                    {
                        var typedBody = System.Text.Json.JsonSerializer.Deserialize<T>(responseText, JsonSerializerSettings);
                        return new ObjectResponseResult<T>(typedBody, responseText);
                    }
                    catch (System.Text.Json.JsonException exception)
                    {
                        var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                        throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                    }
                }
                else
                {
                    try
                    {
                        using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                        {
                            var typedBody = await System.Text.Json.JsonSerializer.DeserializeAsync<T>(responseStream, JsonSerializerSettings, cancellationToken).ConfigureAwait(false);
                            return new ObjectResponseResult<T>(typedBody, string.Empty);
                        }
                    }
                    catch (System.Text.Json.JsonException exception)
                    {
                        var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                        throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                    }
                }
            }

            private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
            {
                if (value == null)
                {
                    return "";
                }

                if (value is System.Enum)
                {
                    var name = System.Enum.GetName(value.GetType(), value);
                    if (name != null)
                    {
                        var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                        if (field != null)
                        {
                            var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                                as System.Runtime.Serialization.EnumMemberAttribute;
                            if (attribute != null)
                            {
                                return attribute.Value != null ? attribute.Value : name;
                            }
                        }

                        var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                        return converted == null ? string.Empty : converted;
                    }
                }
                else if (value is bool)
                {
                    return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
                }
                else if (value is byte[])
                {
                    return System.Convert.ToBase64String((byte[])value);
                }
                else if (value.GetType().IsArray)
                {
                    var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                    return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
                }

                var result = System.Convert.ToString(value, cultureInfo);
                return result == null ? "" : result;
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class AuthenticationRequest
        {

            [System.Text.Json.Serialization.JsonPropertyName("email")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Email { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("password")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Password { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class AuthenticationResponse
        {

            [System.Text.Json.Serialization.JsonPropertyName("id")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Id { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("userName")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string UserName { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("email")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Email { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("token")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Token { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CategoryDto
        {

            [System.Text.Json.Serialization.JsonPropertyName("id")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid Id { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CategoryBookDto
        {

            [System.Text.Json.Serialization.JsonPropertyName("BookId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid BookId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("price")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int Price { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("artist")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Artist { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("date")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.DateTime Date { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("categoryId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid CategoryId { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CategoryBookListVm
        {

            [System.Text.Json.Serialization.JsonPropertyName("categoryId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid CategoryId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("Books")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Collections.Generic.ICollection<CategoryBookDto> Books { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CategoryListVm
        {

            [System.Text.Json.Serialization.JsonPropertyName("categoryId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid CategoryId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CreateCategoryCommand
        {

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CreateCategoryCommandResponse
        {

            [System.Text.Json.Serialization.JsonPropertyName("success")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public bool Success { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("message")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Message { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("validationErrors")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("category")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public CreateCategoryDto Category { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CreateCategoryDto
        {

            [System.Text.Json.Serialization.JsonPropertyName("categoryId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid CategoryId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class CreateBookCommand
        {

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("price")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int Price { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("artist")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Artist { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("date")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.DateTime Date { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("description")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Description { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("imageUrl")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string ImageUrl { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("categoryId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid CategoryId { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class BookDetailVm
        {

            [System.Text.Json.Serialization.JsonPropertyName("BookId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid BookId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("price")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int Price { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("artist")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Artist { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("date")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.DateTime Date { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("description")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Description { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("imageUrl")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string ImageUrl { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("categoryId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid CategoryId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("category")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public CategoryDto Category { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class BookListVm
        {

            [System.Text.Json.Serialization.JsonPropertyName("BookId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid BookId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("date")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.DateTime Date { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("imageUrl")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string ImageUrl { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class OrdersForMonthDto
        {

            [System.Text.Json.Serialization.JsonPropertyName("id")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid Id { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("orderTotal")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int OrderTotal { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("orderPlaced")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.DateTime OrderPlaced { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class PagedOrdersForMonthVm
        {

            [System.Text.Json.Serialization.JsonPropertyName("count")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int Count { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("page")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int Page { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("size")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int Size { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("ordersForMonth")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Collections.Generic.ICollection<OrdersForMonthDto> OrdersForMonth { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class ProblemDetails
        {

            [System.Text.Json.Serialization.JsonPropertyName("type")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Type { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("title")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Title { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("status")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int? Status { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("detail")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Detail { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("instance")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Instance { get; set; }

            private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

            [System.Text.Json.Serialization.JsonExtensionData]
            public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
            {
                get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
                set { _additionalProperties = value; }
            }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class RegistrationRequest
        {

            [System.Text.Json.Serialization.JsonPropertyName("firstName")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]
            [System.ComponentModel.DataAnnotations.Required]
            public string FirstName { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("lastName")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]
            [System.ComponentModel.DataAnnotations.Required]
            public string LastName { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("email")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]
            [System.ComponentModel.DataAnnotations.Required]
            public string Email { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("userName")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 6)]
            public string UserName { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("password")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 6)]
            public string Password { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class RegistrationResponse
        {

            [System.Text.Json.Serialization.JsonPropertyName("userId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string UserId { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class UpdateBookCommand
        {

            [System.Text.Json.Serialization.JsonPropertyName("BookId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid BookId { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("name")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Name { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("price")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public int Price { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("artist")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Artist { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("date")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.DateTime Date { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("description")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string Description { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("imageUrl")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public string ImageUrl { get; set; }

            [System.Text.Json.Serialization.JsonPropertyName("categoryId")]

            [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]
            public System.Guid CategoryId { get; set; }

        }

        [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class FileResponse : System.IDisposable
        {
            private System.IDisposable _client;
            private System.IDisposable _response;

            public int StatusCode { get; private set; }

            public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

            public System.IO.Stream Stream { get; private set; }

            public bool IsPartial
            {
                get { return StatusCode == 206; }
            }

            public FileResponse(int statusCode, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.IO.Stream stream, System.IDisposable client, System.IDisposable response)
            {
                StatusCode = statusCode;
                Headers = headers;
                Stream = stream;
                _client = client;
                _response = response;
            }

            public void Dispose()
            {
                Stream.Dispose();
                if (_response != null)
                    _response.Dispose();
                if (_client != null)
                    _client.Dispose();
            }
        }


        [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class ApiException : System.Exception
        {
            public int StatusCode { get; private set; }

            public string Response { get; private set; }

            public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

            public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
                : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
            {
                StatusCode = statusCode;
                Response = response;
                Headers = headers;
            }

            public override string ToString()
            {
                return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
        public partial class ApiException<TResult> : ApiException
        {
            public TResult Result { get; private set; }

            public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
                : base(message, statusCode, response, headers, innerException)
            {
                Result = result;
            }
        }

    }

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore 472
#pragma warning restore 114
#pragma warning restore 108
#pragma warning restore 3016
#pragma warning restore 8603