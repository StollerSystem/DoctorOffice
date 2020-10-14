#pragma checksum "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e2e993bc20f40cb1f0bd4fa0af9e9014bd6033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Details), @"mvc.1.0.view", @"/Views/Doctors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Details.cshtml", typeof(AspNetCore.Views_Doctors_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 4 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
using DoctorOffice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e2e993bc20f40cb1f0bd4fa0af9e9014bd6033", @"/Views/Doctors/Details.cshtml")]
    public class Views_Doctors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(59, 64, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n  <div class=\"jumbotron\">\r\n    <h1>");
            EndContext();
            BeginContext(124, 10, false);
#line 9 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(134, 22, true);
            WriteLiteral(" Page</h1>\r\n  </div>\r\n");
            EndContext();
#line 11 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
   if(Model.PatientDoctors.Count == 0)
  {

#line default
#line hidden
            BeginContext(201, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(209, 10, false);
#line 13 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(219, 23, true);
            WriteLiteral(" has no Patients.</p>\r\n");
            EndContext();
#line 14 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(247, 8, true);
            WriteLiteral("  <ol>\r\n");
            EndContext();
#line 16 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
     foreach (PatientDoctor patientDoctor in Model.PatientDoctors)
    {

#line default
#line hidden
            BeginContext(330, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(343, 26, false);
#line 18 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
       Write(patientDoctor.Patient.Name);

#line default
#line hidden
            EndContext();
            BeginContext(369, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(383, 19, true);
            WriteLiteral("  </ol>\r\n    <ol>\r\n");
            EndContext();
#line 22 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
     foreach (SpecialtyDoctor specialtyDoctor in Model.SpecialtyDoctors)
    {

#line default
#line hidden
            BeginContext(483, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(496, 39, false);
#line 24 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
       Write(specialtyDoctor.Specialty.SpecialtyType);

#line default
#line hidden
            EndContext();
            BeginContext(535, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 25 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(549, 47, true);
            WriteLiteral("  </ol>\r\n  <button class=\"btn btn-outline-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 596, "\"", 666, 3);
            WriteAttributeValue("", 606, "window.location.href=\'/doctors/addSpecialty/", 606, 44, true);
#line 27 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
WriteAttributeValue("", 650, Model.DoctorId, 650, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 665, "\'", 665, 1, true);
            EndWriteAttribute();
            BeginContext(667, 128, true);
            WriteLiteral(">Add a Specialty</button>\r\n  <button class=\"btn btn-outline-dark\" onclick=\"window.location.href=\'/doctors\'\">Doctors</button>\r\n  ");
            EndContext();
            BeginContext(796, 97, false);
#line 29 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Doctors\Details.cshtml"
Write(Html.ActionLink("Delete","Delete", new {id = Model.DoctorId}, new{@class="btn btn-outline-dark"}));

#line default
#line hidden
            EndContext();
            BeginContext(893, 14, true);
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
