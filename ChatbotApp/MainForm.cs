using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatbotApp
{
    public partial class MainForm : Form
    {
        private const string ApiKey = "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";
        private const string ApiUrl = "https://api.openai.com/v1/chat/completions";

        private readonly HttpClient client;

        public MainForm()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");  
        }
        private async Task<string> GetChatGPTReply(string userMessage)
        {
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
            new { role = "user", content = userMessage }
        }
            };
            var requestBodyJson = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(requestBodyJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(ApiUrl, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic responseData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);

            if (responseData != null && responseData.choices != null && responseData.choices.Count > 0)
            {
                var chatGptReply = responseData.choices[0]?.message?.content?.ToString();
                if (!string.IsNullOrEmpty(chatGptReply))
                {
                    return chatGptReply;
                }
            }

            throw new InvalidOperationException($"Invalid response from ChatGPT API. Response: {responseContent}");
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var userMessage = txtUserInput.Text.Trim();
            if (!string.IsNullOrEmpty(userMessage))
            {
                txtBotOutput.AppendText("You: " + userMessage + Environment.NewLine);
                txtUserInput.Clear();

                var chatGptReply = await GetChatGPTReply(userMessage);
                txtBotOutput.AppendText("ChatGPT: " + chatGptReply + Environment.NewLine);
            }
        }
    }
}