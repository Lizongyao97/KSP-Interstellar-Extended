﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FNPlugin.Extensions
{
    class OceanicResource
    {
        protected string resourcename;
        protected double abundance;
        protected string displayname;

        public OceanicResource(string resourcename, double abundance, string displayname)
        {
            this.resourcename = resourcename;
            this.abundance = abundance;
            this.displayname = displayname;
        }

        public string DisplayName
        {
            get { return displayname; }
        }

        public string ResourceName
        {
            get { return resourcename; }
        }

        public double ResourceAbundance
        {
            get { return abundance; }
        }
    }
}