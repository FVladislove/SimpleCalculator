using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        List<RadioButton> firstOperandsRadioButtons = new List<RadioButton>();
        List<TextBox> firstOperandInputs = new List<TextBox>();

        List<RadioButton> secondOperandsRadioButtons = new List<RadioButton>();
        List<TextBox> secondOperandInputs = new List<TextBox>();

        private RadioButton _currentFirstGroupboxRadioButton = null;

        private RadioButton _currentThirdGroupboxRadioButton = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeNumOfGroupboxRadiobuttonsAndTextBoxes(
            GroupBox groupBox,
            List<RadioButton> radioButtons,
            List<TextBox> textBoxes,
            int numOfElements)
        {
            if (textBoxes.Count == 0)
            {
                // data initialization
                AddElementsToGroupboxList(
                    groupBox.Name,
                    radioButtons,
                    textBoxes,
                    numOfElements,
                    20,
                    20);
            }
            else
            {
                int difference = textBoxes.Count - numOfElements;

                if (difference < 0)
                {
                    AddElementsToGroupboxList(
                        groupBox.Name,
                        radioButtons,
                        textBoxes,
                        -difference,
                        radioButtons.Last().Left,
                        textBoxes.Last().Top + 40);
                }

                if (difference > 0)
                {
                    radioButtons.RemoveRange(
                        radioButtons.Count - difference,
                        difference
                    );
                    textBoxes.RemoveRange(
                        textBoxes.Count - difference,
                        difference);
                }
            }

            AddRadioButtonsAndTextBoxesToGroupbox(groupBox, radioButtons, textBoxes);
        }

        private void AddElementsToGroupboxList(
            string parent,
            List<RadioButton> radioButtons,
            List<TextBox> textBoxes,
            int numOfElements,
            int left,
            int top)
        {
            for (int i = 0; i < numOfElements; i++)
            {
                var radioButton = new RadioButton();
                radioButton.SetBounds(left, top + i * 40, 20, 20);
                radioButton.Click += radioButton_Click;

                var textBox = new TextBox();
                textBox.SetBounds(left + 30, top + i * 40, 60, 20);
                textBox.Enabled = false;
                
                // indexing in the title begins from 0
                // so since you remove certain elements
                // there was a bug where several RadioButtons pointed to one TextBox
                if (radioButtons.Count != 0)
                {
                    radioButton.Name = parent + @":radioButton:" + radioButtons.Count;
                    textBox.Name = parent + @":textBox:" + radioButtons.Count;
                }
                else
                {
                    radioButton.Name = parent + @":radioButton:" + i;
                    textBox.Name = parent + @":textBox:" + i;
                }
                
                radioButtons.Add(radioButton);
                textBoxes.Add(textBox);
            }
        }

        private void AddRadioButtonsAndTextBoxesToGroupbox(
            GroupBox groupBox,
            List<RadioButton> radioButtons,
            List<TextBox> textBoxes)
        {
            groupBox.Controls.Clear();
            for (int i = 0; i < radioButtons.Count; i++)
            {
                groupBox.Controls.Add(radioButtons[i]);
                groupBox.Controls.Add(textBoxes[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeNumOfGroupboxRadiobuttonsAndTextBoxes(
                groupBox1,
                firstOperandsRadioButtons,
                firstOperandInputs,
                Convert.ToInt32(numericUpDown1.Value));
            ChangeNumOfGroupboxRadiobuttonsAndTextBoxes(
                groupBox3,
                secondOperandsRadioButtons,
                secondOperandInputs,
                Convert.ToInt32(numericUpDown2.Value));

            if (_currentFirstGroupboxRadioButton != null &&
                _currentThirdGroupboxRadioButton != null)
            {
                int firstIdx = Convert.ToInt32(_currentFirstGroupboxRadioButton
                    .Name
                    .Split(':')
                    [2]);
                int secondIdx = Convert.ToInt32(_currentThirdGroupboxRadioButton
                    .Name
                    .Split(':')
                    [2]);

                // there was a bug, when deleted element was saved in current elements
                // do not change it to null, because initialization will take place again
                if (firstOperandInputs.Count <= firstIdx || secondOperandInputs.Count <= secondIdx)
                {
                    return;
                }
                if (float.TryParse(firstOperandInputs[firstIdx].Text, out float firstValue)
                    && float.TryParse(secondOperandInputs[secondIdx].Text, out float secondValue))
                {
                    if (AddCheckBox.Checked)
                    {
                        label1.Text = (firstValue + secondValue).ToString();
                    }

                    if (MinusCheckBox.Checked)
                    {
                        label1.Text = (firstValue - secondValue).ToString();
                    }

                    if (MultiplyCheckBox.Checked)
                    {
                        label1.Text = (firstValue * secondValue).ToString();
                    }
                }
            }
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            var radioButton = (RadioButton) sender;
            var nameParts = radioButton.Name.Split(':');

            if (nameParts[0] == "groupBox1")
            {
                if (_currentFirstGroupboxRadioButton != null)
                {
                    int currentIdx = Convert.ToInt32(_currentFirstGroupboxRadioButton
                        .Name
                        .Split(':')[2]);
                    
                    // previous element
                    firstOperandInputs[currentIdx].Enabled = false;
                    // new element
                    firstOperandInputs[Convert.ToInt32(nameParts[2])].Enabled = true;
                    
                    _currentFirstGroupboxRadioButton = radioButton;
                }
                else
                {
                    // initialization
                    firstOperandInputs[Convert.ToInt32(nameParts[2])].Enabled = true;

                    _currentFirstGroupboxRadioButton = radioButton;
                }
            }

            if (nameParts[0] == "groupBox3")
            {
                if (_currentThirdGroupboxRadioButton != null)
                {
                    int currentIdx = Convert.ToInt32(_currentThirdGroupboxRadioButton
                        .Name
                        .Split(':')
                        [2]);
                    
                    // previous element
                    secondOperandInputs[currentIdx].Enabled = false;
                    // new element
                    secondOperandInputs[Convert.ToInt32(nameParts[2])].Enabled = true;
                    
                    _currentThirdGroupboxRadioButton = radioButton;
                }
                else
                {
                    secondOperandInputs[Convert.ToInt32(nameParts[2])].Enabled = true;

                    _currentThirdGroupboxRadioButton = radioButton;
                }
            }
        }
    }
}