﻿//   Copyright © 2009-2020 John Sheehan, Andrew Young, Alexey Zimarev and RestSharp community
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

using System;
using JetBrains.Annotations;

namespace RestSharp
{
    /// <summary>
    /// Representation of an HTTP header
    /// </summary>
    [PublicAPI]
    public class HttpHeader
    {
        /// <summary>
        /// Creates a new instance of HttpHeader
        /// </summary>
        /// <param name="name">Header name</param>
        /// <param name="value">Header value</param>
        public HttpHeader(string name, string? value)
        {
            Name  = name;
            Value = value ?? "";
        }

        /// <summary>
        /// Creates a new instance of HttpHeader with value conversion
        /// </summary>
        /// <param name="name">Header name</param>
        /// <param name="value">Header value, which has to implement ToString() properly</param>
        public HttpHeader(string name, object? value) : this(name, value?.ToString()) { }

        /// <summary>
        /// Creates a new instance of HttpHeader. Remember to assign properties!
        /// </summary>
        [Obsolete("Use parameterized constructor")]
        public HttpHeader() { }

        /// <summary>
        /// Name of the header
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the header
        /// </summary>
        public string Value { get; set; }
    }
}
