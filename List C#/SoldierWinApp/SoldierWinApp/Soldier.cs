using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoldierWinApp
{
    public partial class Soldier : Form
    {
        List<string> soldierNos = new List<string>();
        List<string> soldierNames = new List<string>();
        List<int> score1s = new List<int>();
        List<int> score2s = new List<int>();
        List<int> score3s = new List<int>();
        List<int> score4s = new List<int>();
        List<double> averages = new List<double>();
        List<double> sums = new List<double>();



        public Soldier()
        {
            InitializeComponent();
        }

        private void Soldier_Load(object sender, EventArgs e)
        {
            soldierNoRadioButton.Checked = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {

            try
            {
                string soldierNo;
                string soldierName;
                //string soldierName = soldierNameTextBox.Text;
                int score1 = Convert.ToInt32(score1TextBox.Text);
                int score2 = Convert.ToInt32(score2TextBox.Text);
                int score3 = Convert.ToInt32(score3TextBox.Text);
                int score4 = Convert.ToInt32(score4TextBox.Text);
                double[] array = { score1, score2, score3, score4 };
                double totalvalue = array.Sum();


                soldierNoLabel.Text = "";
                soldierNameLabel.Text = "";


                if (!String.IsNullOrEmpty(soldierNoTextBox.Text))
                {
                    bool isTrue = false;
                    soldierNo = soldierNoTextBox.Text;

                    isTrue = IsExist(soldierNo);
                    if (isTrue)
                    {
                        soldierNoLabel.Text = "Soldier Already Exist!";
                        return;

                    }
                }
                else
                {
                    soldierNoLabel.Text = "Soldier No can not be Empty!";
                    return;
                }


                if (!String.IsNullOrEmpty(soldierNameTextBox.Text))
                {
                    bool isTrue = false;
                    soldierName = soldierNameTextBox.Text;

                    isTrue = IsExistName(soldierName);
                    if (isTrue)
                    {
                        soldierNameLabel.Text = "Soldier Name Already Exist!";
                        return;

                    }
                }
                else
                {
                    soldierNameLabel.Text = "Soldier Name can not be Empty!";
                    return;
                }

                soldierNos.Add(soldierNo);
                soldierNames.Add(soldierName);
                score1s.Add(score1);
                score2s.Add(score2);
                score3s.Add(score3);
                score4s.Add(score4);
                sums.Add(totalvalue);
                averages.Add(totalvalue / 4);
                MessageBox.Show("Saved!");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }



        }



        private bool IsExist(string soldierNo)
        {
            bool isExist = false;
            foreach (string userChk in soldierNos)
            {
                if (soldierNo == userChk)
                    isExist = true;
            }
            return isExist;
        }

        private bool IsExistName(string soldierName)
        {
            bool isExist = false;
            foreach (string userChk in soldierNames)
            {
                if (soldierName == userChk)
                    isExist = true;
            }
            return isExist;
        }


        private void ShowButton_Click(object sender, EventArgs e)
        {


            displayRichTextBox.Text = Display();



        }

        private string Display()
        {

            string message = "";
            int index = 0;


            message = "Sl\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";

            foreach (string soldierNo in soldierNos)
            {

                message = message + (index + 1) + "\t" + soldierNo + "\t" + soldierNames[index] + "\t" + averages[index] + "\t" + sums[index] + "\n";
                index++;

            }


            double topAvg = 0;
            double topTotal = 0;
            int j;


            for (index = 0; index < soldierNos.Count; index++)
            {
                if (topAvg < averages[index])
                {
                    topAvg = averages[index];
                    j = index;
                    string name = soldierNames[j];
                    topAvgTextBox.Text = name;
                }
                if (topTotal < averages[index])
                {
                    topTotal = averages[index];
                    j = index;
                    string name = soldierNames[j];
                    topTotalTextBox.Text = name;
                }
            }

            return message;

        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            
           
            string message = "";
            int index = 0;

            if (soldierNoRadioButton.Checked == true)
            {


                message = "Sl\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";

                displayRichTextBox.Text = "";
                
                

                for (index = 0; index < soldierNos.Count; index++)
                {

                    if (searchTextBox.Text == soldierNos[index])
                    {
                        displayRichTextBox.Text =
                        message + (index + 1) + "\t" + soldierNos[index] + "\t" + soldierNames[index] + "\t" + averages[index] + "\t" + sums[index] + "\n";
                        
                        
                    }
                    //else if (!(searchTextBox.Text == soldierNos[index]))
                    //{

                    //    MessageBox.Show("Not found");
                    //    return;
                    //}

                }
                   


            }


        
            else if (soldierNameRadioButton.Checked == true)
            {


                message = "Sl\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";

                for (index = 0; index < soldierNames.Count; index++)
                {

                    if (searchTextBox.Text == soldierNames[index])
                    {
                        displayRichTextBox.Text =
                         message + (index + 1) + "\t" + soldierNos[index] + "\t" + soldierNames[index] + "\t" + averages[index] + "\t" + sums[index] + "\n";

                    }

                }
              
            }
            else
            {
                MessageBox.Show("You haven't selected anything! ");

                return;
            }

 
        }


 


    /*

    private bool SoldierNameExist(string soldierName)
    {
        bool SoldierNameExist = false;
        foreach (string soldierNameChk in soldierNames)
        {
            if (soldierName == soldierNameChk)
                SoldierNameExist = true;
        }
        return SoldierNameExist;
    }

*/

}


}


 