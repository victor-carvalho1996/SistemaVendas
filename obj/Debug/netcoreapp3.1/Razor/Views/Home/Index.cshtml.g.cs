#pragma checksum "C:\Projetos\VendasSolutto\VendasSolutto\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3b5e74c1489f091ee930b2e597fdfdf49021c1"
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
#line 1 "C:\Projetos\VendasSolutto\VendasSolutto\Views\_ViewImports.cshtml"
using VendasSolutto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\VendasSolutto\VendasSolutto\Views\_ViewImports.cshtml"
using VendasSolutto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3b5e74c1489f091ee930b2e597fdfdf49021c1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ff24f0875cf731bade66bc7ae17fe25b0cfffd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VendasSolutto.Models.EntradaRelatorio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/AnyChart/dist/js/anychart-base.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/moment/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/SweetAlert/dist/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 25%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("fillDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projetos\VendasSolutto\VendasSolutto\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Vendas Solutto";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3b5e74c1489f091ee930b2e597fdfdf49021c16237", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3b5e74c1489f091ee930b2e597fdfdf49021c16499", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3b5e74c1489f091ee930b2e597fdfdf49021c17685", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3b5e74c1489f091ee930b2e597fdfdf49021c18871", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link type=\"text/css\" rel=\"stylesheet\" href=\"../css/site.css\" />\r\n    <h1 class=\"display-4 text-center\">Relatórios</h1>\r\n    <br />\r\n    <div class=\"text-center\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3b5e74c1489f091ee930b2e597fdfdf49021c110247", async() => {
                    WriteLiteral(@"
            <label class=""mr-sm-2"" for=""startDate"">Data Inicial: </label>
            <input type=""date"" class=""form-control mb-2 mr-sm-2"" required id=""startDate"">

            <label class=""mr-sm-2"" for=""finalDate"">Data Final: </label>
            <input type=""date"" class=""form-control mb-2 mr-sm-2"" required id=""finalDate"">

            <button type=""button"" onclick=""runReports()"" style=""width: 100px"" class=""btn btn-primary mb-2"">Ok</button>

            <div id=""divLoading"" style=""display: inline-flex; padding-left: 10px;"" hidden>
                <div>Carregando</div>
                <div class=""sk-chase"">
                    <div class=""sk-chase-dot""></div>
                    <div class=""sk-chase-dot""></div>
                    <div class=""sk-chase-dot""></div>
                    <div class=""sk-chase-dot""></div>
                    <div class=""sk-chase-dot""></div>
                    <div class=""sk-chase-dot""></div>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        
    </div>
    <div id=""container"" style=""display: flex"">
        <div id=""bar"" style=""width: 500px; height: 400px;"">

        </div>
        <div id=""pie"" style=""width: 500px; height: 400px;"">

        </div>
    </div>

    <script>
        window.onload = function fillDate() {
            var finalDate = moment().format('yyyy-MM-DD');
            $(""#finalDate"").val(finalDate);

            var startDate = moment().add(-15, 'days').format('yyyy-MM-DD');
            $(""#startDate"").val(startDate);
        }

        function showLoading(show) {
            if (show) {
                $(""#divLoading"").removeAttr('hidden');
            } else {
                $(""#divLoading"").attr('hidden', true);
            }
        }

        async function runReports() {

            let dateF = $(""#finalDate"").val();
            let dateI = $(""#startDate"").val();

            let isValidPeriod = validPeriod(dateI, dateF);

            if (!isValidPeriod) {
                ");
                WriteLiteral(@"return 0;
            }

            dateF = dateF.replaceAll(""-"", ""/"");
            dateI = dateI.replaceAll(""-"", ""/"");
            var resultGraphBar = undefined;
            var resultPieChart = undefined;
            var haveData = true;

            showLoading(true);

            await $.ajax({
                type: ""POST"",
                url: ""/Relatorios/RelatorioBarra"",
                data: { dataInicial: dateI, dataFinal: dateF },
                dataType: ""text"",
                success: function (result) {
                    resultGraphBar = JSON.parse(result);
                    if (resultGraphBar.length === 0) {
                        swal(""Alerta!"", ""Não foi encontrado vendas nesse intervalo de datas!"", ""warning"");
                        haveData = false;
                    }
                },
                error: function (e) {
                    swal(""Alerta!"", e.message, ""error"");
                }
            });

            if (!haveData) {
        ");
                WriteLiteral(@"        showLoading(false);
                return 0;
            }

            await $.ajax({
                type: ""POST"",
                url: ""/Relatorios/RelatorioPizza"",
                data: { dataInicial: dateI, dataFinal: dateF },
                dataType: ""text"",
                success: function (result) {
                    resultPieChart = JSON.parse(result);
                    if (resultPieChart.length === 0) {
                        swal(""Alerta!"", ""Não foi encontrado vendas nesse intervalo de datas!"", ""warning"");
                        haveData = false;
                    }
                },
                error: function (e) {
                    swal(""Alerta!"", e.message, ""error"");
                }
            });

            if (!haveData) {
                showLoading(false);
                return 0;
            }

            showBarGraph(resultGraphBar);
            showPieChart(resultPieChart);

            showLoading(false);


        }

  ");
                WriteLiteral(@"      function validPeriod(dateI, dateF) {
            if (moment(dateI) > moment(dateF)) {
                swal(""Alerta!"", ""Data Inicial não pode ser maior que a data final."", ""warning"");
                return false;
            }

            if (dateI === """" || dateF === """") {
                swal(""Alerta!"", ""Favor selecionar um período de máximo 15 dias."", ""warning"");
                return false;
            }

            let finalDate = moment(dateF);
            if (finalDate.diff(dateI, ""days"") > 15) {
                swal(""Alerta!"", ""Favor selecionar um período menor ou igual a 15 dias."", ""warning"");
                return false;
            }
            return true;
        }

        function showBarGraph(result) {
            $('#bar').empty()

            let rawData = [];
            for (let i = 0; i < result.length; i++) {
                rawData.push([moment(result[i].data).format(""DD-MM""), (result[i].total_dia).toFixed(2)])
            }

            anychart.on");
                WriteLiteral(@"DocumentReady(function () {
                anychart.format.locales.default.numberLocale.decimalsCount = 2
                var chart = anychart.bar(rawData);

                var tooltip = chart.tooltip();

                tooltip.format(""Total de vendas: R$ {%value}{decimalsCount:2,zeroFillDecimals:true}"")


                chart.title('Total de vendas por dia');
                chart.container('bar');
                chart.draw();
            });
        }

        function showPieChart(result) {
            $('#pie').empty()

            let rawData = [];
            for (let i = 0; i < result.length; i++) {
                rawData.push([result[i].produto_nome, (result[i].valor_vendido).toFixed(2)])
            }

            anychart.onDocumentReady(function () {
                anychart.format.locales.default.numberLocale.decimalsCount = 2
                var chart = anychart.pie(rawData);
             
                chart.title(""Total vendido de cada produto"");
            ");
                WriteLiteral("    chart.labels().format(\'R$ {%value}{decimalsCount:2,zeroFillDecimals:true}\');\r\n                chart.container(\"pie\");\r\n                chart.draw();\r\n            });\r\n        }\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VendasSolutto.Models.EntradaRelatorio> Html { get; private set; }
    }
}
#pragma warning restore 1591
