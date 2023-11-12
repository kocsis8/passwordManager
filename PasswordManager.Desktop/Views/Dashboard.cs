using Microsoft.VisualBasic.ApplicationServices;
using passwordManager;
using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Desktop.Views
{
    public partial class Dashboard : Form
    {
        private readonly PasswordManagerDbContext _context;
        Core.Models.User loggedUser;


        public Dashboard(Core.Models.User newUser)
        {
            _context = Program.GetDbContext();
            this.loggedUser = newUser;
            InitializeComponent();

            InitializeDataGridView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddNewPassword anpw = new AddNewPassword(loggedUser);
            anpw.Show();
        }

        private void addVaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPassword anpw = new AddNewPassword(loggedUser);
            anpw.Show();
        }

        public void InitializeDataGridView()
        {
            // Állítsd be a DataGridView oszlopait
            dataGridViewVault.Columns.Add("Username", "Username");
            dataGridViewVault.Columns.Add("Password", "Password");
            dataGridViewVault.Columns.Add("Website", "Website");

            // Töltsd fel a DataGridView-t a Vault adataival
            List<Vault> vaultList = _context.Vault.Where(v => v.User == loggedUser).ToList();

            foreach (var vault in vaultList)
            {
                EncryptedType encryptedData = new EncryptedType(loggedUser.Email, vault.Password);
                EncryptedType decryptedResult = encryptedData.Decrypt();

                dataGridViewVault.Rows.Add(vault.Username, decryptedResult.Secret, vault.Website);
            }
        }
    }
}
