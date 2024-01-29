using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Kiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CP440 Major Project - Parking Lot Kiosk 
            //Created by Ryan Cloidt and Dezi Pehkonen 
            //Starting date - January 29, 2024 
            //CURRENT V1.0
        }
        public class Vehicle
        {
            //getting the fields from the user if they choose the car option 
            private string _vMake;
            private string _vModel;
            private string _vLicense;
            private int _vehicleCount;


            //creating the properties
            public string vMake;
            public string vModel;
            public string vLicense;
            public int vehicleCount;

            //creating the get and set properties 
            public string GS_vMake
            {
                get
                {
                    return _vMake;
                }
                set
                {
                    _vMake = value;
                }
            }

            //creating the GS for the vehicle model 
            public string GS_vModel
            {
                get
                {
                    return _vModel;
                }
                set
                {
                    _vModel = value;
                }
            }

            //creating the Get and Set for the Licence when getting information from the user 
            public string GS_vLicense
            {
                get
                {
                    return _vLicense;
                }
                set
                {
                    _vLicense = value;
                }
            }

            /*this property is going to be set only, 
             * this will make it so the user does not see 
             * the vehicle count, and is only being tracked 
             * by the program */
            
            public int S_vehicleCount
            {
                set
                {
                    _vehicleCount = value;
                }
            }

            //creating a perameterless constructor 
            public Vehicle()
            {
                
            }

        }
    }
}
