﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Views.Base.Attributes;
using GeneWinForms.Views.Base.Resolver;

namespace GeneWinForms.Views.Test
{
    [View(ViewIdentity.TestsCollectionView)]
    public partial class TestCollectionView : TestCollectionBaseView
    {
        public TestCollectionView()
        {
            InitializeComponent();
        }
    }
}
