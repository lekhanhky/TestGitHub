using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace TestGithub.Module.BusinessObjects.TestGithub
{

    public partial class Master
    {
        public Master(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
