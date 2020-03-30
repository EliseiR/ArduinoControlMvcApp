#pragma checksum "C:\Users\msquare\source\repos\ArduinoControl\ArduinoControl\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d8fab5ffa1b8676249fd3de816be2ea5c732848"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\msquare\source\repos\ArduinoControl\ArduinoControl\Views\_ViewImports.cshtml"
using ArduinoControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msquare\source\repos\ArduinoControl\ArduinoControl\Views\_ViewImports.cshtml"
using ArduinoControl.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8fab5ffa1b8676249fd3de816be2ea5c732848", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6f62171380d9b4deea35c5af0db8762ef39d1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\msquare\source\repos\ArduinoControl\ArduinoControl\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center m-3"">Smart Home <span id=""time"" class=""m-3""></span></h2>
<hr/>
<div class=""row"">
    <div class=""col-6 offset-3"">
        <div class=""card"">
            <div class=""card-header bg-primary text-white"">Devices</div>
            <div class=""card-body"">
                <div class=""m-3"">
                    <span class=""badge badge-success"" style=""font-size:15px;"">Room 1:</span>
                    <input class=""switch"" data-room=""1"" type=""checkbox"" data-toggle=""toggle"" data-onstyle=""primary"" />
                    <span class=""float-right off"" data-room=""1""></span>
                </div>
                <hr />
                <div class=""m-3"">
                    <span class=""badge badge-success"" style=""font-size:15px;"">Room 2:</span>
                    <input class=""switch"" data-room=""2"" type=""checkbox"" data-toggle=""toggle"" data-onstyle=""primary"" />
                    <span class=""float-right off"" data-room=""2""></span>
                </div>
                <hr />
  ");
            WriteLiteral(@"              <div class=""m-3"">
                    <span class=""badge badge-success"" style=""font-size:15px;"">Room 3:</span>
                    <input class=""switch"" data-room=""3"" type=""checkbox"" data-toggle=""toggle"" data-onstyle=""primary"" />
                    <span class=""float-right off"" data-room=""3""></span>
                </div>

            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(() => {
            toastr.options = {
                ""preventDuplicates"":true
            }

            $switch = $("".switch"")

            $switch.on('change', async (e)=> {
                var target = e.target
                var roomNo = $(target).data('room')

                var switchElement = $(`.switch[data-room='${roomNo}']`)
                var bulbElement = $(`.float-right[data-room='${roomNo}']`)

                var switchValue = $(target).prop('checked')
                var command = switchValue == true ? 'on' : 'off'

                $.ajax({
                    url: `/home/send?command=${command}&&roomNumber=${roomNo}`,
                    method: 'Get',
                    success: (result) => {
                        if(switchValue)
                            $(bulbElement).removeClass(""off"").addClass(""on"")
                        else
                            $(bulbElement).removeClass(""on"").addClass(""off"")

                     ");
                WriteLiteral(@"   toastr.success('Command completed successfully!')
                    },
                    error: (error) => {
                        $(switchElement).bootstrapToggle('off', true)
                        $(bulbElement).removeClass(""on"").addClass(""off"")

                        toastr.error('Could not complete command. Please try again!')
                    }
                })
                
            })

            setInterval(function () {
                var date = new Date().toLocaleString()
                $(""#time"").html(date)
            },1000)
        })
    </script>
");
            }
            );
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
