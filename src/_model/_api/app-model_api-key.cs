/*******************************************************************************************************************
* Here we will find all the properties containing the visual which will allow us to check if the API code is valid *
*******************************************************************************************************************/
using System.Net;
namespace mApiKey{
    // Api methods for _model
    public class initApiKeyMethods{
        private mApi api = new mApi();
        // List all methods for api _model
        public List<System.Windows.Forms.Control?> initApiKey(){
            List<System.Windows.Forms.Control?> list = new List<System.Windows.Forms.Control?>();
            list.Add(api.labelApiKey());
            list.Add(api.inputApiKey());
            list.Add(api.buttonApiKey());
            list.Add(api.linkApiKey());
            list.Add(api.bordersApiKey());
            return list;
        }
    }

    // Api _model
    public class mApi : Form{
        public TextBox inputApiKeyTxt = new TextBox();
        static readonly HttpClient client = new HttpClient();
        public Label bordersApiKey(){
            var bordersApiKey = new Label();
            bordersApiKey.Location = new Point(20,20);
            bordersApiKey.Size = new Size(460,160);
            bordersApiKey.BorderStyle = BorderStyle.FixedSingle;
            return bordersApiKey;
        }
        public Label labelApiKey(){
            var labelApiKey = new Label();
            labelApiKey.Location = new Point(30,40);
            labelApiKey.Size = new Size(440,20);
            labelApiKey.Text = "You must enter a valid API code to continue";
            labelApiKey.TextAlign = ContentAlignment.MiddleCenter;
            labelApiKey.Font = new Font("Georgia", 10); 
            return labelApiKey;
        }
        public TextBox inputApiKey(){
            inputApiKeyTxt.Location = new Point(30,70);
            inputApiKeyTxt.Size = new Size(440,20);
            inputApiKeyTxt.PlaceholderText = "Example input : mifpl44sFpir16or6CazdeOdr16ofey10KTXZfJr17Fr";
            return inputApiKeyTxt;
        }
        //Button to submit api key _model
        public Button buttonApiKey(){
            var buttonApiKey = new Button();
            buttonApiKey.Location = new Point(30,130);
            buttonApiKey.Size = new Size(440,40);
            buttonApiKey.Text = "Submit";
            buttonApiKey.Click += new EventHandler((sender, e) => {
                var input = inputApiKeyTxt.Text;
                try{
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.nasa.gov/planetary/apod?api_key=" + input);
                    HttpWebResponse requestC = (HttpWebResponse)request.GetResponse();
                    if (requestC.StatusCode == HttpStatusCode.OK){
                        vApi.api app = (vApi.api)Application.OpenForms[0];
                        app.apikeyValid(input);
                    }
                }catch(WebException){
                    MessageBox.Show("Invalid API key, or is it a connection issue ?");
                }
                

            });
            return buttonApiKey;
        }
        // ApiKey link in browser _model
        public LinkLabel linkApiKey(){
            var linkLabel = new LinkLabel();
            linkLabel.Location = new Point(30,100);
            linkLabel.Size = new Size(440,20);
            linkLabel.Text = "Get your API code";
            linkLabel.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel.Font = new Font("Georgia", 10);
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => {
                var parameter = new System.Diagnostics.ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://api.nasa.gov/" };
                System.Diagnostics.Process.Start(parameter);
            });
            return linkLabel;
        }
    }
}