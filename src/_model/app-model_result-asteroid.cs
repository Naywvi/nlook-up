namespace masteroidResult{
    
    public class initAsteroidRMethods{
        private ARborders mARborders = new ARborders();
        private ARNameAsteroide mARNameAsteroide = new ARNameAsteroide();
        private ARDescriptionAsteroide mARInformationAboutUs = new ARDescriptionAsteroide();
        private ARDescriptionDistanceAsteroide mARInformationAboutUsDistances = new ARDescriptionDistanceAsteroide();
        private ARRecapAsteroide mARRecap = new ARRecapAsteroide();
        private ARDescAsteroide mADesc = new ARDescAsteroide();
        private AROrbitList mARList = new AROrbitList();
        private AROrbitVelocity mARVelocity = new AROrbitVelocity();
        private AROrbitMiss mARMiss = new AROrbitMiss();
        public List<Control?> initAsteroidR(){
            List<System.Windows.Forms.Control?> list = new List<System.Windows.Forms.Control?>();
            list.Add(this.mARNameAsteroide.ARName());

            list.Add(this.mARInformationAboutUs.ARSuspicious());
            list.Add(this.mARInformationAboutUs.ARMagnitude());
            list.Add(this.mARInformationAboutUs.ARUncertain());
            list.Add(this.mARInformationAboutUs.AREquinox());

            list.Add(this.mARInformationAboutUsDistances.ARkm());
            list.Add(this.mARInformationAboutUsDistances.ARml());
            list.Add(this.mARInformationAboutUsDistances.AestimHmax());
            list.Add(this.mARInformationAboutUsDistances.AestimHmin());
            list.Add(this.mARInformationAboutUsDistances.AestimSmax());
            list.Add(this.mARInformationAboutUsDistances.AestimSmin());

            list.Add(this.mARRecap.ARFirstOrbit());
            list.Add(this.mARRecap.ARLastOrbit());
            list.Add(this.mARRecap.ARFuturOrbit());
            list.Add(this.mARRecap.ARNumberOrbit());

            list.Add(this.mADesc.ARDescription());

            list.Add(this.mARList.AROrbitL());

            list.Add(this.mARVelocity.AROrbitV());
            list.Add(this.mARVelocity.AROrbitV2());
            list.Add(this.mARVelocity.AROrbitV3());
            list.Add(this.mARVelocity.AROrbitV4());

            list.Add(this.mARMiss.AROrbitM());
            list.Add(this.mARMiss.AROrbitM2());
            list.Add(this.mARMiss.AROrbitM3());
            list.Add(this.mARMiss.AROrbitM4());
            list.Add(this.mARMiss.AROrbitM5());

            list.Add(this.mARborders.ARborderTitle());
            list.Add(this.mARborders.ARborderInformationAboutUs());
            list.Add(this.mARborders.ARborderInformationAboutUsDistances());
            list.Add(this.mARborders.ARborderOrbits());
            list.Add(this.mARborders.ARborderDescription());
            list.Add(this.mARborders.ARborderInformationVelocity());
            list.Add(this.mARborders.ARborderInformationMiss());
            return list;
        }
    }
    //class ARborders for all borders _model
    public class ARborders{
        public Label ARborderTitle(){
            Label ARborderTitle = new Label();
            ARborderTitle.Location = new System.Drawing.Point(10,10);
            ARborderTitle.Size = new System.Drawing.Size(480,50);
            ARborderTitle.BorderStyle = BorderStyle.Fixed3D;
            return ARborderTitle;
        }
        public Label ARborderInformationAboutUs(){
            Label ARborderInformation = new Label();
            ARborderInformation.Location = new System.Drawing.Point(10,70);
            ARborderInformation.Size = new System.Drawing.Size(480,100);
            ARborderInformation.BorderStyle = BorderStyle.Fixed3D;
            return ARborderInformation;
        }
        public Label ARborderInformationAboutUsDistances(){
            Label ARborderAboutUs = new Label();
            ARborderAboutUs.Location = new System.Drawing.Point(500,10);
            ARborderAboutUs.Size = new System.Drawing.Size(480,160);
            ARborderAboutUs.BorderStyle = BorderStyle.Fixed3D;
            return ARborderAboutUs;
        }
        public Label ARborderOrbits(){
            Label ARborderOrbits = new Label();
            ARborderOrbits.Location = new System.Drawing.Point(10,180);
            ARborderOrbits.Size = new System.Drawing.Size(970,100);
            ARborderOrbits.BorderStyle = BorderStyle.Fixed3D;
            return ARborderOrbits;
        }
        public Label ARborderDescription(){
            Label ARborderDescription = new Label();
            ARborderDescription.Location = new System.Drawing.Point(10,290);
            ARborderDescription.Size = new System.Drawing.Size(970,100);
            ARborderDescription.BorderStyle = BorderStyle.Fixed3D;
            return ARborderDescription;
        }
        public Label ARborderInformationVelocity(){
            Label ARborderVelocity = new Label();
            ARborderVelocity.Location = new System.Drawing.Point(500,400);
            ARborderVelocity.Size = new System.Drawing.Size(480,125);
            ARborderVelocity.BorderStyle = BorderStyle.Fixed3D;
            return ARborderVelocity;
        }
        public Label ARborderInformationMiss(){
            Label ARborderMiss = new Label();
            ARborderMiss.Location = new System.Drawing.Point(500,535);
            ARborderMiss.Size = new System.Drawing.Size(480,125);
            ARborderMiss.BorderStyle = BorderStyle.Fixed3D;
            return ARborderMiss;
        }
    }
    // Label for asteroide name _model
    public class ARNameAsteroide{
        public Label ARName(){
            Label ARNameAsteroide = new Label();
            ARNameAsteroide.Location = new System.Drawing.Point(10,10);
            ARNameAsteroide.Size = new System.Drawing.Size(480,50);
            ARNameAsteroide.Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            ARNameAsteroide.Text = "Asteroid Name";
            ARNameAsteroide.TextAlign = ContentAlignment.MiddleCenter;
            ARNameAsteroide.BorderStyle = BorderStyle.Fixed3D;
            return ARNameAsteroide;
        }
    }
    // Label for asteroide description _model
    public class ARDescriptionAsteroide{
        public Label ARSuspicious(){
            Label ARSuspicious = new Label();
            ARSuspicious.Location = new System.Drawing.Point(20,80);
            ARSuspicious.Font = new System.Drawing.Font("Georgia", 8);
            ARSuspicious.Text = "Suspicious Asteroid ?";
            return ARSuspicious;
        }
        public Label ARMagnitude(){
            Label ARMagnitude = new Label();
            ARMagnitude.Location = new System.Drawing.Point(20,100);
            ARMagnitude.Font = new System.Drawing.Font("Georgia", 8);
            ARMagnitude.Text = "Magnitude";
            return ARMagnitude;
        }
        public Label ARUncertain(){
            Label ARUncertain = new Label();
            ARUncertain.Location = new System.Drawing.Point(20,120);
            ARUncertain.Font = new System.Drawing.Font("Georgia", 8);
            ARUncertain.Text = "Uncertain";
            return ARUncertain;
        }
        public Label AREquinox(){
            Label AREquinox = new Label();
            AREquinox.Location = new System.Drawing.Point(20,140);
            AREquinox.Font = new System.Drawing.Font("Georgia", 8);
            AREquinox.Text = "Equinox";
            return AREquinox;
        }
    }
    // Label for asteroide description _model
    public class ARDescriptionDistanceAsteroide{
        public RadioButton ARkm(){
            RadioButton ARkm = new RadioButton();
            ARkm.Location = new System.Drawing.Point(510,20);
            ARkm.Checked = true;
            ARkm.Size = new System.Drawing.Size(150,20);
            ARkm.Font = new System.Drawing.Font("Georgia", 8);
            ARkm.Text = "Scales in km";
            return ARkm;
        }
        public RadioButton ARml(){
            RadioButton ARml = new RadioButton();
            ARml.Location = new System.Drawing.Point(670,20);
            ARml.Size = new System.Drawing.Size(150,20);
            ARml.Font = new System.Drawing.Font("Georgia", 8);
            ARml.Text = "Scales in Miles";
            return ARml;
        }
        public Label AestimHmax(){
            Label estimHmax = new Label();
            estimHmax.Location = new System.Drawing.Point(510,80);
            estimHmax.Size = new System.Drawing.Size(460,20);
            estimHmax.Font = new System.Drawing.Font("Georgia", 8);
            estimHmax.Text = "Estimated km/h or miles/h MAX     : -----";
            return estimHmax;
        }
        public Label AestimHmin(){
            Label estimHmin = new Label();
            estimHmin.Location = new System.Drawing.Point(510,100);
            estimHmin.Size = new System.Drawing.Size(460,20);
            estimHmin.Font = new System.Drawing.Font("Georgia", 8);
            estimHmin.Text = "Estimated km/h or miles/h MIN      : -----";
            return estimHmin;
        }
        public Label AestimSmax(){
            Label estimSmax = new Label();
            estimSmax.Location = new System.Drawing.Point(510,120);
            estimSmax.Size = new System.Drawing.Size(460,20);
            estimSmax.Font = new System.Drawing.Font("Georgia", 8);
            estimSmax.Text = "Estimated km/s or miles/s MAX      : -----";
            return estimSmax;
        }
        public Label AestimSmin(){
            Label estimSmin = new Label();
            estimSmin.Location = new System.Drawing.Point(510,140);
            estimSmin.Size = new System.Drawing.Size(460,20);
            estimSmin.Font = new System.Drawing.Font("Georgia", 8);
            estimSmin.Text = "Estimated km/s or miles/s MIN       : -----";
            return estimSmin;
        }

    }
    // Label for Recap asteroide Orbit _model
    public class ARRecapAsteroide{
        public Label ARFirstOrbit(){
            Label ARFirst = new Label();
            ARFirst.Location = new System.Drawing.Point(20,190);
            ARFirst.Size = new System.Drawing.Size(800,20);
            ARFirst.Font = new System.Drawing.Font("Georgia", 8);
            ARFirst.Text = "First Observation                           : ----";
            return ARFirst;
        }
        public Label ARLastOrbit(){
            Label ARLast = new Label();
            ARLast.Location = new System.Drawing.Point(20,210);
            ARLast.Size = new System.Drawing.Size(800,20);
            ARLast.Font = new System.Drawing.Font("Georgia", 8);
            ARLast.Text = "Last Observation                            : ----";
            return ARLast;
        }
        public Label ARFuturOrbit(){
            Label ARNumber = new Label();
            ARNumber.Location = new System.Drawing.Point(20,230);
            ARNumber.Font = new System.Drawing.Font("Georgia", 8);
            ARNumber.Size = new System.Drawing.Size(800,20);
            ARNumber.Text = "Estimated futur Observation    : ----";
            return ARNumber;
        }
        public Label ARNumberOrbit(){
            Label ARNumber = new Label();
            ARNumber.Location = new System.Drawing.Point(20,250);
            ARNumber.Size = new System.Drawing.Size(800,20);
            ARNumber.Font = new System.Drawing.Font("Georgia", 8);
            ARNumber.Text = "Number of Observation              : ----";
            return ARNumber;
        }
    }
    // Label for Description asteroide _model
    public class ARDescAsteroide{
        private string _descriptionAsteroide = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. Cras elementum ultrices diam. Maecenas ligula massa, varius a, semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie, enim est eleifend mi, non fermentum diam nisl sit amet erat. Duis semper. Duis arcu massa, scelerisque vitae, consequat in, pretium a, enim.";
        public Label ARDescription(){
            Label ARDescriptionA = new Label();
            ARDescriptionA.Location = new System.Drawing.Point(20,300);
            ARDescriptionA.Size = new System.Drawing.Size(950,80);
            ARDescriptionA.Font = new System.Drawing.Font("Georgia", 10);
            ARDescriptionA.Text = this._descriptionAsteroide;
            ARDescriptionA.TextAlign = ContentAlignment.MiddleCenter;
            return ARDescriptionA;
        }
    }
    // List for Orbit asteroide _model
    public class AROrbitList{
        public ListBox AROrbitL(){
            ListBox list = new ListBox();
            list.Location = new Point(10 , 400);
            list.Size = new Size(480,260);
            list.BorderStyle = BorderStyle.Fixed3D;
            list.Font = new System.Drawing.Font("Georgia", 8);
            //generateOrbit(); //<---- depuis l'api
            list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");
            return list;
        }
    }
    // Label for Orbit asteroide _model
    public class AROrbitVelocity{
        public Label AROrbitV(){
            Label AROrbitV = new Label();
            AROrbitV.Location = new System.Drawing.Point(510,410);
            AROrbitV.Size = new System.Drawing.Size(460,20);
            AROrbitV.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitV.Text = "Date of Observation : ----";
            return AROrbitV;
        }
        public Label AROrbitV2(){
            Label AROrbitV2 = new Label();
            AROrbitV2.Location = new System.Drawing.Point(510,450);
            AROrbitV2.Size = new System.Drawing.Size(460,20);
            AROrbitV2.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitV2.Text = "Estimated km/h : ----";
            return AROrbitV2;
        }
        public Label AROrbitV3(){
            Label AROrbitV3 = new Label();
            AROrbitV3.Location = new System.Drawing.Point(510,470);
            AROrbitV3.Size = new System.Drawing.Size(460,20);
            AROrbitV3.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitV3.Text = "Estimated km/s : ----";
            return AROrbitV3;
        }
        public Label AROrbitV4(){
            Label AROrbitV4 = new Label();
            AROrbitV4.Location = new System.Drawing.Point(510,490);
            AROrbitV4.Size = new System.Drawing.Size(460,20);
            AROrbitV4.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitV4.Text = "Estimated miles/h : ----";
            return AROrbitV4;
        }
    }
    public class AROrbitMiss{
        public Label AROrbitM(){
            Label AROrbitM = new Label();
            AROrbitM.Location = new System.Drawing.Point(510,545);
            AROrbitM.Size = new System.Drawing.Size(460,20);
            AROrbitM.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitM.Text = "Miss Distance";
            return AROrbitM;
        }
        public Label AROrbitM2(){
            Label AROrbitM2 = new Label();
            AROrbitM2.Location = new System.Drawing.Point(510,570);
            AROrbitM2.Size = new System.Drawing.Size(460,20);
            AROrbitM2.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitM2.Text = "Astronom : ----";
            return AROrbitM2;
        }
        public Label AROrbitM3(){
            Label AROrbitM3 = new Label();
            AROrbitM3.Location = new System.Drawing.Point(510,590);
            AROrbitM3.Size = new System.Drawing.Size(460,20);
            AROrbitM3.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitM3.Text = "Lunar : ----";
            return AROrbitM3;
        }
        public Label AROrbitM4(){
            Label AROrbitM4 = new Label();
            AROrbitM4.Location = new System.Drawing.Point(510,610);
            AROrbitM4.Size = new System.Drawing.Size(460,20);
            AROrbitM4.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitM4.Text = "Kilometers : ----";
            return AROrbitM4;
        }
        public Label AROrbitM5(){
            Label AROrbitM5 = new Label();
            AROrbitM5.Location = new System.Drawing.Point(510,630);
            AROrbitM5.Size = new System.Drawing.Size(460,20);
            AROrbitM5.Font = new System.Drawing.Font("Georgia", 8);
            AROrbitM5.Text = "Miles : ----";
            return AROrbitM5;
        }
    }
}