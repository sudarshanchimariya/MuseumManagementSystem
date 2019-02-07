using MuseumManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MuseumManagementSystem
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
        }
        private void MuseumForm_Load(object sender, EventArgs e)
        {
            Int64 ID = Settings.Default.tempVisitorID;
            tempVisitorID.Text = ID.ToString();

            DateTime dateTodayday = DateTime.Today.Date;
            dateToday.Text = dateTodayday.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            CheckInTimePicker.MinDate = DateTime.Parse("10:00:00 AM", CultureInfo.InvariantCulture);
            CheckOutTimepicker.MinDate = DateTime.Parse("10:00:00 AM", CultureInfo.InvariantCulture);
            CheckOutTimepicker.MaxDate = DateTime.Parse("05:00:00 PM", CultureInfo.InvariantCulture);
            CheckInTimePicker.MaxDate = DateTime.Parse("05:00:00 PM", CultureInfo.InvariantCulture);

            if ((int)dateTodayday.DayOfWeek == 6 || (int)dateTodayday.DayOfWeek == 0 ||  DateTime.Now.TimeOfDay > CheckInTimePicker.MaxDate.TimeOfDay || DateTime.Now.TimeOfDay < CheckInTimePicker.MinDate.TimeOfDay)
            {
                MainGrpBox.Text = "Welcome";
               
                lblMainMsg.Text = "\n\nMuseum is closed \n\n\n\nClose on Saturdays and Sundays \nOpen time: 10:00 AM \nClose time: 05:00 PM \n" + DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt");
                lblMainMsg.ForeColor = System.Drawing.Color.Red;
                lblMainMsg.Show();
                btnNewVisitor.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
               
                MainGrpBox.Text = "Welcome";
                lblMainMsg.Text = "Museum is Open \nOpen time: 10:00 AM \nClose time: 05:00 PM \n" + DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt");
                lblMainMsg.Show();
            }
        }

        private void NewEntryBtn_Click(object sender, EventArgs e)
        {
            lblMnlInput.Show();
            lblMnlInput.Text = "Manual Input";
            long ID = Int64.Parse(tempVisitorID.Text);
            visitorID.Text = (ID + 1).ToString();
            tempVisitorID.Text = visitorID.Text;
            ResetVisitorsEntryForm();
            lblMainMsg.Hide();
            dispReportPanel.Hide();
            newVisitorEntryPanel.Show();
            errFirstName.Visible = false;
            errLastName.Visible = false;
            errOccupation.Visible = false;
            errContactNo.Visible = false;
            errEmailAddress.Visible = false;
            errAddress.Visible = false;
            btnSave.Text = "Check In";
            TxtInputPanel.Show();
            MainGrpBox.Text = "Register Visitors";

            if (File.Exists("CheckinsInformation.csv"))
            {
                List<VisitorsInformation> list = new List<VisitorsInformation>();

                using (Stream stream = new FileStream("CheckinsInformation.csv", FileMode.Open, FileAccess.Read))
                {
                    CsvChecker<VisitorsInformation> cs = new CsvChecker<VisitorsInformation>()
                    {
                        UseTextQualifier = true,
                    };
                    list = cs.ReadFromFile(stream);
                }

                BindingList<VisitorsInformation> bindingList = new BindingList<VisitorsInformation>(list);
                BindingSource source = new BindingSource(bindingList, null);
                DispInputGridView.DataSource = source;
                DispInputGridView.Show();

            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lblMnlInput.Text = "Visitor Information";
            MainGrpBox.Text = "Search Result";
            dispReportPanel.Hide();
            newVisitorEntryPanel.Hide();
            CheckOutTimepicker.Text = "";
            DispInputGridView.Hide();
            btnSave.Text = "Check Out";
            TxtInputPanel.Hide();
            string searchValue = txtSearchBox.Text;
            if (MuseumManagementSystem.Validators.ValidateEmailFormat(searchValue))
            {
                CSVSearch(searchValue);
            }
            else
            {
                lblMainMsg.Text = "Visitor Not Found!!!";
                lblMainMsg.Show();
            }
        }

        private void BtnReportGenerate_Click(object sender, EventArgs e)
        {
            lblMainMsg.Hide();
            newVisitorEntryPanel.Hide();
            DispInputGridView.Hide();
            if (File.Exists("CheckoutsInformation.csv"))
            {
                MainGrpBox.Text = "Report Section";
                dispReportPanel.Show();
            }
            else
            {
                MessageBox.Show("No visitors Checked Out Today !!!", "Error!");
            }
        }
        private void BtnDailyList_Click(object sender, EventArgs e)
        {
            List<VisitorsInformation> list = new List<VisitorsInformation>();

            using (Stream stream = new FileStream("CheckoutsInformation.csv", FileMode.Open, FileAccess.Read))
            {
                CsvChecker<VisitorsInformation> cs = new CsvChecker<VisitorsInformation>()
                {
                    UseTextQualifier = true,
                };
                list = cs.ReadFromFile(stream);
            }

            var date = reportDatePicker.Value.Date.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
            List<VisitorsInformation> filteredList = new List<VisitorsInformation>();
            foreach (VisitorsInformation v in list)
            {
                if (v.EntryDate.Equals(date))
                {
                    DateTime outTime = DateTime.Parse(v.CheckOutTime);
                    DateTime inTime = DateTime.Parse(v.CheckInTime);
                    TimeSpan diff = (outTime - inTime);
                    v.TotalDuration = Math.Round(diff.TotalMinutes, 2);
                    v.Day = reportDatePicker.Value.DayOfWeek.ToString();
                    filteredList.Add(v);
                }
            }

            MuseumManagementSystem.SortingAlgorithm sort = new MuseumManagementSystem.SortingAlgorithm();
            filteredList = sort.QuickSortByInTime(filteredList);

            BindingList<VisitorsInformation> bindingList = new BindingList<VisitorsInformation>(filteredList);
            BindingSource source = new BindingSource(bindingList, null);
            dispReportGridView.DataSource = source;
            dispReportGridView.Show();
            reportChart.Hide();
        }
        private void BtnWeeklyReport_Click(object sender, EventArgs e)
        {
            List<VisitorsInformation> list = new List<VisitorsInformation>();

            using (Stream stream = new FileStream("CheckoutsInformation.csv", FileMode.Open, FileAccess.Read))
            {
                CsvChecker<VisitorsInformation> cs = new CsvChecker<VisitorsInformation>()
                {
                    UseTextQualifier = true,
                };
                list = cs.ReadFromFile(stream);
            }

            var dateFrom = weeklyDatePicker.Value.Date;
            int dayindex = (int)dateFrom.DayOfWeek;
            int diff = 5 - dayindex;
            var dateTo = dateFrom.AddDays(diff);


            List<VisitorsInformation> filteredList = new List<VisitorsInformation>();
            foreach (VisitorsInformation v in list)
            {
                var date = DateTime.ParseExact(v.EntryDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (date >= dateFrom && date <= dateTo)
                {
                    DateTime outTime = DateTime.Parse(v.CheckOutTime);
                    DateTime inTime = DateTime.Parse(v.CheckInTime);
                    TimeSpan diffT = (outTime - inTime);
                    v.TotalDuration = Math.Round(diffT.TotalMinutes, 2);
                    v.Day = date.DayOfWeek.ToString();
                    filteredList.Add(v);
                }
            }

            List<ReportsWeekly> weekReport = GetWeekReport(filteredList);
            reportChart.Series.Clear();
            reportChart.Series.Add("Total Time Spent (In Minutes)");
         
            foreach (ReportsWeekly report in weekReport)
            {
                reportChart.Series["Total Time Spent (In Minutes)"].Points.AddXY(report.Day, report.TotalTimeSpent);
            }
            reportChart.Show();

            MuseumManagementSystem.SortingAlgorithm sort = new MuseumManagementSystem.SortingAlgorithm();
            BindingList<ReportsWeekly> bindingList = new BindingList<ReportsWeekly>(sort.QuickSortByTotalVisitor(weekReport));
            BindingSource source = new BindingSource(bindingList, null);
            dispReportGridView.DataSource = source;
            dispReportGridView.Show();
        }

        private void BtnDailyReport_Click(object sender, EventArgs e)
        {
            List<VisitorsInformation> list = new List<VisitorsInformation>();

            using (Stream stream = new FileStream("CheckoutsInformation.csv", FileMode.Open, FileAccess.Read))
            {
                CsvChecker<VisitorsInformation> cs = new CsvChecker<VisitorsInformation>()
                {
                    UseTextQualifier = true,
                };
                list = cs.ReadFromFile(stream);
            }

            var date = dailyDatePicker.Value.Date.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
            List<VisitorsInformation> filteredList = new List<VisitorsInformation>();
            foreach (VisitorsInformation v in list)
            {
                if (v.EntryDate.Equals(date))
                {
                    DateTime outTime = DateTime.Parse(v.CheckOutTime);
                    DateTime inTime = DateTime.Parse(v.CheckInTime);
                    TimeSpan diff = (outTime - inTime);
                    v.TotalDuration = Math.Round(diff.TotalMinutes, 2);
                    v.Day = inTime.DayOfWeek.ToString();
                    filteredList.Add(v);
                }
            }

            string day = dailyDatePicker.Value.DayOfWeek.ToString();
            List<ReportsWeekly> weekReport = GetWeekReport(filteredList);
            List<ReportsWeekly> finalWeeklyReport = new List<ReportsWeekly>();
            finalWeeklyReport.Add(weekReport.Find(a => a.Day.Equals(day)));

            BindingList<ReportsWeekly> bindingList = new BindingList<ReportsWeekly>(finalWeeklyReport);
            BindingSource source = new BindingSource(bindingList, null);
            dispReportGridView.DataSource = source;
            dispReportGridView.Show();
            reportChart.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateAndSave();

        }

        private void BtnCsvInput_Click(object sender, EventArgs e)
        {
            DialogResult result = csvOpenFileDialog.ShowDialog();
            List<VisitorsInformation> visitorList = new List<VisitorsInformation>();
            if (result == DialogResult.OK)
            {
                using (var stream = new FileStream(csvOpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    var cs = new CsvChecker<VisitorsInformation>()
                    {
                        UseTextQualifier = true
                    };

                    visitorList = cs.ReadFromFile(stream);
                    WriteCheckInDataToFile(visitorList);
                }
            }
            DispInputGridView.Hide();
            if (visitorList.Count > 0)
            {
                BindingList<VisitorsInformation> bindingList = new BindingList<VisitorsInformation>(visitorList);
                BindingSource source = new BindingSource(bindingList, null);
                DispInputGridView.DataSource = source;
                DispInputGridView.Show();
            }
        }

        private void ValidateAndSave()
        {
            List<VisitorsInformation> visitorList = new List<VisitorsInformation>();
            VisitorsInformation visitor = new VisitorsInformation();
            bool errorOccured = false;

            visitor.ID = Int64.Parse(visitorID.Text);
            visitor.EntryDate = dateToday.Text;
            visitor.CheckInTime = CheckInTimePicker.Text;
            if (CheckOutTimepicker.Visible)
                visitor.CheckOutTime = CheckOutTimepicker.Text;



            string fName = txtFirstName.Text;
            if (MuseumManagementSystem.Validators.ValidateEmpty(fName))
            {
                errFirstName.Hide();
                visitor.FirstName = fName;
            }
            else
            {
                errorOccured = true;
                errFirstName.Show();
            }

            string lName = txtLastName.Text;
            if (MuseumManagementSystem.Validators.ValidateEmpty(lName))
            {
                errLastName.Hide();
                visitor.LastName = lName;
            }
            else
            {
                errorOccured = true;
                errLastName.Show();
            }

            string address = txtAddress.Text;
            if (MuseumManagementSystem.Validators.ValidateEmpty(address))
            {
                errAddress.Hide();
                visitor.Address = address;
            }
            else
            {
                errorOccured = true;
                errAddress.Show();
            }

            string contact = txtContactNo.Text;
            if (MuseumManagementSystem.Validators.ValidateNumber(contact))
            {
                errContactNo.Hide();
                visitor.ContactNo = Int64.Parse(contact);
            }
            else
            {
                errorOccured = true;
                errContactNo.Show();
            }

            string mailAddress = txtEmailAddr.Text;
            if (MuseumManagementSystem.Validators.ValidateEmailFormat(mailAddress))
            {
                errEmailAddress.Hide();
                visitor.EmailAddress = mailAddress;
            }
            else
            {
                errorOccured = true;
                errEmailAddress.Show();
            }

            string occupation = txtOccupation.Text;
            if (MuseumManagementSystem.Validators.ValidateEmpty(occupation))
            {
                errOccupation.Hide();
                visitor.Occupation = occupation;
            }
            else
            {
                errorOccured = true;
                errOccupation.Show();
            }

            if (errorOccured == false)
            {
                visitorList.Add(visitor);
                bool abc = CheckOutTimepicker.Visible;
                if (CheckOutTimepicker.Visible)
                    WriteCheckoutDataToFile(visitorList);
                else
                    WriteCheckInDataToFile(visitorList);

                MessageBox.Show("Visitor successfully added.");
                btnNewVisitor.PerformClick();
            }

        }

        private void CSVSearch(string searchValue)
        {
            List<VisitorsInformation> searchedData = new List<VisitorsInformation>();

            if (File.Exists("CheckinsInformation.csv"))
            {
                using (Stream stream = new FileStream("CheckinsInformation.csv", FileMode.Open, FileAccess.Read))
                {
                    CsvChecker<VisitorsInformation> cs = new CsvChecker<VisitorsInformation>()
                    {
                        UseTextQualifier = true,
                    };

                    searchedData = cs.SearchInFile(stream, searchValue);
                }
            }
            else
            {
                lblMainMsg.Text = "Visitor Not Found";
                lblMainMsg.Show();

            }

            bool visitorFound = false;
            string dateTody = dateToday.Text;
            foreach (VisitorsInformation v in searchedData)
            {
                var abc = v.EntryDate;
                if (v.EntryDate.Equals(dateTody))
                {
                    visitorFound = true;

                    visitorID.Text = v.ID.ToString();
                    txtFirstName.Text = v.FirstName;
                    txtLastName.Text = v.LastName;
                    txtContactNo.Text = v.ContactNo.ToString();
                    txtAddress.Text = v.Address;
                    txtOccupation.Text = v.Occupation;
                    txtEmailAddr.Text = v.EmailAddress;
                    CheckInTimePicker.Text = v.CheckInTime;

                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtContactNo.Enabled = false;
                    txtAddress.Enabled = false;
                    txtEmailAddr.Enabled = false;
                    txtOccupation.Enabled = false;
                    CheckInTimePicker.Enabled = false;

                    lblOutTime.Show();
                    CheckOutTimepicker.Show();
                    newVisitorEntryPanel.Show();
                    lblMainMsg.Hide();
                    btnClear.Visible = false;
                }
            }

            if (!visitorFound)
            {
                lblMainMsg.Text = "Visitor Not Found";
                lblMainMsg.Show();
            }
        }

        private void WriteCheckInDataToFile(List<VisitorsInformation> visitorList)
        {
            if (File.Exists("CheckinsInformation.csv"))
            {
                using (Stream stream = new FileStream("CheckinsInformation.csv", FileMode.Open, FileAccess.ReadWrite))
                {
                    var cs = new CsvChecker<VisitorsInformation>()
                    {
                        UseTextQualifier = true
                    };
                    cs.AppendToFile(stream, visitorList, "CheckinsInformation.csv");
                }
            }
            else
            {
                using (Stream stream = new FileStream("CheckinsInformation.csv", FileMode.Create, FileAccess.Write))
                {
                    var cs = new CsvChecker<VisitorsInformation>
                    {
                        UseTextQualifier = true
                    };

                    cs.WriteToFile(stream, visitorList);
                }
            }

        }

        private void WriteCheckoutDataToFile(List<VisitorsInformation> visitorList)
        {
            if (File.Exists("CheckoutsInformation.csv"))
            {
                using (Stream stream = new FileStream("CheckoutsInformation.csv", FileMode.Open, FileAccess.ReadWrite))
                {
                    var cs = new CsvChecker<VisitorsInformation>()
                    {
                        UseTextQualifier = true
                    };
                    cs.AppendToFile(stream, visitorList, "CheckoutsInformation.csv");
                }
            }
            else
            {
                using (Stream stream = new FileStream("CheckoutsInformation.csv", FileMode.Create, FileAccess.Write))
                {
                    var cs = new CsvChecker<VisitorsInformation>
                    {
                        UseTextQualifier = true
                    };

                    cs.WriteToFile(stream, visitorList);
                }
            }
        }

        private List<ReportsWeekly> GetWeekReport(List<VisitorsInformation> list)
        {
            List<ReportsWeekly> resultList = new List<ReportsWeekly>();
            ReportsWeekly monday = new ReportsWeekly
            {
                Day = "Monday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            ReportsWeekly tuesday = new ReportsWeekly
            {
                Day = "Tuesday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            ReportsWeekly wednesday = new ReportsWeekly
            {
                Day = "Wednesday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            ReportsWeekly thursday = new ReportsWeekly
            {
                Day = "Thursday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            ReportsWeekly friday = new ReportsWeekly
            {
                Day = "Friday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            foreach (VisitorsInformation i in list)
            {
                var date = DateTime.ParseExact(i.EntryDate, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                int day = (int)date.DayOfWeek;

                switch (day)
                {
                    case 1:
                        monday.TotalVisitor++;
                        monday.TotalTimeSpent = monday.TotalTimeSpent + i.TotalDuration;
                        break;
                    case 2:
                        tuesday.TotalVisitor++;
                        tuesday.TotalTimeSpent = tuesday.TotalTimeSpent + i.TotalDuration;
                        break;
                    case 3:
                        wednesday.TotalVisitor++;
                        wednesday.TotalTimeSpent = wednesday.TotalTimeSpent + i.TotalDuration;
                        break;
                    case 4:
                        thursday.TotalVisitor++;
                        thursday.TotalTimeSpent = thursday.TotalTimeSpent + i.TotalDuration;
                        break;
                    case 5:
                        friday.TotalVisitor++;
                        friday.TotalTimeSpent = friday.TotalTimeSpent + i.TotalDuration;
                        break;

                    default:
                        break;
                }
            }

            resultList.Add(monday);
            resultList.Add(tuesday);
            resultList.Add(wednesday);
            resultList.Add(friday);
            resultList.Add(thursday);
            return resultList;
        }

        private void ResetVisitorsEntryForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            txtOccupation.Text = "";
            txtEmailAddr.Text = "";
            CheckInTimePicker.Text = "";
            lblOutTime.Hide();
            CheckOutTimepicker.Hide();

            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtContactNo.Enabled = true;
            txtAddress.Enabled = true;
            txtEmailAddr.Enabled = true;
            txtOccupation.Enabled = true;
            CheckInTimePicker.Enabled = true;
        }

        private void MuseumForm_Closed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.tempVisitorID = Int32.Parse(tempVisitorID.Text);
            Settings.Default.Save();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            txtOccupation.Text = "";
            txtEmailAddr.Text = "";
            CheckInTimePicker.Text = "";
            errFirstName.Visible = false;
            errLastName.Visible = false;
            errOccupation.Visible = false;
            errContactNo.Visible = false;
            errEmailAddress.Visible = false;
            errAddress.Visible = false;

        }

        private void errOccuptn_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
