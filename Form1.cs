using GemBox.Spreadsheet;
using System.IO;

namespace PSP_KanBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pinStartLocationToolStripMenuItem.Click += saveSizeAndPosition;
            //GeometryFromString(Properties.Settings.Default.WindowGeometry, this);
        }
        private async void saveSizeAndPosition(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Size = Size;
            Properties.Settings.Default.Save();
            var textB4 = Text;
            Text = $"Location = {Location} Size = {Size}";
            await Task.Delay(1000);
            Text = textB4;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(!Properties.Settings.Default.Size.Equals(new Size()))
            {
                Size = Properties.Settings.Default.Size;
            }
        }
        private void pinStartLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pinStartLocationToolStripMenuItem.Click += saveSizeAndPosition;

        }

        /* Updates the Quantity shown in the Kits Tab of the Application when 
          a new Item is Selected from the Kits_ComboBox */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kit_csv_quantity.Text = kits_comboBox.SelectedValue.ToString();        
        }

        /* Updates the Quantity shown in the PSP's Tab of the Application when 
          a new Item is Selected from the psp_ComboBox */
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            psp_csv_quantity.Text = psp_comboBox.SelectedValue.ToString();
        }

        /* Updates the Quantity shown in the Plates Tab of the Application when 
          a new Item is Selected from the plates_ComboBox */
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            plates_csv_quantity.Text = plates_comboBox.SelectedValue.ToString();
        }
        private List<ItemLine> allItems = new List<ItemLine>();  // Initializes a new list for Kits_be.csv Items
        private List<ItemLine> allPspItems = new List<ItemLine>();  // Initializes a new list for PSPs_be.csv Items
        private List<ItemLine> allplateItems = new List<ItemLine>();  // Initializes a new list for Plates_be.csv Items

        /// <summary>
        /// On Form Load, populates populates the Kits combobox, Psp combobox,
        /// and the Plates combobox with there csv files.
        /// Also Locks the comboboxes from being able to type in.
        /// </summary>       
        private void Form1_Load(object sender, EventArgs e)
        {
            //Locks the ComboBoxes from being able to type in 
            kits_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            psp_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            plates_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // On form Load, sets initial value of all three numericUpDowns to 0 and clears them.
            kits_upDown.Text = "";
            psp_upDown.Text = "";
            plates_upDown.Text = "";

            // Populates the kits_comboBox with the Kits_be.csv file.
            kits_comboBox.DisplayMember = "ComboDescription";
            kits_comboBox.ValueMember = "Quantity";
            kits_comboBox.DataSource = ReadFile("Kits_be.csv", "Select a PSP Kit... ");
            
            // Populates the psp_comboBox with the PSPs_be.csv file.
            psp_comboBox.DisplayMember = "ComboDescription";
            psp_comboBox.ValueMember = "Quantity";
            psp_comboBox.DataSource = ReadFile("PSPs_be.csv", "Select a PSP Type...");
            
            //Populates the plates_combobox with the Plates_be.csv file.
            plates_comboBox.DisplayMember = "ComboDescription";
            plates_comboBox.ValueMember = "Quantity";
            plates_comboBox.DataSource = ReadFile("Plates_be.csv", "Select a Plate Type...");
        }
        /// <summary>
        /// creates the ReadFile method which reads in a csv file and then
        /// populates a comboBox with the values in that csv file.
        /// </summary>
        private List<ItemLine> ReadFile(string fileName, string defaultValueDescription) //TODO 1 function to handle all file reading
        {
            string path = $".\\Backend Files\\{fileName}";
            var items = new List<ItemLine>();
            int row = 0;
            //read the file
            StreamReader reader = new StreamReader(path);
            while (reader.EndOfStream == false)
            {
                string lines = reader.ReadLine();
                row++;
                if (row == 1)
                {
                    items.Add(new ItemLine { Description = defaultValueDescription, Quantity = 0 });
                    continue;
                }
                string[] itemFields = lines.Split(",");
                ItemLine IL = new ItemLine();
                if (itemFields.Length == 2)
                {
                    IL.Description = itemFields[0];
                    IL.Quantity = 0;
                    if (int.TryParse(itemFields[1], out int qty))
                    {
                        IL.Quantity = qty;
                    }
                }
                else if (itemFields.Length >= 3)
                {
                    IL.Plan = itemFields[0];
                    IL.Description = itemFields[1];
                    IL.Quantity = 0;
                    if (int.TryParse(itemFields[2], out int qty))
                    {
                        IL.Quantity = qty;
                    }
                }
                ///Add Items to List
                items.Add(IL);
            }
            reader.Close();
            return items;         
        }
        
        private string clickPath(string filePath)
        {
            string path = $".\\Backend Files\\{filePath}";
            return path;
        }
        
        /// <summary>
        /// Creates the Update File method which creates an excel workbook from
        /// a csv file, and then updates that workbook with a users input value,
        /// and then saves the workbook back to a csv file, replacing the old one 
        /// with the new updated values.
        /// </summary>
        public void updateFile(string pathFile, int upDownValue, int range, ItemLine selectedItem, decimal outValue)
        {
            SpreadsheetInfo.SetLicense("FREE -LIMITED-KEY");
            var workbook = ExcelFile.Load(pathFile, new CsvLoadOptions(CsvType.CommaDelimited));
            var worksheet = workbook.Worksheets[0];
            for (int i = 1; i <= range; i++)
            {
                var plan = worksheet.Rows[i].Cells[0].Value;
                var desc = worksheet.Rows[i].Cells[1].Value;
                var csvDescription = plan + " - " + desc;
                var platedescription = plan + " - ";
                if (selectedItem.ComboDescription == csvDescription)
                {
                    worksheet.Rows[i].Cells[2].Value = outValue;
                }
                if(selectedItem.plateDescription == platedescription)
                {
                    worksheet.Rows[i].Cells[1].Value = outValue;
                }               
            }
            workbook.Save(pathFile, new CsvSaveOptions(CsvType.CommaDelimited));           
        }
        /// <summary>
        /// creates the Add button on the Kits tab
        /// </summary>
        private void add_Kit_Click(object sender, EventArgs e) 
        {
            if (kits_comboBox.SelectedItem == null)  // If selected Item is null, we don't want to do anything
            {
                return;
            }
            if (!(kits_comboBox.SelectedItem is ItemLine selectedItem))
            {
                return;
            }
            string kitPath = clickPath("Kits_be.csv");           
            if (int.TryParse(kit_csv_quantity.Text, out int kitOut))
            {
                if (kits_upDown.Value <= 0)
                {
                    MessageBox.Show("Invalid Entry, Can not add or remove a negative number");
                    return;
                }             
                decimal kitOutValue = kitOut + kits_upDown.Value;  // creates the value for the kits_quantity label
                kit_csv_quantity.Text = kitOutValue.ToString();  // updates the kits_csv_quantity label value
                updateFile(kitPath, kitOut, kits_comboBox.Items.Count, selectedItem, kitOutValue);                
            }
            
        }
        /// <summary>
        /// creates the Remove button on the Kits tab
        /// </summary>
        private void remove_kit_Click(object sender, EventArgs e)  
        {
            if (kits_comboBox.SelectedItem == null)
            {
                return;
            }
            if (!(kits_comboBox.SelectedItem is ItemLine selectedItem))
            {
                return;
            }
            string kitPath = clickPath("Kits_be.csv");
            if (int.TryParse(kit_csv_quantity.Text, out int kitOut))
            {
                decimal kitOutValue = kitOut - kits_upDown.Value;
                kit_csv_quantity.Text = kitOutValue.ToString();
                updateFile(kitPath, kitOut, kits_comboBox.Items.Count, selectedItem, kitOutValue);
            }
        }

        /// <summary>
        /// creates the Add button on the PSP tab
        /// </summary>
        private void add_psp_Click(object sender, EventArgs e) 
        {
            if (psp_comboBox.SelectedItem == null)
            {
                return;
            }
            if (!(psp_comboBox.SelectedItem is ItemLine pspselectedItem))
            {
                return;
            }
            if (int.TryParse(psp_csv_quantity.Text, out int pspOut))
            {
                if(psp_upDown.Value <= 0)
                {
                    MessageBox.Show("Invalid Entry, Can not add or remove a negative number");
                    return;
                }
                decimal pspOutValue = pspOut + psp_upDown.Value;
                psp_csv_quantity.Text = pspOutValue.ToString();
                string pspPath = clickPath("PSPs_be.csv");
                updateFile(pspPath, pspOut, psp_comboBox.Items.Count, pspselectedItem, pspOutValue);
            }
        }
        /// <summary>
        /// creates the Remove button on the PSP tab
        /// </summary>       
        private void remove_psp_Click(object sender, EventArgs e)  
        {
            if (psp_comboBox.SelectedItem == null)
            {
                return;
            }
            if (!(psp_comboBox.SelectedItem is ItemLine pspselectedItem))
            {
                return;
            }
            if (int.TryParse(psp_csv_quantity.Text, out int pspOut))
            {
                decimal pspOutValue = pspOut - psp_upDown.Value;
                psp_csv_quantity.Text = pspOutValue.ToString();
                string pspPath = clickPath("PSPs_be.csv");
                updateFile(pspPath, pspOut, psp_comboBox.Items.Count, pspselectedItem, pspOutValue);
            }
        }
        /// <summary>
        /// creates the add button on the Plates tab
        /// </summary>
        private void plates_add_Click(object sender, EventArgs e)  
        {
            if (plates_comboBox.SelectedItem == null)
            {
                return;
            }
            if (!(plates_comboBox.SelectedItem is ItemLine platesselectedItem))
            {
                return;
            }
            if (int.TryParse(plates_csv_quantity.Text, out int platesOut))
            {
                if (plates_upDown.Value <= 0)
                {
                    MessageBox.Show("Invalid Entry, Can not add or remove a negative number.");
                    return;
                }
                decimal platesOutValue = platesOut + plates_upDown.Value;
                plates_csv_quantity.Text = platesOutValue.ToString();
                string platePath = clickPath("Plates_be.csv");
                updateFile(platePath, platesOut, plates_comboBox.Items.Count, platesselectedItem, platesOutValue);              
            }
        }
        /// <summary>
        /// creates the remove button on the Plate tab
        /// </summary>
        private void plates_remove_Click(object sender, EventArgs e)  
        {
            if (plates_comboBox.SelectedItem == null)
            {
                return;
            }
            if (!(plates_comboBox.SelectedItem is ItemLine platesselectedItem))
            {
                return;
            }
            if (int.TryParse(plates_csv_quantity.Text, out int platesOut))
            {
                decimal platesOutValue = platesOut - plates_upDown.Value;
                plates_csv_quantity.Text = platesOutValue.ToString();
                string platePath = clickPath("Plates_be.csv");
                updateFile(platePath, platesOut, plates_comboBox.Items.Count, platesselectedItem, platesOutValue);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)  // creates the Close button in the Tool Strip Menu
        {
            this.Close();
        }
        private void clear_kit_Click(object sender, EventArgs e)  // clears the value in kits_upDown  and sets it back to 0;
        {
            kits_upDown.Value = 0;
            kits_upDown.Text = "";
        }
        private void clear_psp_Click(object sender, EventArgs e)  // clears the value in psp_upDown  and sets it back to 0;
        {
            psp_upDown.Value = 0;
            psp_upDown.Text = "";
        }
        private void plates_clear_Click(object sender, EventArgs e)  // clears the value in plates_upDown  and sets it back to 0;
        {
            plates_upDown.Value = 0;
            plates_upDown.Text = "";
        }

        /// <summary>
        /// Creates the ItemLine Class
        /// </summary>
        public class ItemLine
        {
            /// <summary>
            /// The Plan of the Item. (First Item in CSV.)
            /// </summary>
            public string Plan { get; set; }

            /// <summary>
            /// The Description of the Item. (Second Item in CSV.)
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// The Quantity of the Item. (Third Item in CSV.)
            /// </summary>
            public int Quantity { get; set; }

            /// <summary>
            /// Gets the Plan and Description of the Item and puts in the ComboBox. (First and Second Item in CSV.)
            /// </summary>
            public string ComboDescription
            {
                get
                {
                    if (string.IsNullOrWhiteSpace(Plan))
                    {
                        return Description;
                    }

                    return Plan + " - " + Description;
                }
            }
            public string plateDescription
            {
                get { return Description + " - "; }
            }
        }

        

        //public static void GeometryFromString(string thisWindowGeometry, Form formIn)
        //{
        //    if (string.IsNullOrEmpty(thisWindowGeometry) == true)
        //    {
        //        return;
        //    }
        //    string[] numbers = thisWindowGeometry.Split('|');
        //    string windowString = numbers[4];
        //    if (windowString == "Normal")
        //    {
        //        Point windowPoint = new Point(int.Parse(numbers[0]),
        //            int.Parse(numbers[1]));
        //        Size windowSize = new Size(int.Parse(numbers[2]),
        //            int.Parse(numbers[3]));

        //        bool locOkay = GeometryIsBizarreLocation(windowPoint, windowSize);
        //        bool sizeOkay = GeometryIsBizarreSize(windowSize);

        //        if (locOkay == true && sizeOkay == true)
        //        {
        //            formIn.Location = windowPoint;
        //            formIn.Size = windowSize;
        //            formIn.StartPosition = FormStartPosition.Manual;
        //            formIn.WindowState = FormWindowState.Normal;
        //        }
        //        else if (sizeOkay == true)
        //        {
        //            formIn.Size = windowSize;
        //        }
        //    }
        //    else if (windowString == "Maximized")
        //    {
        //        formIn.Location = new Point(100, 100);
        //        formIn.StartPosition = FormStartPosition.Manual;
        //        formIn.WindowState = FormWindowState.Maximized;
        //    }
        //}
        //private static bool GeometryIsBizarreLocation(Point loc, Size size)
        //{
        //    bool locOkay;
        //    if (loc.X < 0 || loc.Y < 0)
        //    {
        //        locOkay = false;
        //    }
        //    else if (loc.X + size.Width > Screen.PrimaryScreen.WorkingArea.Width)
        //    {
        //        locOkay = false;
        //    }
        //    else if (loc.Y + size.Height > Screen.PrimaryScreen.WorkingArea.Height)
        //    {
        //        locOkay = false;
        //    }
        //    else
        //    {
        //        locOkay = true;
        //    }
        //    return locOkay;
        //}
        //private static bool GeometryIsBizarreSize(Size size)
        //{
        //    return (size.Height <= Screen.PrimaryScreen.WorkingArea.Height &&
        //        size.Width <= Screen.PrimaryScreen.WorkingArea.Width);
        //}
        //public static string GeometryToString(Form mainForm)
        //{
        //    return mainForm.Location.X.ToString() + "|" +
        //        mainForm.Location.Y.ToString() + "|" +
        //        mainForm.Size.Width.ToString() + "|" +
        //        mainForm.Size.Height.ToString() + "|" +
        //        mainForm.WindowState.ToString();
        //}

        //private void pinStartLocationToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    //Properties.Settings.Default.WindowGeometry = GeometryToString(this);
        //    //Properties.Settings.Default.Save();
        //}

    }
}





