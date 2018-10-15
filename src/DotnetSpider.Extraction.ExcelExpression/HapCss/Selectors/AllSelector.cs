﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSpider.Extraction.ExcelExpression.HapCss.Selectors
{
    internal class AllSelector : CssSelector
    {
        public override string Token
        {
            get { return "*"; }
        }

        protected internal override IEnumerable<HtmlNode> FilterCore(IEnumerable<HtmlNode> currentNodes)
        {
            return currentNodes;
        }
    }
}