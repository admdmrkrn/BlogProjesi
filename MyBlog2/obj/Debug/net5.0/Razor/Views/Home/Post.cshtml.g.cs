#pragma checksum "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd663dca4fff635f686ff984295e5233b6f361c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#nullable restore
#line 1 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\_ViewImports.cshtml"
using MyBlog2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\_ViewImports.cshtml"
using MyBlog2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd663dca4fff635f686ff984295e5233b6f361c", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c76c2dd744884a480aecf9de8b1f4ae796aa3ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog2.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("   <div class=\"container\">\r\n <header class=\"masthead\"");
            BeginWriteAttribute("style", " style=\"", 81, "\"", 130, 4);
            WriteAttributeValue("", 89, "background-image:", 89, 17, true);
            WriteAttributeValue(" ", 106, "url(\'", 107, 6, true);
#nullable restore
#line 3 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Home\Post.cshtml"
WriteAttributeValue("", 112, Model.ImagePath, 112, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 128, "\')", 128, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"overlay\"></div>\r\n    <div class=\"container\">\r\n      <div class=\"row\">\r\n        <div class=\"col-lg-8 col-md-10 mx-auto\">\r\n          <div class=\"post-heading\">\r\n            <h1>");
#nullable restore
#line 9 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Home\Post.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h2 class=\"subheading\">");
#nullable restore
#line 10 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Home\Post.cshtml"
                              Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <span class=\"meta\">Posted by\r\n               ");
#nullable restore
#line 12 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Home\Post.cshtml"
          Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              on ");
#nullable restore
#line 13 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Home\Post.cshtml"
            Write(Model.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
          </div>
        </div>
      </div>
    </div>
  </header>
 <div class=""container"">
  <!-- Post Content -->
  <article>
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-8 col-md-10 mx-auto"">
         ");
#nullable restore
#line 25 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Home\Post.cshtml"
    Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </article>\r\n    </div>\r\n  </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog2.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
