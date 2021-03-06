﻿using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMCWorkbench.DB;

namespace TMCWorkbench
{
    public partial class FormTest : Form
    {
        public DBManager DB = DBManager.Instance;

        public FormTest()
        {
            InitializeComponent();

            DB.LoadComposers();
            DB.LoadSceneGroups();
            DB.LoadGroupsComposers();
        }
    }
}
