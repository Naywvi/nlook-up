/***********************************************************************
* Here we will find the functions affecting the application itself.    *
* Whether it is for the modification of the tabs or the dynamism of    *
* the application itself. As well as all the properties comprising the *
* example application: the size, the title...                          *
***********************************************************************/
using config;
namespace application{
    partial class appnn{
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing){
            Application.Exit();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }
        
        public void InitializeComponent(){
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(conf.height, conf.width);

            //<< Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.Text = "nlook up";
            this.viewLoad();
        }

        public async void tabRequest(string rqst,string id = ""){
            application.appnn app = (application.appnn)Application.OpenForms[1];
            
            foreach(TabPage tab in app.dynamicTabControl.TabPages){
                if(tab.Name == "asteroidResult")app.dynamicTabControl.TabPages.Remove(pRAsteroid);
                else if(tab.Name == "apodResult")app.dynamicTabControl.TabPages.Remove(pRApod);
            }
            
            if(rqst == "asteroid"){
                await request.loadAsteroidRequest(id);
                loadTab("asteroid");
                app.dynamicTabControl.TabPages.Add(pRAsteroid);
            }else if (rqst == "apod"){
                loadTab("apod");
                app.dynamicTabControl.TabPages.Add(pRApod);
            }
        }

        public void loadTab(string request){
            if (request == "apod"){
                foreach(System.Windows.Forms.Control? method in mApodR.initApodR())pRApod.Controls.Add(method);
            }else if (request == "asteroid"){
                foreach(System.Windows.Forms.Control? method in mAsteroidR.initAsteroidR())pRAsteroid.Controls.Add(method);
            }else{
                throw new System.Exception("Invalid request");
            }
        }
        
    }
}