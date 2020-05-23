﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSoulsStatCalc
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            // Protector = CSV.Read("ObjectData/Protector.csv");
            // Rings = CSV.Read("ObjectData/Rings.csv");
            // Weapons = CSV.Read("ObjectData/Weapons.csv");
        }

        public void LoadRings()
        {
            string path = System.IO.Path.GetFullPath("rings.csv");
            List<Ring> RingList1 = new List<Ring>();
            List<Ring> RingList2 = new List<Ring>();
            List<Ring> RingList3 = new List<Ring>();
            List<Ring> RingList4 = new List<Ring>();

            using (StreamReader reader = new StreamReader(path)) // Used to read file data
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split the line by the tab so that both columns are separated
                    string[] values = line.Split(',');

                    // set the properties of the item and parse the value string to float
                    string name = values[0];
                    float weight = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);

                    //Ring
                    Ring ring = new Ring();
                    ring.Name = name;
                    ring.Weight = weight;
                    RingList1.Add(ring);
                    RingList2.Add(ring);
                    RingList3.Add(ring);
                    RingList4.Add(ring);
                }
            }

            //Ring Combobox1
            rings1.DataSource = RingList1;
            rings1.DisplayMember = "Name";
            rings1.ValueMember = "Weight";
            rings1.SelectedItem = null;
            rings1.SelectedIndex = 0;

            ///Ring Combobox2
            rings2.DataSource = RingList2;
            rings2.DisplayMember = "Name";
            rings2.ValueMember = "Weight";
            rings2.SelectedItem = null;
            rings2.SelectedIndex = 0;

            //Ring Combobox3
            rings3.DataSource = RingList3;
            rings3.DisplayMember = "Name";
            rings3.ValueMember = "Weight";
            rings3.SelectedItem = null;
            rings3.SelectedIndex = 0;

            //Ring Combobox4
            rings4.DataSource = RingList4;
            rings4.DisplayMember = "Name";
            rings4.ValueMember = "Weight";
            rings4.SelectedItem = null;
            rings4.SelectedIndex = 0;
        }

        public void LoadWeapons()
        {
            List<weapon> weaponList1 = new List<weapon>();
            List<weapon> weaponList2 = new List<weapon>();
            List<weapon> weaponList3 = new List<weapon>();
            List<weapon> weaponList4 = new List<weapon>();
            List<weapon> weaponList5 = new List<weapon>();
            List<weapon> weaponList6 = new List<weapon>();

            string path = System.IO.Path.GetFullPath("weapons.csv");

            using (StreamReader reader = new StreamReader(path)) // Used to read file data
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split the line by the tab so that both columns are separated
                    string[] values = line.Split(',');

                    // set the properties of the item and parse the value string to float
                    string name = values[0];
                    float weight = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);

                    //Weapon
                    weapon weapon = new weapon();
                    weapon.Name = name;
                    weapon.Weight = weight;
                    weaponList1.Add(weapon);
                    weaponList2.Add(weapon);
                    weaponList3.Add(weapon);
                    weaponList4.Add(weapon);
                    weaponList5.Add(weapon);
                    weaponList6.Add(weapon);
                }
            }

            //Lweapon1
            Lweapon1.DataSource = weaponList1;
            Lweapon1.DisplayMember = "Name";
            Lweapon1.ValueMember = "Weight";
            Lweapon1.SelectedItem = null;
            Lweapon1.SelectedIndex = 0;

            //Lweapon2
            Lweapon2.DataSource = weaponList2;
            Lweapon2.DisplayMember = "Name";
            Lweapon2.ValueMember = "Weight";
            Lweapon2.SelectedItem = null;
            Lweapon2.SelectedIndex = 0;

            //Lweapon3
            Lweapon3.DataSource = weaponList3;
            Lweapon3.DisplayMember = "Name";
            Lweapon3.ValueMember = "Weight";
            Lweapon3.SelectedItem = null;
            Lweapon3.SelectedIndex = 0;

            //Rweapon1
            Rweapon1.DataSource = weaponList4;
            Rweapon1.DisplayMember = "Name";
            Rweapon1.ValueMember = "Weight";
            Rweapon1.SelectedItem = null;
            Rweapon1.SelectedIndex = 0;

            //Rweapon2
            Rweapon2.DataSource = weaponList5;
            Rweapon2.DisplayMember = "Name";
            Rweapon2.ValueMember = "Weight";
            Rweapon2.SelectedItem = null;
            Rweapon2.SelectedIndex = 0;

            //Rweapon3
            Rweapon3.DataSource = weaponList6;
            Rweapon3.DisplayMember = "Name";
            Rweapon3.ValueMember = "Weight";
            Rweapon3.SelectedItem = null;
            Rweapon3.SelectedIndex = 0;
        }

        public void LoadHead()
        {
            List<armor> headList = new List<armor>();

            string path = System.IO.Path.GetFullPath("head.csv");

            using (StreamReader reader = new StreamReader(path)) // Used to read file data
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split the line by the tab so that both columns are separated
                    string[] values = line.Split(',');

                    // set the properties of the item and parse the value string to float
                    string name = values[0];
                    float weight = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);

                    //Weapon
                    armor head = new armor();
                    head.Name = name;
                    head.Weight = weight;
                    headList.Add(head);
                }
            }


            //armor1
            armor1.DataSource = headList;
            armor1.DisplayMember = "Name";
            armor1.ValueMember = "Weight";
            armor1.SelectedItem = null;
            armor1.SelectedIndex = 0;
        }

        public void LoadChest()
        {
            List<armor> chestList = new List<armor>();

            string path = System.IO.Path.GetFullPath("chest.csv");

            using (StreamReader reader = new StreamReader(path)) // Used to read file data
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split the line by the tab so that both columns are separated
                    string[] values = line.Split(',');

                    // set the properties of the item and parse the value string to float
                    string name = values[0];
                    float P = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
                    float ST = float.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);
                    float SL = float.Parse(values[3], System.Globalization.CultureInfo.InvariantCulture);
                    float TH = float.Parse(values[4], System.Globalization.CultureInfo.InvariantCulture);
                    float M = float.Parse(values[5], System.Globalization.CultureInfo.InvariantCulture);
                    float F = float.Parse(values[6], System.Globalization.CultureInfo.InvariantCulture);
                    float L = float.Parse(values[7], System.Globalization.CultureInfo.InvariantCulture);
                    float D = float.Parse(values[8], System.Globalization.CultureInfo.InvariantCulture);
                    float BI = float.Parse(values[9], System.Globalization.CultureInfo.InvariantCulture);
                    float PO = float.Parse(values[10], System.Globalization.CultureInfo.InvariantCulture);
                    float FR = float.Parse(values[11], System.Globalization.CultureInfo.InvariantCulture);
                    float CU = float.Parse(values[12], System.Globalization.CultureInfo.InvariantCulture);
                    float PS = float.Parse(values[13], System.Globalization.CultureInfo.InvariantCulture);
                    float weight = float.Parse(values[14], System.Globalization.CultureInfo.InvariantCulture);
                    float PSW = float.Parse(values[15], System.Globalization.CultureInfo.InvariantCulture);

                    //Weapon
                    armor chest = new armor();
                    chest.Name = name;
                    chest.Weight = weight;
                    chestList.Add(chest);
                }
            }


            //chest
            armor2.DataSource = chestList;
            armor2.DisplayMember = "Name";
            armor2.ValueMember = "Weight";
            armor2.SelectedItem = null;
            armor2.SelectedIndex = 0;
        }

        public void LoadHands()
        {
            List<armor> handsList = new List<armor>();

            string path = System.IO.Path.GetFullPath("hands.csv");
            using (StreamReader reader = new StreamReader(path)) // Used to read file data
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split the line by the tab so that both columns are separated
                    string[] values = line.Split(',');

                    // set the properties of the item and parse the value string to float
                    string name = values[0];
                    float P = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
                    float ST = float.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);
                    float SL = float.Parse(values[3], System.Globalization.CultureInfo.InvariantCulture);
                    float TH = float.Parse(values[4], System.Globalization.CultureInfo.InvariantCulture);
                    float M = float.Parse(values[5], System.Globalization.CultureInfo.InvariantCulture);
                    float F = float.Parse(values[6], System.Globalization.CultureInfo.InvariantCulture);
                    float L = float.Parse(values[7], System.Globalization.CultureInfo.InvariantCulture);
                    float D = float.Parse(values[8], System.Globalization.CultureInfo.InvariantCulture);
                    float BI = float.Parse(values[9], System.Globalization.CultureInfo.InvariantCulture);
                    float PO = float.Parse(values[10], System.Globalization.CultureInfo.InvariantCulture);
                    float FR = float.Parse(values[11], System.Globalization.CultureInfo.InvariantCulture);
                    float CU = float.Parse(values[12], System.Globalization.CultureInfo.InvariantCulture);
                    float PS = float.Parse(values[13], System.Globalization.CultureInfo.InvariantCulture);
                    float weight = float.Parse(values[14], System.Globalization.CultureInfo.InvariantCulture);
                    float PSW = float.Parse(values[15], System.Globalization.CultureInfo.InvariantCulture);

                    //Weapon
                    armor hand = new armor();
                    hand.Name = name;
                    hand.Weight = weight;
                    handsList.Add(hand);
                }
            }


            //Hands
            armor3.DataSource = handsList;
            armor3.DisplayMember = "Name";
            armor3.ValueMember = "Weight";
            armor3.SelectedItem = null;
            armor3.SelectedIndex = 0;
        }

        public void LoadLegs ()
        {
            List<armor> legsList = new List<armor>();

            string path = System.IO.Path.GetFullPath("legs.csv");

            using (StreamReader reader = new StreamReader(path)) // Used to read file data
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split the line by the tab so that both columns are separated
                    string[] values = line.Split(',');

                    // set the properties of the item and parse the value string to float
                    string name = values[0];
                    float P = float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
                    float ST = float.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);
                    float SL = float.Parse(values[3], System.Globalization.CultureInfo.InvariantCulture);
                    float TH = float.Parse(values[4], System.Globalization.CultureInfo.InvariantCulture);
                    float M = float.Parse(values[5], System.Globalization.CultureInfo.InvariantCulture);
                    float F = float.Parse(values[6], System.Globalization.CultureInfo.InvariantCulture);
                    float L = float.Parse(values[7], System.Globalization.CultureInfo.InvariantCulture);
                    float D = float.Parse(values[8], System.Globalization.CultureInfo.InvariantCulture);
                    float BI = float.Parse(values[9], System.Globalization.CultureInfo.InvariantCulture);
                    float PO = float.Parse(values[10], System.Globalization.CultureInfo.InvariantCulture);
                    float FR = float.Parse(values[11], System.Globalization.CultureInfo.InvariantCulture);
                    float CU = float.Parse(values[12], System.Globalization.CultureInfo.InvariantCulture);
                    float PS = float.Parse(values[13], System.Globalization.CultureInfo.InvariantCulture);
                    float weight = float.Parse(values[14], System.Globalization.CultureInfo.InvariantCulture);
                    float PSW = float.Parse(values[15], System.Globalization.CultureInfo.InvariantCulture);

                    //Weapon
                    armor leg = new armor();
                    leg.Name = name;
                    leg.Weight = weight;
                    legsList.Add(leg);
                }
            }


            //chest
            armor4.DataSource = legsList;
            armor4.DisplayMember = "Name";
            armor4.ValueMember = "Weight";
            armor4.SelectedItem = null;
            armor4.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Search for updates
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/4SDWV9m4").Contains("1.0"))
            {
                if (MessageBox.Show("Update available", "DSIIIStatCalcUpdater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/Asiern/DarkSoulsStatCalculator/releases");
                }
                else
                {

                }
            }

            //Init
            LoadRings();
            LoadWeapons();
            LoadHead();
            LoadChest();
            LoadHands();
            LoadLegs();

        }

        //Calculate weight
        public double Weightsum()
        {
            double weight = 0;

            //Rings1
            if (rings1.SelectedItem != null)
            {
                Ring ring1 = rings1.SelectedItem as Ring;
                weight = weight + ring1.Weight;
            }

            //Rings2
            if (rings2.SelectedItem != null)
            {
                Ring ring2 = rings2.SelectedItem as Ring;
                weight = weight + ring2.Weight;
            }

            //Rings3
            if (rings3.SelectedItem != null)
            {
                Ring ring3 = rings3.SelectedItem as Ring;
                weight = weight + ring3.Weight;
            }

            //Rings4
            if (rings4.SelectedItem != null)
            {
                Ring ring4 = rings4.SelectedItem as Ring;
                weight = weight + ring4.Weight;
            }

            //Lweapon1
            if (Lweapon1.SelectedItem != null)
            {
                weapon weapon1 = Lweapon1.SelectedItem as weapon;
                weight = weight + weapon1.Weight;
            }

            //Lweapon2
            if (Lweapon2.SelectedItem != null)
            {
                weapon weapon2 = Lweapon2.SelectedItem as weapon;
                weight = weight + weapon2.Weight;
            }

            //Lweapon3
            if (Lweapon3.SelectedItem != null)
            {
                weapon weapon3 = Lweapon3.SelectedItem as weapon;
                weight = weight + weapon3.Weight;
            }

            //Rweapon1
            if (Rweapon1.SelectedItem != null)
            {
                weapon weapon4 = Rweapon1.SelectedItem as weapon;
                weight = weight + weapon4.Weight;
            }

            //Rweapon2
            if (Rweapon2.SelectedItem != null)
            {
                weapon weapon5 = Rweapon2.SelectedItem as weapon;
                weight = weight + weapon5.Weight;
            }

            //Rweapon3
            if (Rweapon3.SelectedItem != null)
            {
                weapon weapon6 = Rweapon3.SelectedItem as weapon;
                weight = weight + weapon6.Weight;
            }

            //Head
            if (armor1.SelectedItem != null)
            {
                armor head = armor1.SelectedItem as armor;
                weight = weight + head.Weight;
            }

            //Chest
            if (armor2.SelectedItem != null)
            {
                armor chest = armor2.SelectedItem as armor;
                weight = weight + chest.Weight;
            }

            //Hands
            if (armor3.SelectedItem != null)
            {
                armor hands = armor3.SelectedItem as armor;
                weight = weight + hands.Weight;
            }

            //Legs
            if (armor4.SelectedItem != null)
            {
                armor legs = armor4.SelectedItem as armor;
                weight = weight + legs.Weight;
            }

            return weight;
        }

        private void rings1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sum = Weightsum();
            //vitcalc();
            //Vitlbl.Text = sum.ToString();
        }

        //Vit Calc
        public void vitcalc()
        {
            double rollpercent = 29.9;
            double vitality;
            int cont = 0;
            double weight;
            int finished = 0;
            List<int> vitstats = new List<int>();
            List<int> vitlvl = new List<int>();
            //Add items to list
            vitstats.Add(47);
            vitstats.Add(50);
            vitstats.Add(55);
            vitstats.Add(60);
            vitstats.Add(65);
            vitstats.Add(70);
            vitstats.Add(75);
            vitstats.Add(80);
            vitstats.Add(85);
            vitstats.Add(90);
            vitstats.Add(95);
            vitstats.Add(100);
            vitstats.Add(105);
            vitstats.Add(110);
            vitstats.Add(115);
            vitstats.Add(120);
            vitstats.Add(125);
            vitstats.Add(130);
            vitstats.Add(135);
            vitstats.Add(139);

            vitlvl.Add(7);
            vitlvl.Add(10);
            vitlvl.Add(15);
            vitlvl.Add(20);
            vitlvl.Add(25);
            vitlvl.Add(30);
            vitlvl.Add(35);
            vitlvl.Add(40);
            vitlvl.Add(45);
            vitlvl.Add(50);
            vitlvl.Add(55);
            vitlvl.Add(60);
            vitlvl.Add(65);
            vitlvl.Add(70);
            vitlvl.Add(75);
            vitlvl.Add(80);
            vitlvl.Add(85);
            vitlvl.Add(90);
            vitlvl.Add(95);
            vitlvl.Add(99);


            //weight = float.Parse(weightbox.Text);
            weight = Weightsum();

            //Selec kind of roll
            if (Fastrb.Checked)
            {
                rollpercent = 29.9;
            }
            if (Normalrb.Checked)
            {
                rollpercent = 69.9;
            }
            if (Fatrb.Checked)
            {
                rollpercent = 99.9;
            }

            //Calculate vitality lvl
            vitality = weight * 100.0 / rollpercent;

            //Select lvl
            while (finished == 0)
            {
                //Search lvl comparing vitality stats in both lists
                if (vitality <= vitstats[cont])
                {
                    finished = 1;
                }
                else
                {
                    cont += 1;
                }
            }

            ////////////////////////////////////
            //Añadir excepcion weight>139 peta//
            ////////////////////////////////////

            //Show result
            Vitlbl.Text = vitlvl[cont].ToString() + " " + "Levels on Vitality";
        }

        public int levelcalc()
        {
            try
            {
                int clvl = Int32.Parse(clvlinput.Text);
                int tlvl = Int32.Parse(tlvlinput.Text);
                int souls = 0;
                int[] categories = {0,673,689,706,723,740,757,793,811,829,847,1038,1238,1445,1659,1882,2113,2353,2601,2857,3122,3395,3678,3969,4270,4580,4899,5228,5566,
                    5915,6272,6640,7018,7407,7805,8214,8633,9064,9505,9956,10419,10893,11379,11876,12384,12904,13435,13979,14535,15102,15682,16274,16879,
                    17497,18127,18770,19425,20094,20776,21472,22181,22903,23640,24390,25153,25931,26723,27530,28351,29186,30036,30900,31780,32675,33584,
                    34509,35449,36405,37377,38364,39367,40385,41420,42472,43539,44623,45723,46841,47975,49125,50293,51478,52681,53901,55138,56393,57665,
                    58956,60265,61591,62936,64299,65681,67082,68501,69939,71395,72871,74367,75881,77415,78968,80542,82134,83747,85380,87033,88707,90400,
                    92115,93850,95605,97382,99179,100998,102838,104699,106582,108486,110413,112360,114330,116322,118337,120373,122432,124513,126618,
                    128744,130894,133067,135263,137483,139725,141992,144282,146595,148933,151295,153680,156090,158524,160983,163466,165975,168507,171065,
                    173648,176257,178890,181000,549000,181549,184234,186944,189680,192442,195230,198044,200884,203751,206644,209564,212511,215484,218485,
                    221513,224568,227650,230760,233897,237062,240255,243476,246725,250002};
                var level = categories.ToList();

                //Load ArrayList
                //...

                //Adjust to list
                clvl--;
                tlvl++;

                for (int i = 1; i < tlvl; i++)
                {
                    souls = souls + level[clvl];
                    clvl++;
                }

                return souls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            Vitlbl.Text = Weightsum().ToString();
        }

        private void Lweapon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitcalc();
        }

        private void Fastrb_CheckedChanged(object sender, EventArgs e)
        {
            vitcalc();
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        //LINKS
        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Asiern/DarkSoulsStatCalculator");
        }
        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Asiern/DarkSoulsStatCalculator/releases");
        }
        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Asiern/DarkSoulsStatCalculator#users-guide");
        }
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Asiern");
        }
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IkerGalardi");
        }
        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bytxampi");
        }
        //LINKS

        //Calc Souls
        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            souls.Text = levelcalc().ToString() + " " + "Souls";
        }
    }
}
