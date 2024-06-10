// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class ChatCompletionOptions
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal ChatCompletionOptions(IList<ChatMessage> messages, InternalCreateChatCompletionRequestModel model, float? frequencyPenalty, IDictionary<int, int> logitBiases, bool? includeLogProbabilities, int? topLogProbabilityCount, int? maxTokens, int? n, float? presencePenalty, ChatResponseFormat responseFormat, long? seed, IList<string> stopSequences, bool? stream, InternalChatCompletionStreamOptions streamOptions, float? temperature, float? topP, IList<ChatTool> tools, ChatToolChoice toolChoice, string user, ChatFunctionChoice functionChoice, IList<ChatFunction> functions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Messages = messages;
            Model = model;
            FrequencyPenalty = frequencyPenalty;
            LogitBiases = logitBiases;
            IncludeLogProbabilities = includeLogProbabilities;
            TopLogProbabilityCount = topLogProbabilityCount;
            MaxTokens = maxTokens;
            N = n;
            PresencePenalty = presencePenalty;
            ResponseFormat = responseFormat;
            Seed = seed;
            StopSequences = stopSequences;
            Stream = stream;
            StreamOptions = streamOptions;
            Temperature = temperature;
            TopP = topP;
            Tools = tools;
            ToolChoice = toolChoice;
            User = user;
            FunctionChoice = functionChoice;
            Functions = functions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        public float? FrequencyPenalty { get; init; }
        public int? MaxTokens { get; init; }
        public float? PresencePenalty { get; init; }
        public ChatResponseFormat ResponseFormat { get; init; }
        public long? Seed { get; init; }
        public float? Temperature { get; init; }
        public float? TopP { get; init; }
        public string User { get; init; }
        public IList<ChatFunction> Functions { get; }
    }
}
