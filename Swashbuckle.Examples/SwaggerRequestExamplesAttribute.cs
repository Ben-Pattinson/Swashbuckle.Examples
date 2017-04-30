﻿using System;

namespace Swashbuckle.Examples
{
    /// <summary>
    /// Adds example requests to your controller endpoints.
    /// See https://mattfrear.com/2016/01/25/generating-swagger-example-requests-with-swashbuckle/
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class SwaggerRequestExamplesAttribute : Attribute
    {
        public SwaggerRequestExamplesAttribute(Type requestType, Type examplesProviderType)
        {
            RequestType = requestType;
            ExamplesProviderType = examplesProviderType;
        }

        public Type ExamplesProviderType { get; private set; }

        public Type RequestType { get; private set; }
    }
}