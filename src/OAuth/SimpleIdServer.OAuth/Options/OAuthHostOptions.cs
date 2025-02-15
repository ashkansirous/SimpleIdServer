﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Jwt.Jws.Handlers;
using SimpleIdServer.OAuth.Api.Token.TokenProfiles;
using SimpleIdServer.OAuth.Domains;
using System.Collections.Generic;

namespace SimpleIdServer.OAuth.Options
{
    public class OAuthHostOptions
    {
        public OAuthHostOptions()
        {
            DefaultScopes = new List<string>();
            DefaultTokenProfile = BearerTokenProfile.DEFAULT_NAME;
            ClientSecretExpirationInSeconds = null;
            SoftwareStatementTrustedParties = new List<SoftwareStatementTrustedParty>();
            AuthorizationCodeExpirationInSeconds = 10 * 60;
            MtlsEnabled = false;
            CertificateAuthenticationScheme = "Certificate";
            DefaultTokenSignedResponseAlg = RSA256SignHandler.ALG_NAME;
            JWKExpirationTimeInSeconds = 60 * 5;
            DefaultTokenExpirationTimeInSeconds= 60 * 30;
            DefaultRefreshTokenExpirationTimeInSeconds = 60 * 30;
            HOTPWindow = 5;
            TOTPStep = 30;
            OTPAlg = OTPAlgs.TOTP;
            OTPIssuer = "SimpleIdServer";
            IsScopeClaimConcatenationEnabled = false;
        }

        /// <summary>
        /// OAUTH2.0 client's default scopes.
        /// </summary>
        public ICollection<string> DefaultScopes { get; set; }
        /// <summary>
        /// OAUTH2.0 client's default token profile.
        /// </summary>
        public string DefaultTokenProfile { get; set; }
        /// <summary>
        /// Client secret expiration time in seconds.
        /// </summary>
        public int? ClientSecretExpirationInSeconds { get; set; }
        /// <summary>
        /// Authorization cod expiration time in seconds.
        /// </summary>
        public int AuthorizationCodeExpirationInSeconds { get; set; }
        /// <summary>
        /// Trusted parties used to validate the software statement.
        /// </summary>
        public ICollection<SoftwareStatementTrustedParty> SoftwareStatementTrustedParties { get; set; }
        /// <summary>
        /// Mututal TLS is enabled.
        /// </summary>
        public bool MtlsEnabled { get; set; }
        /// <summary>
        /// Client certificate authentication scheme.
        /// </summary>
        public string CertificateAuthenticationScheme { get; set; }
        /// <summary>
        /// Default token signed response algorithm.
        /// </summary>
        public string DefaultTokenSignedResponseAlg { get; set; }
        /// <summary>
        /// JWK expiration time in seconds.
        /// </summary>
        public int JWKExpirationTimeInSeconds { get; set; }
        /// <summary>
        /// Default Token Expiration Time in seconds.
        /// </summary>
        public int DefaultTokenExpirationTimeInSeconds { get; set; }
        /// <summary>
        /// Default Refresh Token Expiration Time in seconds.
        /// </summary>
        public int DefaultRefreshTokenExpirationTimeInSeconds { get; set; }
        /// <summary>
        /// HOTP Window.
        /// </summary>
        public int HOTPWindow { get; set; }
        /// <summary>
        /// Calculate time windows.
        /// </summary>
        public int TOTPStep { get; set; }
        /// <summary>
        /// Default OTP algorithm.
        /// </summary>
        public OTPAlgs OTPAlg { get; set; }
        /// <summary>
        /// Default OTP issuer.
        /// </summary>
        public string OTPIssuer { get; set; }
        /// <summary>
        /// If true then "scope" claim is expressed as a list of space-delimited case sensistive strings"
        /// If false then "scope" claim is expressed as an array of string.
        /// </summary>
        public bool IsScopeClaimConcatenationEnabled { get; set; }
    }
}