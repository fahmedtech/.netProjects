using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Name: Faizan Ahmed
Collaborated with Miguel Ramirez
IT330 Final Project
Video Game Library Application
*/

namespace Final_Ahmed.Models
{
    public class VideoGame
    {
        //** read and write properties for VideoGame **

        //Primary Key 
        public int ID { get; set; }

        //values assigned from Textbox controls in MainWindow.xaml
        public String Title { get; set; }
        public String Year { get; set; }
        public String Developers { get; set; }
        public String ImageName { get; set; }

        //values assigned from ComboBox and RadioButton controls in MainWindow.xaml
        public String Rating { get; set; }
        public String Platform { get; set; }
        public String Genre { get; set; }
    }
}
