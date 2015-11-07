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

        private void dump()
        {
            string[] lines = new string[MaxEvent];
            for (int i = 0; i < MaxEvent; i++)
            {
                lines[i] = BitConverter.ToInt32(MainForm.SaveData, eventOffset + 4 * i).ToString();
            }
            System.IO.File.WriteAllLines("EventFlag.txt", lines);
        }

        /// <summary>
        /// Save event data to main save file
        /// </summary>
        public void SaveEvent()
        {
            for (int i = 0; i < MaxEvent; i++)
            {
                int value;
                bool isValid = Int32.TryParse(eventDataGridView.Rows[i]
                    .Cells[1].Value.ToString(), out value);
                if (isValid)
                    Array.Copy(BitConverter.GetBytes(value), 0, MainForm.SaveData,
                        eventOffset + 4 * i, 4);
            }
        }

        private void EventEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEvent();
        }
    }
}
