using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.IO;
using Calculator.Wfa.DataLayer;

namespace Calculator.Wfa
{
    public partial class CalculatorForm : Form
    {
        private  List<InputPanel> _inputPanel = new List<InputPanel>();
        private List<OutputPanel> _outputPanels = new List<OutputPanel>();
        private AppDbContext _appContext = new AppDbContext();
        public int InputLevel { get { return _inputPanel.Count; } }
        public int OutputLevel { get { return _outputPanels.Count; } }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void RefreshState()
        {
            var index = 0;
            foreach (var panel in _inputPanel)
            {
                panel.Location = new Point(0, 75 * index++);
            }
        }

        public void RefreshArea()
        {
            if (double.TryParse(FloorLengthTextBox.Text, out double resultLength) && double.TryParse(FloorWidthTextBox.Text, out double resultWidth))
            {
                AreaLbl.Text = $"Floor area: {resultLength * resultWidth} m2";
                return;
            }
            AreaLbl.Text = "Invalid format";
        }

        private double Round(double value)
        {
            var integerParts = value.ToString().Split(',');
            if (integerParts.Length == 2 && Convert.ToDouble(integerParts[1]) > 0d)
            {
                return Convert.ToDouble(integerParts[0]) + 1;
            }
            return value;
        }

        private string GetResultValue(InputPanel element)
        {
            if (
                double.TryParse(element.LengthNumeric.Value.ToString(), out double resultLength) &&
                double.TryParse(element.WidthNumeric.Value.ToString(), out double resultWidth) &&
                double.TryParse(FloorLengthTextBox.Text, out double floorLength) &&
                double.TryParse(FloorWidthTextBox.Text, out double floorWidth)
               )
            {
                double result;
                if (
                    !(element.InputNameLbl.Text.Equals("Carpet") ||
                    element.InputNameLbl.Text.Equals("Linoleum"))
                   )
                {
                    result =
                        Round(floorLength / resultLength) *
                        Round(floorWidth / resultWidth);

                    return $"{result} pcs.";
                }
                result =
                    Round(floorLength) *
                    Round(floorWidth / resultWidth);

                return $"{result} m.";
            }
            return "Invalid input data!";
        }

        private void GetInputUserControl(string coverageTypeName, CheckBox coverageTypeCheckBox)
        {
            InputPanel tmpUserControlPanel;
            if (coverageTypeCheckBox.Checked)
            {
                tmpUserControlPanel = new InputPanel();
                tmpUserControlPanel.InputNameLbl.Text = coverageTypeName;
                if (coverageTypeName == "Carpet" || coverageTypeName == "Linoleum")
                {
                    tmpUserControlPanel.LengthNumeric.Visible = false;
                    tmpUserControlPanel.LengthLbl.Visible = false;
                }
                tmpUserControlPanel.Location = new Point(0, InputLevel * 75);
                _inputPanel.Add(tmpUserControlPanel);
                InputPanel.Controls.Add(tmpUserControlPanel);
                return;
            }
            var getPanelForDelete = _inputPanel.FirstOrDefault(panel => panel.InputNameLbl.Text.Equals(coverageTypeName));
            if (getPanelForDelete != null)
            {
                InputPanel.Controls.Remove(getPanelForDelete);
                _inputPanel.Remove(getPanelForDelete);
                RefreshState();
            }
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            OutputPanel.Controls.Clear();
            _outputPanels.Clear();
            OutputPanel tmpUserControlPanel;
            ResultLogLbl.Text = $"Project name: {ProjectNameTextBox.Text}\r\n" +
                    $"Created: {DateTime.UtcNow}\r\n" +
                    $"Items selected:\r\n";
            foreach (var inputPanel in _inputPanel)
            {
                tmpUserControlPanel = new OutputPanel();
                var resultValue = GetResultValue(inputPanel);
                tmpUserControlPanel.ResultValueLbl.Text = $"min consumption of {inputPanel.InputNameLbl.Text.ToLower()}: {resultValue}";
                tmpUserControlPanel.Location = new Point(0, OutputLevel * 75);
                _outputPanels.Add(tmpUserControlPanel);
                OutputPanel.Controls.Add(tmpUserControlPanel);
                ResultLogLbl.Text += $"{OutputLevel}. {inputPanel.InputNameLbl.Text} with min consumption: {resultValue}\r\n";
            }
        }

        private void CeramicTileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetInputUserControl("Ceramic tile", CeramicTileCheckBox);
        }

        private void LinoleumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetInputUserControl("Linoleum", LinoleumCheckBox);
        }

        private void ParquetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetInputUserControl("Parquet", ParquetCheckBox);
        }

        private void ParquetBoardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetInputUserControl("Parquet board", ParquetBoardCheckBox);
        }

        private void CarpetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetInputUserControl("Carpet", CarpetCheckBox);
        }

        private void LaminateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetInputUserControl("Laminate", LaminateCheckBox);
        }

        private void FloorLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshArea();
        }

        private void FloorWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshArea();
        }

        private void ClearCheckBoxesBtn_Click(object sender, EventArgs e)
        {
            CarpetCheckBox.Checked = false;
            CeramicTileCheckBox.Checked = false;
            LaminateCheckBox.Checked = false;
            LinoleumCheckBox.Checked = false;
            ParquetBoardCheckBox.Checked = false;
            ParquetCheckBox.Checked = false;
            OutputPanel.Controls.Clear();
            _outputPanels.Clear();
            InputPanel.Controls.Clear();
            _inputPanel.Clear();
            ResultLogLbl.Text = string.Empty;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            using (var stream = new StreamWriter(@"D:/results.doc"))
            {

                stream.WriteLine($"Project name: {ProjectNameTextBox.Text}");
                stream.WriteLine($"Created: {DateTime.UtcNow}");
                stream.WriteLine($"{AreaLbl.Text}");
                foreach (var inputPanel in _inputPanel)
                {
                    var resultValue = GetResultValue(inputPanel);
                    stream.WriteLine($"Coverage type: {inputPanel.InputNameLbl.Text}\r\n\tWith minimal consuption: {resultValue}");
                }
                MessageBox.Show(@"Saved at D:/results.doc", "Notification windows");
            }
        }

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            DataBase dataBase= new DataBase();
            dataBase.Show();
            //DbInitializer.Seed(_appContext);
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}