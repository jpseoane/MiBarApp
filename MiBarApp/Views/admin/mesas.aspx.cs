using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsConOAuthNemiro
{
    public partial class qr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            //BarcodeWriter br = new BarcodeWriter();
            Bitmap bm = new Bitmap(br.Write(this.txtNumMesa.Value),300,300);

        }
    }
}