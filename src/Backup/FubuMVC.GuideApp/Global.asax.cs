﻿using FubuMVC.Core;
using FubuMVC.StructureMap.Bootstrap;

namespace FubuMVC.GuideApp
{
    public class Global : FubuStructureMapApplication
    {
    }
/* This "Global" class can be used if you want to do some of the stuff in the "Advanced Behaviors" guide  
    public class Global : FubuStructureMapApplication
    {
        public override FubuRegistry GetMyRegistry()
        {   
            return new AdvBehaviorGuideRegistry();
        }
        
    }
 */
}