using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenAI.Files;
using OpenAI.FineTuning;
using System;
using System.ClientModel;
using System.IO;

namespace OpenAI.Tests.FineTuning
{
    [TestFixture]
    public class FineTuningClientTests
    {
        [Test]
        public void ClientDefaults()
        {
            var client = new FineTuningClient();
            Assert.IsNotNull(client);
        }

        [Test]
        public void ExceptionThrownOnInvalidFilename()
        {
            var client = new FineTuningClient();

            // Wrong filename will respond with http 400
            Assert.Throws<ClientResultException>(() =>
                client.CreateJob(training_file: "Invalid File Name", model: "gpt-3.5-turbo")
            );
        }

        [Test]
        public void CreateAndCancelJob()
        {
            var client = new FineTuningClient();

            var fileClient = new FileClient();
            string path = Path.Combine("Assets", "fine_tuning_sample.jsonl");

            OpenAIFileInfo file = fileClient.UploadFile(path, "fine-tune");

            try {
                var job = client.CreateJob(file.Id, "gpt-3.5-turbo");
                client.CancelJob(job.Id);
            } finally {
                fileClient.DeleteFile(file.Id);
            }
        }
    }
}