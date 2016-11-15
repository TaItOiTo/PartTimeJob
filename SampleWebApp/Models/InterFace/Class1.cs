using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models.InterFace
{
    public interface IDispMst
    {
        int ID { get; }
        string DispName { get; }
    }
}