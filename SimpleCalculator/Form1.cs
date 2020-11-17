using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private readonly List<RadioButton> _firstOperandsRadioButtons = new List<RadioButton>();
        private readonly List<TextBox> _firstOperandInputs = new List<TextBox>();

        private readonly List<RadioButton> _secondOperandsRadioButtons = new List<RadioButton>();
        private readonly List<TextBox> _secondOperandInputs = new List<TextBox>();

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
            string groupBoxName,
            List<RadioButton> radioButtons,
            List<TextBox> textBoxes,
            int numOfElements,
            int left,
            int top)
        {
            if (radioButtons.Count >= 7)
            {
                numOfElements = 0;
            }
            else
            {
                if (radioButtons.Count + numOfElements > 7)
                {
                    numOfElements = 7 - radioButtons.Count;
                }
            }
            for (int i = 0; i < numOfElements; i++)
            {
                var radioButton = new RadioButton();
                radioButton.SetBounds(left, top + i * 40, 20, 20);
                switch (groupBoxName)
                {
                    case "groupBox1":
                        radioButton.Click += firstGroupboxRadioButton_Click;
                        break;
                    case "groupBox3":
                        radioButton.Click += secondGroupboxRadioButton_Click;
                        break;
                }

                var textBox = new TextBox();
                textBox.SetBounds(left + 30, top + i * 40, 60, 20);
                textBox.Enabled = false;

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
                _firstOperandsRadioButtons,
                _firstOperandInputs,
                Convert.ToInt32(numericUpDown1.Value));
            ChangeNumOfGroupboxRadiobuttonsAndTextBoxes(
                groupBox3,
                _secondOperandsRadioButtons,
                _secondOperandInputs,
                Convert.ToInt32(numericUpDown2.Value));
            int firstOperandIdx = -1;
            int secondOperandIdx = -1;
            for (int i = 0; i < _firstOperandInputs.Count; i++)
            {
                if (_firstOperandInputs[i].Enabled)
                {
                    firstOperandIdx = i;
                }
            }

            for (int i = 0; i < _secondOperandInputs.Count; i++)
            {
                if (_secondOperandInputs[i].Enabled)
                {
                    secondOperandIdx = i;
                }
            }

            if (firstOperandIdx != -1 && secondOperandIdx != -1)
            {
                float.TryParse(_firstOperandInputs[firstOperandIdx].Text, out float firstOperand);
                float.TryParse(_secondOperandInputs[secondOperandIdx].Text, out float secondOperand);
                
                if (AddRadioButton.Checked)
                {
                    ResultLabel.Text = (firstOperand + secondOperand).ToString();
                }

                if (MinusRadioButton.Checked)
                {
                    ResultLabel.Text = (firstOperand - secondOperand).ToString();
                }

                if (MultiplyRadioButton.Checked)
                {
                    ResultLabel.Text = (firstOperand * secondOperand).ToString();
                }
            }
        }
        private void firstGroupboxRadioButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _firstOperandInputs.Count; i++)
            {
                if (_firstOperandsRadioButtons[i].Checked)
                {
                    _firstOperandInputs[i].Enabled = true;
                }
                else
                {
                    _firstOperandInputs[i].Enabled = false;
                }
            }
        }

        private void secondGroupboxRadioButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _secondOperandsRadioButtons.Count; i++)
            {
                if (_secondOperandsRadioButtons[i].Checked)
                {
                    _secondOperandInputs[i].Enabled = true;
                }
                else
                {
                    _secondOperandInputs[i].Enabled = false;
                }
            }
        }
    }
}