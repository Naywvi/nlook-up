/************************************************************************************
* Here we will find all the modifications that can be made to the final result.     *
* The impact is made on the model. We define the possible modifiers and then once   *
* the requests are received we assign the results.                                  *
************************************************************************************/
using System.Net;
namespace config{
    public class func{
        public static ListBox list = new ListBox();
        public static ListBox listOrbit = new ListBox();
        public static Label AROrbitV = new Label();
        public static Label AROrbitV2 = new Label();
        public static Label AROrbitV3 = new Label();
        public static Label AROrbitV4 = new Label();
        public static Label AROrbitM2 = new Label();
        public static Label AROrbitM3 = new Label();
        public static Label AROrbitM4 = new Label();
        public static Label AROrbitM5 = new Label();
        public static Label AROrbitM = new Label();


        public static Label ARNameAsteroide = new Label();
        public static Label ARSuspicious = new Label();
        public static Label ARMagnitude = new Label();
        public static Label ARUncertain = new Label();
        public static Label AREquinox = new Label();
        public static RadioButton ARkm = new RadioButton();
        public static RadioButton ARml = new RadioButton();
        public static Label estimSmin = new Label();
        public static Label estimSmax = new Label();
        public static Label estimHmin = new Label();
        public static Label estimHmax = new Label();
        public static Label ARFirst = new Label();
        public static Label ARLast = new Label();
        public static Label ARNumber = new Label();
        public static Label ARFutur= new Label();
        public static Label ARDescriptionA = new Label();

        public static ListBox listApod = new ListBox();
        public static Label apodPresentation = new Label();
        public static Label title = new Label();
        public static Label copyright = new Label();
        public static PictureBox img = new PictureBox();
        public static LinkLabel Dl1024 = new LinkLabel();
        public static LinkLabel Dl2048 = new LinkLabel();

        public static void addListAsteroid(){
            list.Items.Clear();
            foreach (var item in conf.result.near_earth_objects){
                foreach (var asteroid in item.Value){
                    list.Items.Add("id : "+ asteroid.id + " date : " + asteroid.close_approach_data[0].close_approach_date_full + " name : " + asteroid.name );
                }
            }
        }
        
        public static void addListAsteroidOrbit(){
            var count = -1;
            listOrbit.Items.Clear();
            foreach (var item in conf.resultAsteroid.close_approach_data){
                count++;
                listOrbit.Items.Add(count.ToString() + " - " + item.close_approach_date_full + " orbiting " + item.orbiting_body);
            }
        }
        public static void addListApod(){
            listApod.Items.Clear();
            var count = -1;
            
            foreach (var item in conf.result2){
                count++;
                listApod.Items.Add(count.ToString() + " - date : " + conf.result2[count].date + " name : " + conf.result2[count].title );
            }
            conf.apodArray = true;
        }
        public static void addListApodToday(){
            listApod.Items.Clear();
            listApod.Items.Add("0 - date : " + conf.result2.date + " name : " + conf.result2.title );
            conf.apodArray = false;
        }
        public static void getResultAsteroidOrbit(string idS){
            var id = int.Parse(idS);
            AROrbitV.Text = "Date of Observation : " + conf.resultAsteroid.close_approach_data[id].close_approach_date_full;
            AROrbitV2.Text = "Estimated velocity km/h : " + conf.resultAsteroid.close_approach_data[id].relative_velocity.kilometers_per_hour;
            AROrbitV3.Text = "Estimated velocity km/s : " + conf.resultAsteroid.close_approach_data[id].relative_velocity.kilometers_per_second;
            AROrbitV4.Text = "Estimated miles/h : " + conf.resultAsteroid.close_approach_data[id].relative_velocity.miles_per_hour;
            AROrbitM2.Text = "Astronom : " + conf.resultAsteroid.close_approach_data[id].miss_distance.astronomical;
            AROrbitM3.Text = "Lunar : " + conf.resultAsteroid.close_approach_data[id].miss_distance.lunar;
            AROrbitM4.Text = "Kilometers : " + conf.resultAsteroid.close_approach_data[id].miss_distance.kilometers;
            AROrbitM5.Text = "Miles : " + conf.resultAsteroid.close_approach_data[id].miss_distance.miles;
            AROrbitM.Text = "Miss Distance : ";
        }
        public static void getResultAsteroid(){
            ARDescriptionA.Text = "Description of " + conf.resultAsteroid.name.ToString() + " : " + conf.resultAsteroid.orbital_data.orbit_class.orbit_class_description.ToString();
            ARNumber.Text = "Number of observation of " + conf.resultAsteroid.name.ToString() + " : " + conf.resultAsteroid.orbital_data.observations_used.ToString() + " observations you can find them below";
            ARFutur.Text = "Estimated futur observation of " + conf.resultAsteroid.name.ToString() + " : " + conf.resultAsteroid.orbital_data.orbit_determination_date;
            ARLast.Text = "Last observation of " + conf.resultAsteroid.name.ToString() + " : " + conf.resultAsteroid.orbital_data.last_observation_date;
            ARFirst.Text = "First observation of " + conf.resultAsteroid.name.ToString() + " : " + conf.resultAsteroid.orbital_data.first_observation_date;
            AREquinox.Text = "Equinox : " + conf.resultAsteroid.orbital_data.equinox.ToString();
            ARUncertain.Text = "Uncertain : " + conf.resultAsteroid.orbital_data.orbit_uncertainty.ToString() + "%";
            ARMagnitude.Text = "Magnitude : " + conf.resultAsteroid.absolute_magnitude_h.ToString();

            ARkm.CheckedChanged += (sender, e) => {
                estimHmax.Text = "Estimated km/h MAX : " + conf.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_max;
                estimHmin.Text = "Estimated km/h MIN : " + conf.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_min;
                estimSmax.Text = "Estimated m/s MAX : " + conf.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
                estimSmin.Text = "Estimated m/s MIN : " + conf.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
            };
            if(ARkm.Checked == true ){
                estimHmax.Text = "Estimated km/h MAX : " + conf.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_max;
                estimHmin.Text = "Estimated km/h MIN : " + conf.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_min;
                estimSmax.Text = "Estimated m/s MAX : " + conf.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
                estimSmin.Text = "Estimated m/s MIN : " + conf.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
            };

            ARml.CheckedChanged += (sender, e) => {
                estimHmax.Text = "Estimated miles/h MAX : " + conf.resultAsteroid.estimated_diameter.miles.estimated_diameter_max;
                estimHmin.Text = "Estimated miles/h MIN : " + conf.resultAsteroid.estimated_diameter.miles.estimated_diameter_min;
                estimSmax.Text = "Estimated feet/s MAX : " + conf.resultAsteroid.estimated_diameter.feet.estimated_diameter_max;
                estimSmin.Text = "Estimated feet/s MIN : " + conf.resultAsteroid.estimated_diameter.feet.estimated_diameter_max;
            };

            if(conf.resultAsteroid.is_potentially_hazardous_asteroid.ToString() == "True")ARSuspicious.Text = conf.resultAsteroid.name.ToString() + " is a potentially hazardous asteroid";
            else ARSuspicious.Text = conf.resultAsteroid.name.ToString() + " is not a potentially hazardous asteroid";

            
            ARNameAsteroide.Text = conf.resultAsteroid.name.ToString();

            // Place to front to avoid bugs
            ARSuspicious.BringToFront();
            ARNameAsteroide.BringToFront();
            ARDescriptionA.BringToFront();
            ARNumber.BringToFront();
            ARLast.BringToFront();
            ARFutur.BringToFront();
            ARFirst.BringToFront();
            AREquinox.BringToFront();
            ARUncertain.BringToFront();
            ARMagnitude.BringToFront();
            ARkm.BringToFront();
            ARml.BringToFront();
            estimHmax.BringToFront();
            estimHmin.BringToFront();
            estimSmax.BringToFront();
            estimSmin.BringToFront();
            AROrbitV.BringToFront();
            AROrbitV2.BringToFront();
            AROrbitV3.BringToFront();
            AROrbitV4.BringToFront();
            AROrbitM.BringToFront();
            AROrbitM2.BringToFront();
            AROrbitM3.BringToFront();
            AROrbitM4.BringToFront();
            AROrbitM5.BringToFront();
        }
        public static void getResultApod(int id){
            if (conf.apodArray == false){
                apodPresentation.Text = "Astronomy Picture of the Day - " + conf.result2.date;
                title.Text = "Explanation : " + conf.result2.explanation;
                copyright.Text = "copyright : " + conf.result2.copyright;//exemple copyright
                img.LoadAsync(conf.result2.url.ToString());//Image
                Dl1024.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => {
                    WebClient client = new WebClient();
                    client.DownloadFileAsync(new Uri(conf.result2.url.ToString()), conf.result2.date.ToString() + "-" + conf.result2.title.ToString() + "_1024.jpg");
                });
                Dl2048.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => {
                    WebClient client = new WebClient();
                    client.DownloadFileAsync(new Uri(conf.result2.hdurl.ToString()), conf.result2.date.ToString() + "-" + conf.result2.title.ToString() + "_2048.jpg");
                });
            }else{
                apodPresentation.Text = "Astronomy Picture of the Day - " + conf.result2[id].date;
                title.Text = "Explanation : " + conf.result2[id].explanation;
                copyright.Text = "copyright : " + conf.result2[id].copyright;//exemple copyright
                img.LoadAsync(conf.result2[id].url.ToString());//Image
                Dl1024.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => {
                    WebClient client = new WebClient();
                    client.DownloadFileAsync(new Uri(conf.result2[id].url.ToString()), conf.result2[id].date.ToString() + "-" + conf.result2[id].title.ToString() + "_1024.jpg");
                });
                Dl2048.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => {
                    WebClient client = new WebClient();
                    client.DownloadFileAsync(new Uri(conf.result2[id].hdurl.ToString()), conf.result2[id].date.ToString() + "-" + conf.result2.title[id].ToString() + "_2048.jpg");
                });
            }
        }
    }
}