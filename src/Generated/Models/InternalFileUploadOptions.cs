// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;

namespace OpenAI.Files
{
    internal partial class InternalFileUploadOptions
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalFileUploadOptions(Stream file, FileUploadPurpose purpose, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            File = file;
            Purpose = purpose;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}