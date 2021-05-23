using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballPlus_WF.SetupOptions
{
    public class StartSetup
    {
        public void CheckIfOptionFileExists()
        {

        }



        public void DisplaySetupForm()
        {
            Form setupPopUp = new OptionsPopupForm();
            DialogResult dialogResult = setupPopUp.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                setupPopUp.Dispose();
            }
        }
    }
 }

