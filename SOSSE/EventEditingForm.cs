using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOSSE
{
    public partial class EventEditingForm : Form
    {
        private const int eventOffset = 0xFB8;

        public const int MaxEvent = 667;
        public bool DataLoaded { get; private set; }
        public static string[] EventFlagList;

        public EventEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            Util.LoadEventFlag();

            eventDataGridView.Rows.Add(MaxEvent);
            for (int i = 0; i < MaxEvent; i++)
            {
                var row = eventDataGridView.Rows[i];
                row.Cells[0].Value = EventFlagList[i];
                row.Cells[1].Value = BitConverter.ToInt32(MainForm.SaveData, eventOffset + 4 * i);
            }
        }
    }
}
