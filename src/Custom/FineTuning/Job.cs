using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenAI.FineTuning;

public class Job
{
    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("created_at")]
    public long CreatedAt { get; set; }

    [JsonPropertyName("finished_at")]
    public long? FinishedAt { get; set; }

    [JsonPropertyName("fine_tuned_model")]
    public string FineTunedModel { get; set; }

    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }

    [JsonPropertyName("result_files")]
    public List<string> ResultFiles { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("validation_file")]
    public string ValidationFile { get; set; }

    [JsonPropertyName("training_file")]
    public string TrainingFile { get; set; }

    [JsonPropertyName("hyperparameters")]
    public Hyperparameters Hyperparameters { get; set; }

    [JsonPropertyName("trained_tokens")]
    public int? TrainedTokens { get; set; }

    [JsonPropertyName("error")]
    public Error Error { get; set; }

    [JsonPropertyName("user_provided_suffix")]
    public string UserProvidedSuffix { get; set; }

    [JsonPropertyName("seed")]
    public int Seed { get; set; }

    [JsonPropertyName("estimated_finish")]
    public long? EstimatedFinish { get; set; }

    [JsonPropertyName("integrations")]
    public List<string> Integrations { get; set; }
}
public class Hyperparameters
{
    [JsonPropertyName("n_epochs")]
    public string NEpochs { get; set; }

    [JsonPropertyName("batch_size")]
    public string BatchSize { get; set; }

    [JsonPropertyName("learning_rate_multiplier")]
    public string LearningRateMultiplier { get; set; }
}

public class Error
{
    // Define properties for error object if available
}