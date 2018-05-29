using System;
using System.Windows.Forms;
using ManagerSoftware.GUIApplication;
using ManagerSoftware.CoreEngine;
using System.Collections.Generic;

namespace ManagerSoftware.GUI
{
    public partial class Manager_Software_Windows : Form
    {
        private Engine engine;

        private List<Archive> archives = new List<Archive>
            {
                new Archive("DepartSul-Dec", new DateTime(2016, 12, 01), 16464135),
                new Archive("DepartNort-Jan", new DateTime(2017, 12, 01), 99994135),
                new Archive("DepartTejo-Dec", new DateTime(2015, 12, 01), 14256335),
                new Archive("DepartNort-Mar", new DateTime(2017, 03, 01), 99894135),
                new Archive("DepartTejo-Nov", new DateTime(2017, 11, 01), 111256335)
            };

        public Manager_Software_Windows()
        {
            InitializeComponent();
            this.engine = new Engine();
        }

        private bool Check_Verification()
        {
            return (contactNumber.Text.Length > 0) && (email.Text.Length > 0) &&
                (name.Text.Length > 0) && (role.Text.Length > 0);
        }

        private void button_Insert(object sender, EventArgs e)
        {
            if (role.Text.Equals("Diretor"))
            {
                Queue<Archive> received = engine.InsertQueue(name.Text, email.Text, contactNumber.Text, archives);
                Director_Load(received);
            }
            else if (role.Text.Equals("Operário"))
            {
                Stack<Archive> received = engine.InsertStack(name.Text, email.Text, contactNumber.Text, archives);
                Operario_Load(received);
            }

            Inserted_List.View = View.Tile;
            buttonSend.Enabled = true;
            insert_button.Enabled = false;
        }

        private void textChanged(object sender, EventArgs e)
        {
            insert_button.Enabled = Check_Verification();
        }

        private void reset_button(object sender, EventArgs e)
        {
            engine.Reset();
            Utilities.ResetAllControls(this);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            List<Archive> message = engine.Send();
            Send(message);
            sent_List.View = View.Tile;
            buttonSend.Enabled = false;
        }

        private void Manager_Software_Windows_Load(object sender, EventArgs e)
        {
            ListViewItem[] newList = new ListViewItem[archives.Count];

            foreach (var archive in archives)
            {
                var item = new ListViewItem(new[] { archive.Id.ToString(), archive.Name, archive.ArchiveDate.ToShortDateString() });
                originalList.Items.Add(item);
            }
        }

        private void Director_Load(Queue<Archive> files)
        {
            foreach (var archive in files)
            {
                var item = new ListViewItem(new[] { archive.Id.ToString(), archive.Name, archive.ArchiveDate.ToShortDateString() });
                Inserted_List.Items.Add(item);
            }
        }

        private void Operario_Load(Stack<Archive> files)
        {
            foreach (var archive in files)
            {
                var item = new ListViewItem(new[] { archive.Id.ToString(), archive.Name, archive.ArchiveDate.ToShortDateString() });
                Inserted_List.Items.Add(item);
            }
        }

        private void Send(List<Archive> files)
        {
            foreach (var archive in files)
            {
                var item = new ListViewItem(new[] { archive.Id.ToString(), archive.Name, archive.ArchiveDate.ToShortDateString() });
                sent_List.Items.Add(item);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}