using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar.ViewInfo;
using DevExpress.XtraNavBar;
using System.Reflection;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
    }

    public class MyNavBarControl : NavBarControl
    {
        public MyNavBarControl() : base() { }
        protected override NavBarViewInfo CreateViewInfo()
        {
            return new MyExplorerBarNavBarViewInfo(this);
        }
    }


    public class MyExplorerBarNavBarViewInfo : ExplorerBarNavBarViewInfo
    {
        const int currentNavBarScrollSpeed = 20;
        
        public MyExplorerBarNavBarViewInfo(NavBarControl navBarControl) : base(navBarControl) { }

        public override int TopY
        {
            get
            {
                return base.TopY;
            }
            set
            {
                bool isUp = base.TopY < value;
                base.TopY = isUp ? value + currentNavBarScrollSpeed : value - currentNavBarScrollSpeed;
            }
        }
    }
}
