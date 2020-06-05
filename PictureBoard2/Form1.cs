using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoard2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDoubleClick(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            var openFileWindow = new OpenFileDialog();
            if (openFileWindow.ShowDialog() == DialogResult.OK)
            {

                HttpClient webApiClient = new HttpClient();
                webApiClient.BaseAddress = new Uri("http://89.67.144.106:9150");
                var pictureBytes = File.ReadAllBytes(openFileWindow.FileName);
                var pictureString = Convert.ToBase64String(pictureBytes);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(new Picture() { Id = pictureBox.Name, Content = pictureString });
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                webApiClient.PostAsync("/api/Picture", content);


            }
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Image = GetPictureFor("p1");
            P2.Image = GetPictureFor("p2");
            P3.Image = GetPictureFor("p3");
            P4.Image = GetPictureFor("p4");
            P5.Image = GetPictureFor("p5");
            P6.Image = GetPictureFor("p6");

        }
        private Image GetPictureFor(string value)
        {
            HttpClient webApiClient = new HttpClient();
            webApiClient.BaseAddress = new Uri("http://89.67.144.106:9150");
            var pictureString = webApiClient.GetStringAsync("/api/Picture/" + value).Result;
            var pictureObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Picture>(pictureString);
            if (pictureObj == null) return null;
            var pictureContent = pictureObj.Content;
            var pictureBytes = Convert.FromBase64String(pictureContent);
            MemoryStream ms = new MemoryStream(pictureBytes);
            ms.Position = 0;
            return Image.FromStream(ms);
        }
        public class Picture
        {
            public string Id { get; set; }
            public string Content { get; set; }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as PictureBox;
            var openFileWindow = new OpenFileDialog();
            if (openFileWindow.ShowDialog() == DialogResult.OK)
            {

                HttpClient webApiClient = new HttpClient();
                webApiClient.BaseAddress = new Uri("http://89.67.144.106:9150");
                var pictureBytes = File.ReadAllBytes(openFileWindow.FileName);
                var pictureString = Convert.ToBase64String(pictureBytes);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(new Picture() { Id = pictureBox.Name, Content = pictureString });
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                webApiClient.PostAsync("/api/Picture", content);


            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            P1.Image = GetPictureFor("p1");
            P2.Image = GetPictureFor("p2");
            P3.Image = GetPictureFor("p3");
            P4.Image = GetPictureFor("p4");
            P5.Image = GetPictureFor("p5");
            P6.Image = GetPictureFor("p6");
        }
    }
}