#pragma checksum "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Specialties\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab7b69ba04e5ed5b20fa4f7d49ecd9728c0c04d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Delete), @"mvc.1.0.view", @"/Views/Specialties/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Specialties/Delete.cshtml", typeof(AspNetCore.Views_Specialties_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7b69ba04e5ed5b20fa4f7d49ecd9728c0c04d8", @"/Views/Specialties/Delete.cshtml")]
    public class Views_Specialties_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Specialties\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(65, 139, true);
            WriteLiteral("<div class=\"container\">\r\n  <div class=\"jumbotron\">\r\n    <h1>Delete a Specialty?</h1>\r\n  </div>\r\n  <h3>Are you sure you want to Delete this ");
            EndContext();
            BeginContext(205, 10, false);
#line 9 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Specialties\Delete.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(215, 10, true);
            WriteLiteral("?</h3>\r\n  ");
            EndContext();
            BeginContext(226, 35, false);
#line 10 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Specialties\Delete.cshtml"
Write(Html.DisplayFor(model =>model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(261, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Specialties\Delete.cshtml"
   using (Html.BeginForm())
  {

#line default
#line hidden
            BeginContext(297, 73, true);
            WriteLiteral("    <input class=\"btn btn-outline-dark\" type=\"submit\" value=\"Delete\" />\r\n");
            EndContext();
#line 14 "C:\Users\Danie\OneDrive\Desktop\DoctorOffice\Views\Specialties\Delete.cshtml"
  }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorOffice.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
