#pragma checksum "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82947b8996da4399d8c77a6bec2c716701863dc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Generic_Responce), @"mvc.1.0.view", @"/Views/Generic/Responce.cshtml")]
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
#line 1 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\_ViewImports.cshtml"
using sharps_ent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\_ViewImports.cshtml"
using sharps_ent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82947b8996da4399d8c77a6bec2c716701863dc4", @"/Views/Generic/Responce.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b70414f6f6252d4b7142dd96b27e4264d35dcdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Generic_Responce : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
  
    ViewData["Title"] = @ViewContext.RouteData.Values["controller"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82947b8996da4399d8c77a6bec2c716701863dc44316", async() => {
                WriteLiteral("\r\n    <button type=\"submit\" name=\"create_request\" class=\"btn btn-primary\">Создать новый</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 91, "/", 91, 1, true);
#nullable restore
#line 4 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
AddHtmlAttributeValue("", 92, ViewContext.RouteData.Values["controller"], 92, 43, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 135, "/AddRequestAction", 135, 17, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82947b8996da4399d8c77a6bec2c716701863dc46483", async() => {
                WriteLiteral("\r\n    <button type=\"submit\" name=\"create_request\" class=\"btn btn-warning\">Отфильтровать</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 289, "/", 289, 1, true);
#nullable restore
#line 7 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
AddHtmlAttributeValue("", 290, ViewContext.RouteData.Values["controller"], 290, 43, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 333, "/GetRequestAction", 333, 17, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=container>\r\n    <h1>Найдено сущностей: ");
#nullable restore
#line 11 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                      Write(Model[1].Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 12 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
     if (Model[3] != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
         foreach (var raw in Model[3])
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 16 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
          Write(raw);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table cellspacing=0 class=\"table table-bordered table-hover table-inverse table-striped\" id=data width=100%>\r\n        <thead>\r\n            <tr>\r\n");
#nullable restore
#line 22 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                 foreach (var label in Model[0])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th class=\"th-sm sorting\">");
#nullable restore
#line 24 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                                         Write(label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 25 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th class=\"th-sm sorting\">Edit</th>\r\n                <th class=\"th-sm sorting\">Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
             for (var j = 0; j < Model[1].Length; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 34 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                 for (var i = 0; i < Model[1][j].Length; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                     if (Model[2] != null && Model[2].ContainsKey(i))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82947b8996da4399d8c77a6bec2c716701863dc412040", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" class=\"form-control\" name=\"0\" id=\"0\"");
                BeginWriteAttribute("value", " value=\"", 1628, "\"", 1651, 1);
#nullable restore
#line 40 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
WriteAttributeValue("", 1636, Model[1][j][i], 1636, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                                <a href=\"javascript:{}\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1717, "\"", 1793, 7);
                WriteAttributeValue("", 1727, "document.getElementById(\'", 1727, 25, true);
#nullable restore
#line 41 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
WriteAttributeValue("", 1752, Model[2][i], 1752, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1764, "_", 1764, 1, true);
#nullable restore
#line 41 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
WriteAttributeValue("", 1765, j, 1765, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1767, "\').submit();", 1767, 12, true);
                WriteAttributeValue(" ", 1779, "return", 1780, 7, true);
                WriteAttributeValue(" ", 1786, "false;", 1787, 7, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                                                                                                                                Write(Model[1][j][i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1470, "/", 1470, 1, true);
#nullable restore
#line 39 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
AddHtmlAttributeValue("", 1471, Model[2][i], 1471, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1483, "/GetResponceAction2", 1483, 19, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
AddHtmlAttributeValue("", 1508, Model[2][i], 1508, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1520, "_", 1520, 1, true);
#nullable restore
#line 39 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
AddHtmlAttributeValue("", 1521, j, 1521, 2, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 44 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 47 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                       Write(Model[1][j][i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82947b8996da4399d8c77a6bec2c716701863dc417782", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\" id=\"u_id\"");
                BeginWriteAttribute("value", " value=\"", 2250, "\"", 2273, 1);
#nullable restore
#line 52 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
WriteAttributeValue("", 2258, Model[1][j][0], 2258, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" name=\"update_request\" class=\"btn btn-warning\"><xmp>Edit</xmp></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2104, "/", 2104, 1, true);
#nullable restore
#line 51 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
AddHtmlAttributeValue("", 2105, ViewContext.RouteData.Values["controller"], 2105, 43, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2148, "/UpdateRequestAction", 2148, 20, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82947b8996da4399d8c77a6bec2c716701863dc420533", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\" id=\"d_id\"");
                BeginWriteAttribute("value", " value=\"", 2652, "\"", 2675, 1);
#nullable restore
#line 58 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
WriteAttributeValue("", 2660, Model[1][j][0], 2660, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" name=\"delete\" class=\"btn btn-danger\"><xmp>Delete</xmp></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2505, "/", 2505, 1, true);
#nullable restore
#line 57 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
AddHtmlAttributeValue("", 2506, ViewContext.RouteData.Values["controller"], 2506, 43, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2549, "/DeleteResponceAction", 2549, 21, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\gorbushin_v_a\source\repos\sharps_ent\WEB\Views\Generic\Responce.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script src=https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js></script>
<script src=https://cdnjs.cloudflare.com/ajax/libs/datatables/1.10.20/js/jquery.dataTables.min.js></script>
<script src=https://cdnjs.cloudflare.com/ajax/libs/datatables/1.10.20/js/dataTables.bootstrap4.min.js></script>

<script>
    $(document).ready(function () {
        $.noConflict();
        var table = $('#data').DataTable();
    });
</script>");
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
