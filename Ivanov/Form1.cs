using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ivanov
{
    public partial class Form1 : Form
    {
        public Algorithm ProgramAlgorithm { get; private set; } = new Algorithm();
        public Form1()
        {
            InitializeComponent();
        }

		private void addVar_Click(object sender, EventArgs e)
		{
			varInfo.Text = varInfo.Text.Replace(" ", string.Empty);
			if (!string.IsNullOrEmpty(varInfo.Text))
			{
				if (varInfo.Text.Count(ch => ch == '=') != 1)
				{
					MessageBox.Show("Error!");
					varInfo.Text = string.Empty;
					return;
				}
				ProgramAlgorithm.Add(WorkType.Add, varInfo.Text);
				if (string.IsNullOrEmpty(Algorithm.Text))
				{
					Algorithm.Text = $"Set value ({varInfo.Text})";
				}
				else
				{
					Algorithm.Text += $" -> Set value ({varInfo.Text})";
				}
				varInfo.Text = string.Empty;
			}
		}
		private void print_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(printInfo.Text))
            {
                ProgramAlgorithm.Add(WorkType.Print, printInfo.Text);
                if (string.IsNullOrEmpty(Algorithm.Text))
                {
                    Algorithm.Text = $"Print ({printInfo.Text})";
                }
                else
                {
                    Algorithm.Text += $" -> Print ({printInfo.Text})";
                }
                printInfo.Text = string.Empty;
            }
        }

        #region smth
        private void InitializeComponent()
        {
			this.print = new System.Windows.Forms.Button();
			this.varInfo = new System.Windows.Forms.TextBox();
			this.printInfo = new System.Windows.Forms.TextBox();
			this.equalInfo = new System.Windows.Forms.TextBox();
			this.equality = new System.Windows.Forms.Button();
			this.addVar = new System.Windows.Forms.Button();
			this.Algorithm = new System.Windows.Forms.RichTextBox();
			this.Save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// print
			// 
			this.print.Font = new System.Drawing.Font("Minion Pro", 12F);
			this.print.Location = new System.Drawing.Point(12, 138);
			this.print.Name = "print";
			this.print.Size = new System.Drawing.Size(141, 44);
			this.print.TabIndex = 1;
			this.print.Text = "Print";
			this.print.UseVisualStyleBackColor = true;
			this.print.Click += new System.EventHandler(this.print_Click);
			// 
			// varInfo
			// 
			this.varInfo.Location = new System.Drawing.Point(12, 18);
			this.varInfo.Name = "varInfo";
			this.varInfo.Size = new System.Drawing.Size(141, 24);
			this.varInfo.TabIndex = 5;
			this.varInfo.TextChanged += new System.EventHandler(this.varInfo_TextChanged);
			// 
			// printInfo
			// 
			this.printInfo.Location = new System.Drawing.Point(12, 112);
			this.printInfo.Name = "printInfo";
			this.printInfo.Size = new System.Drawing.Size(141, 24);
			this.printInfo.TabIndex = 7;
			this.printInfo.TextChanged += new System.EventHandler(this.printName_TextChanged);
			// 
			// equalInfo
			// 
			this.equalInfo.Location = new System.Drawing.Point(12, 198);
			this.equalInfo.Name = "equalInfo";
			this.equalInfo.Size = new System.Drawing.Size(141, 24);
			this.equalInfo.TabIndex = 8;
			this.equalInfo.TextChanged += new System.EventHandler(this.equalInfo_TextChanged);
			// 
			// equality
			// 
			this.equality.Font = new System.Drawing.Font("Minion Pro", 12F);
			this.equality.Location = new System.Drawing.Point(12, 224);
			this.equality.Name = "equality";
			this.equality.Size = new System.Drawing.Size(141, 44);
			this.equality.TabIndex = 9;
			this.equality.Text = "Func";
			this.equality.UseVisualStyleBackColor = true;
			this.equality.Click += new System.EventHandler(this.equality_Click);
			// 
			// addVar
			// 
			this.addVar.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addVar.Location = new System.Drawing.Point(12, 44);
			this.addVar.Name = "addVar";
			this.addVar.Size = new System.Drawing.Size(141, 44);
			this.addVar.TabIndex = 10;
			this.addVar.Text = "Value";
			this.addVar.UseVisualStyleBackColor = true;
			this.addVar.Click += new System.EventHandler(this.addVar_Click);
			// 
			// Algorithm
			// 
			this.Algorithm.BackColor = System.Drawing.SystemColors.Menu;
			this.Algorithm.Location = new System.Drawing.Point(169, 18);
			this.Algorithm.Name = "Algorithm";
			this.Algorithm.Size = new System.Drawing.Size(413, 164);
			this.Algorithm.TabIndex = 14;
			this.Algorithm.Text = "";
			this.Algorithm.TextChanged += new System.EventHandler(this.Algorithm_TextChanged);
			// 
			// Save
			// 
			this.Save.Font = new System.Drawing.Font("Minion Pro", 12F);
			this.Save.Location = new System.Drawing.Point(169, 198);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(413, 70);
			this.Save.TabIndex = 16;
			this.Save.Text = "SAVE";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(594, 286);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Algorithm);
			this.Controls.Add(this.addVar);
			this.Controls.Add(this.equality);
			this.Controls.Add(this.equalInfo);
			this.Controls.Add(this.printInfo);
			this.Controls.Add(this.varInfo);
			this.Controls.Add(this.print);
			this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private void varList_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Algorithm_TextChanged(object sender, EventArgs e)
        {

        }

        private void printName_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void varInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void equalInfo_TextChanged(object sender, EventArgs e)
        {

        }
		#endregion

		private void Form1_Load_1(object sender, EventArgs e)
		{
			Algorithm.Enabled = false;
		}

		private void Start_Click(object sender, EventArgs e)
		{

		}

		private void algorithmLabel_Click(object sender, EventArgs e)
		{

		}

		private void Save_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void equality_Click(object sender, EventArgs e)
        {
            equalInfo.Text = equalInfo.Text.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(equalInfo.Text) && equalInfo.Text.Count(ch => ch == '?') == 1 && equalInfo.Text.Count(ch => ch == ':') == 1)
            {
                ProgramAlgorithm.Add(WorkType.Equality, equalInfo.Text);
                if (string.IsNullOrEmpty(Algorithm.Text))
                {
                    Algorithm.Text = $"Equality ({equalInfo.Text})";
                }
                else
                {
                    Algorithm.Text += $" -> Equality ({equalInfo.Text})";
                }
                equalInfo.Text = string.Empty;
            }
        }

       
    }
}

public enum WorkType
{
    Add,
    Print,
    Equality
}

public class Algorithm
{
    private List<Tuple<WorkType, string>> algorithm { get; set; }

    public Algorithm()
    {
        algorithm = new List<Tuple<WorkType, string>>();
    }

    public void Add(WorkType workType, string text)
    {
        algorithm.Add(new Tuple<WorkType, string>(workType, text));
    }

    public void DoAlgorithm(Dictionary<string, int> algDict, int numOfAlg = 0)
    {
        foreach (var step in algorithm)
        {
            switch (step.Item1)
            {
                case WorkType.Add:
                    Add_worktype(step.Item2, algDict);
                    break;
                case WorkType.Print:
                    MessageBox.Show(algDict.ContainsKey(step.Item2) ? algDict[step.Item2].ToString() : step.Item2, $"Print ({step.Item2})");
                    break;
                case WorkType.Equality:
                    var conditionTxt = step.Item2.Substring(0, step.Item2.IndexOf('?'));
                    var trueCondText = step.Item2.Substring(step.Item2.IndexOf('?') + 1, step.Item2.IndexOf(':') - step.Item2.IndexOf('?') - 1);
                    var falseCondText = step.Item2.Substring(step.Item2.IndexOf(':') + 1);
                    if (checkCondition(conditionTxt, algDict))
                    {
                        Add_worktype(trueCondText, algDict);
                    }
                    else
                    {
                        Add_worktype(falseCondText, algDict);
                    }
                    break;
                default:
                    MessageBox.Show("Error!");
                    break;
            }
        }
        MessageBox.Show(string.Join("\n", algDict.Select(varInfo => $"{varInfo.Key} = {varInfo.Value}")), $"Result ({numOfAlg})");
    }

   

    private bool checkCondition(string condition, Dictionary<string, int> vars)
    {
        var f1 = condition.IndexOf(condition.First(ch => !Char.IsLetterOrDigit(ch)));
        var l1 = condition.LastIndexOf(condition.Last(ch => !Char.IsLetterOrDigit(ch)));

        var val1Text = condition.Substring(0, f1);
        var val2Text = condition.Substring(l1 + 1);

        var check = condition.Substring(f1, l1 - f1 + 1);

        var value1 = val1Text.Any(ch => !Char.IsDigit(ch)) ? vars[val1Text] : Convert.ToInt32(val1Text);
        var value2 = val2Text.Any(ch => !Char.IsDigit(ch)) ? vars[val2Text] : Convert.ToInt32(val2Text);

        switch (check)
        {
            case "==":
                return value1 == value2;
            case "<=":
                return value1 <= value2;
            case ">=":
                return value1 >= value2;
            case "<":
                return value1 < value2;
            case ">":
                return value1 > value2;
            default:
                return false;
        }
    }

	private void Add_worktype(string text, Dictionary<string, int> algDict)
	{
		var fieldInfo = text.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
		var fieldVal = fieldInfo[1].Any(symbol => !Char.IsDigit(symbol)) ?
			algDict.ContainsKey(fieldInfo[1]) ? algDict[fieldInfo[1]].ToString() : string.Empty :
			fieldInfo[1].ToString();
		if (string.IsNullOrEmpty(fieldVal))
		{
			MessageBox.Show("Error!");
			return;
		}
		if (!algDict.ContainsKey(fieldInfo[0]))
		{
			algDict.Add(fieldInfo[0], Convert.ToInt32(fieldVal));
		}
		else
		{
			algDict[fieldInfo[0]] = Convert.ToInt32(fieldVal);
		}
	}
}