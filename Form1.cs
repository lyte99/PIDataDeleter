using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSIsoft.AF.PI;
using OSIsoft.AF;
using OSIsoft.AF.Time;
using OSIsoft.AF.Asset;
using System.Globalization;
using OSIsoft.AF.Data;

namespace PIDataDeleter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTimePicker();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isDataValid = DataValidationCheck();

            if (isDataValid)
            {
                //connect to pi server
                var myPIServer = ConnectToPIServer(tBoxPIServerName.Text.Trim());

                if (myPIServer != null && myPIServer.ConnectionInfo.IsConnected)
                {
                    //delete the data
                    DeletPITagData(myPIServer);

                    //disconnect from Pi server
                    myPIServer.Disconnect();

                    MessageBox.Show("Complete.");
                }
            }

            

        }

        private void DeletPITagData(PIServer myPIServer)
        {
            //name of tag from textbox
            var PItagName = (tBoxPITagName.Text.Trim());

            //time range
            var timeRange = new AFTimeRange(new AFTime(dtPickerStartTime.Value.ToUniversalTime()), new AFTime(dtPickerEndTime.Value.ToUniversalTime()));

            //get the pi tag
            PIPoint PITag = PIPoint.FindPIPoint(myPIServer, PItagName);

            //turn it into an attribute
            var myAttribute = new AFAttribute(String.Format(CultureInfo.InvariantCulture, @"\\{0}\{1}", myPIServer.Name, PITag.Name));

            //get all values during the timerange
            var tagValues = myAttribute.Data.RecordedValues(timeRange, AFBoundaryType.Inside,myAttribute.DefaultUOM, null, false); //.GetValues(timeRange, 0,myAttribute.DefaultUOM);

            //loop through each value and remove it.
            foreach (var value in tagValues)
            {
                //remove value
                myAttribute.Data.UpdateValue(value, AFUpdateOption.Remove);
            }


        }

        static PIServer ConnectToPIServer(string PIServer)
        {
            PIServers myPIServers = new PIServers();

            PIServer myPiserver = myPIServers[PIServer];

            try
            {
                myPiserver.Connect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to connect to PI server, please try again.");
            }
            

            //var cred = new NetworkCredential(processAccount, processAccountPassword, "NA");
            //AF_Server.Connect(cred);


            

            return myPiserver;
        }

        private bool DataValidationCheck()
        {
            bool isValid = true;

            string strError = "";

            //check PI server name
            if (tBoxPIServerName.Text.Trim() == "")
            {
                strError = strError + "The PI server name cannot be blank.";
                isValid = false;
            }

            //check PI tag name
            if (tBoxPITagName.Text.Trim() == "")
            {
                strError = strError + " The PI Tag name cannot be blank.";
                isValid = false;
            }

            //end data cannot be before start date
            if (dtPickerStartTime.Value >= dtPickerEndTime.Value)
            {
                strError = strError + " The Start Date cannot be before or equal to the End date.";
                isValid = false;
            }



            //show message box if error
            if (!isValid)
            {
                MessageBox.Show("Data Validation Error: " + strError);
            }


            return isValid;
        }

        private void InitializeTimePicker()
        {

            //set custom date/time formats
            dtPickerStartTime.Format = DateTimePickerFormat.Custom;
            dtPickerStartTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            dtPickerEndTime.Format = DateTimePickerFormat.Custom;
            dtPickerEndTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";

        }

    }
}
