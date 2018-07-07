// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ServiceAccountTokenProjection represents a projected service account
    /// token volume. This projection can be used to insert a service account
    /// token into the pods runtime filesystem for use against APIs (Kubernetes
    /// API Server or otherwise).
    /// </summary>
    public partial class V1ServiceAccountTokenProjection
    {
        /// <summary>
        /// Initializes a new instance of the V1ServiceAccountTokenProjection
        /// class.
        /// </summary>
        public V1ServiceAccountTokenProjection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ServiceAccountTokenProjection
        /// class.
        /// </summary>
        /// <param name="path">Path is the path relative to the mount point of
        /// the file to project the token into.</param>
        /// <param name="audience">Audience is the intended audience of the
        /// token. A recipient of a token must identify itself with an
        /// identifier specified in the audience of the token, and otherwise
        /// should reject the token. The audience defaults to the identifier of
        /// the apiserver.</param>
        /// <param name="expirationSeconds">ExpirationSeconds is the requested
        /// duration of validity of the service account token. As the token
        /// approaches expiration, the kubelet volume plugin will proactively
        /// rotate the service account token. The kubelet will start trying to
        /// rotate the token if the token is older than 80 percent of its time
        /// to live or if the token is older than 24 hours.Defaults to 1 hour
        /// and must be at least 10 minutes.</param>
        public V1ServiceAccountTokenProjection(string path, string audience = default(string), long? expirationSeconds = default(long?))
        {
            Audience = audience;
            ExpirationSeconds = expirationSeconds;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets audience is the intended audience of the token. A
        /// recipient of a token must identify itself with an identifier
        /// specified in the audience of the token, and otherwise should reject
        /// the token. The audience defaults to the identifier of the
        /// apiserver.
        /// </summary>
        [JsonProperty(PropertyName = "audience")]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or sets expirationSeconds is the requested duration of
        /// validity of the service account token. As the token approaches
        /// expiration, the kubelet volume plugin will proactively rotate the
        /// service account token. The kubelet will start trying to rotate the
        /// token if the token is older than 80 percent of its time to live or
        /// if the token is older than 24 hours.Defaults to 1 hour and must be
        /// at least 10 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "expirationSeconds")]
        public long? ExpirationSeconds { get; set; }

        /// <summary>
        /// Gets or sets path is the path relative to the mount point of the
        /// file to project the token into.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
        }
    }
}
