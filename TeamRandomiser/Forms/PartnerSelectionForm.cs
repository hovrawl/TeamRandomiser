using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamRandomiser.Classes;

namespace TeamRandomiser.Forms
{
    public partial class PartnerSelectionForm : Form
    {
        List<PlayerRef> AvailablePartners = new List<PlayerRef>();
        public List<PlayerRef> SelectedPartners = new List<PlayerRef>();
        public PartnerSelectionForm()
        {
            InitializeComponent();
        }

        public PartnerSelectionForm(List<PlayerRef> availablePartners, List<PlayerRef> existingPartners)
        {

            InitializeComponent();
            InitWithData(availablePartners, existingPartners);
        }

        public void InitWithData(List<PlayerRef> availablePartners, List<PlayerRef> existingPartners)
        {
            AvailablePartners = availablePartners;
            SelectedPartners = existingPartners;

            playerPartnerCheckedListBox.DataSource = AvailablePartners;
            playerPartnerCheckedListBox.DisplayMember = "Name";
            var selectedIndexes = new List<int>();
            foreach (var item in playerPartnerCheckedListBox.Items)
            {
                if (item is PlayerRef playerRef)
                {
                    if (SelectedPartners.Any(i =>
                        i.Name.Equals(playerRef.Name, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        var index = playerPartnerCheckedListBox.Items.IndexOf(item);
                        selectedIndexes.Add(index);
                    }
                }
            }

            foreach (var selectedIndex in selectedIndexes)
            {
                playerPartnerCheckedListBox.SetItemCheckState(selectedIndex, CheckState.Checked);
            }
        }

        private void SelectPartners()
        {
            SelectedPartners = new List<PlayerRef>();
            foreach (var item in playerPartnerCheckedListBox.CheckedItems)
            {
                if (item is PlayerRef playerRef)
                {
                    SelectedPartners.Add(playerRef);
                }
            }

            CloseForm();
        }

        private void CloseForm()
        {
            this.Dispose();
            this.Close();
        }

        private void playerPartnerSelectBtn_Click(object sender, EventArgs e)
        {
            SelectPartners();
        }

        private void playerPartnerCancelBtn_Click(object sender, EventArgs e)
        {
            CloseForm();

        }
    }
}
