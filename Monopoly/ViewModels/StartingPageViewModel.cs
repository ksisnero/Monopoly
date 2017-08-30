using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Windows;

namespace Monopoly.ViewModels
{
    [POCOViewModel]
    public class StartingPageViewModel
    {
        public virtual string UserInput { get; set; }
        public virtual string Content { get; set; }

        public int HighestNumberTranslated;

        public int ValidateUserInput()
        {
            //get userinput and convert to int
            try
            {
                HighestNumberTranslated = int.Parse(UserInput);
            }
            catch (Exception)
            {
                MessageBox.Show("Input not valid!");
                HighestNumberTranslated = 0;
            }
            return HighestNumberTranslated;
        }

        public void Players()
        {
            for (int i = 0; i > HighestNumberTranslated + 1; i++)
            {
                Content += $"Insert Player {i} Name";
            }
        }
    }
}
