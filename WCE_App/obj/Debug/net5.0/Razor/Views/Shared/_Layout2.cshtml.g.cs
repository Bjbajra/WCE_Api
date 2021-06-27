#pragma checksum "C:\Users\bijay\westcoasteducationapi\wce_app\Views\Shared\_Layout2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee1435aca08d798040391dceb2dc3095a62b4fcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout2), @"mvc.1.0.view", @"/Views/Shared/_Layout2.cshtml")]
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
#line 1 "C:\Users\bijay\westcoasteducationapi\wce_app\Views\_ViewImports.cshtml"
using WCE_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bijay\westcoasteducationapi\wce_app\Views\_ViewImports.cshtml"
using WCE_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee1435aca08d798040391dceb2dc3095a62b4fcc", @"/Views/Shared/_Layout2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb768c660f9725776cd978aa585bf3467d2167f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee1435aca08d798040391dceb2dc3095a62b4fcc3240", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""/content/css/styles.css"" />
    <link rel=""stylesheet"" href=""/content/css/colors.css"" />
    <link rel=""stylesheet"" href=""/content/css/cards.css"" />

    <script
      src=""https://kit.fontawesome.com/734a53a685.js""
      crossorigin=""anonymous""
    ></script>
    <title>WestCoastEducation</title>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee1435aca08d798040391dceb2dc3095a62b4fcc4745", async() => {
                WriteLiteral(@"
    <header class=""landing"">
      <div id=""main-nav"" class=""nav"">
        <h1><a href=""index.html"">WestCoastEducation</a></h1>
        <ul>
          <li><a href=""index.html"" class=""active"">Home</a></li>
          <li><a href=""courses.html"">Courses</a></li>
          <li><a href=""aboutUs.html"">About Us</a></li>
        </ul>
      </div>
      <div class=""content"">
        <h1>Welcome To Westcoast Education</h1>
        <p>
          Lorem ipsum dolor sit, amet consectetur adipisicing elit. Et
          voluptatem laborum suscipit odio veritatis? Quia tempore reiciendis
          esse alias totam delectus illo magni repellat consequuntur! Laudantium
          cupiditate atque fuga quis nostrum adipisci obcaecati rerum. Illo in
          sit quasi. Blanditiis maiores vitae ratione molestiae laboriosam illum
          in ea omnis placeat veritatis!
        </p>
        <a href=""aboutUs.html"" class=""btn btn-secondary""
          ><i class=""fas fa-chevron-circle-right""></i> Read More</a
   ");
                WriteLiteral(@"     >
      </div>
    </header>
    <main>
      <article>
        <section>
          <h2 id=""featured-heading"">Our Featured Courses</h2>
          <ul class=""cards"">
            <li class=""cards__item"">
              <a href=""course-details.html?courseId=1"">
                <div class=""card"">
                  <div class=""card__image card__image--Html""></div>
                  <div class=""card__content"">
                    <div class=""card__title"">Fundamental of HTML</div>
                    <p class=""card__text"">
                      Lorem ipsum dolor sit amet consectetur adipisicing elit.
                      At, aperiam praesentium et soluta ad error magni placeat
                      consequuntur, corrupti enim neque aliquid delectus
                      similique quia ab illum, laborum quisquam voluptatem?
                    </p>
                  </div>
                </div>
              </a>
            </li>
            <li class=""cards__item"">
              <a hr");
                WriteLiteral(@"ef=""course-details.html?courseId=2"">
                <div class=""card"">
                  <div class=""card__image card__image--Css""></div>
                  <div class=""card__content"">
                    <div class=""card__title"">Fundamental of CSS</div>
                    <p class=""card__text"">
                      Lorem ipsum dolor sit amet consectetur adipisicing elit.
                      At, aperiam praesentium et soluta ad error magni placeat
                      consequuntur, corrupti enim neque aliquid delectus
                      similique quia ab illum, laborum quisquam voluptatem?
                    </p>
                  </div>
                </div>
              </a>
            </li>
            <li class=""cards__item"">
              <a href=""course-details.html?courseId=3"">
                <div class=""card"">
                  <div class=""card__image card__image--JavaScript""></div>
                  <div class=""card__content"">
                    <div class=""card__tit");
                WriteLiteral(@"le"">Fundamental of JavaScript</div>
                    <p class=""card__text"">
                      Lorem ipsum dolor sit amet consectetur adipisicing elit.
                      At, aperiam praesentium et soluta ad error magni placeat
                      consequuntur, corrupti enim neque aliquid delectus
                      similique quia ab illum, laborum quisquam voluptatem?
                    </p>
                  </div>
                </div>
              </a>
            </li>
          </ul>
          <div>
            <a href=""courses.html"" class=""btn btn-primary more""
              >Find more courses</a
            >
          </div>
        </section>
      </article>
    </main>
    <footer id=""main-footer"">
      <div class=""container footer-container"">
        <div class=""social"">
          <a href=""http://facebook.com"" target=""_blank""
            ><i class=""fab fa-facebook-square fa-2x""></i
          ></a>
          <a href=""http://twitter.com"" target=""_blank""
");
                WriteLiteral(@"            ><i class=""fab fa-twitter-square fa-2x""></i
          ></a>
          <a href=""http://instagram.com"" target=""_blank""
            ><i class=""fab fa-instagram-square fa-2x""></i
          ></a>
          <a href=""https://linkedin.com/"" target=""_blank""
            ><i class=""fa fa-linkedin-square fa-2x""></i
          ></a>
          <a href=""http://youtube.com"" target=""_blank""
            ><i class=""fab fa-youtube-square fa-2x""></i
          ></a>
        </div>
        <div>
          <ul class=""list"">
            <li><a href=""aboutUs.html"">About Us</a></li>
            <li><a href=""#"">Contact </a></li>
          </ul>
        </div>
      </div>
      <div>
        <p>WestCoastEducation &copy; 2021, All Rights Reserved</p>
      </div>
    </footer>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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