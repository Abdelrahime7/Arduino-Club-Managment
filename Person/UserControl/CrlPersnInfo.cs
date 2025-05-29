using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;

namespace WAMEEDHLAST
{
    public partial class CrlPersnInfo : UserControl
    {

        public CrlPersnInfo()
        {
            InitializeComponent();
        }

        public void LoadC(ClsBIPerson person)
        {


            if (person!=null)
            {
                lbPesronID.Text = person.PersonID.ToString();
                LbFirstName.Text = person.FirstName;
                LblasetName.Text = person.LastName;
            }

          
            
        
        }

      
    }
}
