﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api
{
    public class JwtIssuerOptions
    {
        public string Issuer { get; set; }

        public string Subject { get; set; }

        public string Audience { get; set; }

        public DateTime Expiration => IssuedAt.Add(ValidFor);

        public DateTime NotBefore { get; set; } = DateTime.UtcNow;

        public DateTime IssuedAt { get; set; } = DateTime.UtcNow;

        public TimeSpan ValidFor { get; set; } = TimeSpan.FromMinutes(5);

        public Func<Task<string>> JtiGenerator =>
            () => Task.FromResult(Guid.NewGuid().ToString());

        public SigningCredentials SigningCredentials { get; set; }
    }
}
