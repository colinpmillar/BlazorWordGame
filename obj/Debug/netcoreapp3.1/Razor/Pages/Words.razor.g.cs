#pragma checksum "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3ea070fc99b71ab9340e603b29341fb5b6dc6c"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorWords.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using blazorWords;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/borakasmer/Projects/blazorWords/_Imports.razor"
using blazorWords.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/wordgame")]
    public partial class Words : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
 if(!isFullRoom) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "style", "display: flex; justify-content: flex-end");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "div");
            __builder.OpenElement(5, "h3");
            __builder.OpenElement(6, "b");
            __builder.OpenElement(7, "font");
            __builder.AddAttribute(8, "color", "#46CB18");
            __builder.AddContent(9, "Total Win Match: ");
            __builder.AddContent(10, 
#nullable restore
#line 9 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                                            globalScore

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 11 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 13 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
     if(!isLogin  && !isFullRoom) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "label");
            __builder.AddMarkupContent(18, "\n            User: ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(22, (__value) => {
#nullable restore
#line 15 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                               ReferenceToLoginControl = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                          Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 17 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                            !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 18 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
    }
    else if(!isFullRoom){

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.OpenElement(31, "label");
            __builder.OpenElement(32, "h2");
            __builder.AddMarkupContent(33, "<b>User :</b> ");
            __builder.AddContent(34, 
#nullable restore
#line 20 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                  userName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, " <br>  \n        ");
            __builder.OpenElement(36, "label");
            __builder.OpenElement(37, "h2");
            __builder.AddMarkupContent(38, "<b>Money :</b> ");
            __builder.AddContent(39, 
#nullable restore
#line 21 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                   money

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, " ₺");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, " \n         ");
            __builder.OpenElement(42, "label");
            __builder.AddMarkupContent(43, "\n            ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "style", "text-transform: uppercase; font-weight: bold; font-family: Arial, Helvetica, sans-serif; color: green; font-size: 60px;");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                          answer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => answer = __value, answer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                          Answer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Answer");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
#nullable restore
#line 26 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.AddMarkupContent(57, "\n");
#nullable restore
#line 29 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
     if(_otherUser!=null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "        ");
            __builder.OpenElement(59, "label");
            __builder.OpenElement(60, "h2");
            __builder.AddMarkupContent(61, "<b>Other User :</b> ");
            __builder.AddContent(62, 
#nullable restore
#line 30 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                        _otherUser

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, " <br>  \n        ");
            __builder.OpenElement(64, "label");
            __builder.OpenElement(65, "h2");
            __builder.AddMarkupContent(66, "<b>Other User\'s Money :</b> ");
            __builder.AddContent(67, 
#nullable restore
#line 31 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                                _otherMoney

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(68, " ₺");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "     \n");
#nullable restore
#line 32 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n");
#nullable restore
#line 34 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
  if(word!=null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "    <hr>\n    ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "container");
            __builder.AddMarkupContent(74, "\n        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "jumbotron jumbotron-fluid");
            __builder.AddMarkupContent(77, "\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "container-fluid text-center");
            __builder.AddMarkupContent(80, "\n");
#nullable restore
#line 40 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                     for (int i=0;i<word.Length;i++)
                    {  
                        string imgId="image-"+@i;
                        string lblId="label-"+@i;
                        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "span");
            __builder.AddAttribute(82, "style", "display: none;");
            __builder.AddAttribute(83, "id", "label-" + (
#nullable restore
#line 44 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                                                i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, 
#nullable restore
#line 44 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                                                    word[i].ToString().ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "                   \n");
#nullable restore
#line 45 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                        if(word[i]!=' ')
                        {                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                            ");
            __builder.OpenElement(87, "img");
            __builder.AddAttribute(88, "src", "/Images/block.png");
            __builder.AddAttribute(89, "id", "image-" + (
#nullable restore
#line 47 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                                                    i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "asp-append-version", "true");
            __builder.AddAttribute(91, "width", "50px");
            __builder.AddAttribute(92, "style", "display: inline;");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                                                                                                                                    () => Open(i,imgId,lblId,false)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n");
#nullable restore
#line 48 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                            ");
            __builder.OpenElement(96, "img");
            __builder.AddAttribute(97, "src", "/Images/blockEmpty.png");
            __builder.AddAttribute(98, "id", "image-" + (
#nullable restore
#line 51 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                                                         i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "asp-append-version", "true");
            __builder.AddAttribute(100, "width", "50px");
            __builder.AddAttribute(101, "style", "display: inline;");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\n");
#nullable restore
#line 52 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                        }               
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "    \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n");
#nullable restore
#line 59 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
       
    private int globalScore=0;
    private bool isFullRoom=false;
    ElementReference ReferenceToLoginControl;
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userName;
    private string _otherUser;
    private int _otherMoney = 0;
    private string word;
    private string connectionID;
    private bool isLogin = false;
    private int money = 0;
    private string answer;
    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/wordhub"))
            .Build();

        hubConnection.On<string, string, int>("GetConnectionId", async (_connectionID, otherUser, otherMoney) =>
          {       
              await JSRuntime.InvokeAsync<object>("console.log", "ConnectionID :" + _connectionID);                           
          connectionID = _connectionID;
              if (otherUser != null && IsRenderUI == true)
              {
                  _otherMoney = otherMoney;
                  _otherUser = otherUser;
                  StateHasChanged();
              }
          });

        hubConnection.On<string>("SendUserInformation", async (otherConnectionID) =>
        { 
            await hubConnection.SendAsync("SendUserInformation", userName, money, otherConnectionID);  
        });   

        hubConnection.On<string,int,string>("GetUserInformation", async (otherUserName, otherMoney,_connectionID) =>
        { 
            await JSRuntime.InvokeAsync<object>("console.log", "ConnectionID :" + _connectionID);
            connectionID=_connectionID;
             if (otherUserName != null && IsRenderUI == true)
             {
                _otherMoney=otherMoney;
                _otherUser=otherUserName;
                StateHasChanged();
            }
        });   
             
        hubConnection.On<string, string, int>("ReceiveUser", (_userName, _connectionId, _money) =>
         {
             if (userName == _userName)
             {
                 money = _money;
                 isLogin = true;
             }
             else
             {
                 _otherMoney = _money;
                 _otherUser = _userName;
             }
             StateHasChanged();
         });

        hubConnection.On<string, string>("RemoveUser", (_userName, _connectionId) =>
            {
                if (userName != _userName)
                {
                    _otherUser = null;
                    _otherMoney = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "/Users/borakasmer/Projects/blazorWords/Pages/Words.razor"
                                    
                    word = null;
                    StateHasChanged();
                }
            });

        hubConnection.On<string, string, int>("ReceiveWord", (_wordText, _userName, _money) =>
          {
              if (userName != _userName)
              {
                  _otherUser = _userName;
                  _otherMoney = _money;
              }
              else
              {
                  money = _money;
                  isLogin = true;
              }
              word = _wordText;
              StateHasChanged();
          });

        hubConnection.On<string>("RefreshWord", async (_wordText) =>
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    string imgId = "image-" + @i;
                    string lblId = "label-" + @i;

                    await JSRuntime.InvokeVoidAsync("applyStyleForElement",
                                          new { id = imgId, attrib = "display", value = "inline" });

                    await JSRuntime.InvokeVoidAsync("applyStyleForElement",
                                          new { id = lblId, attrib = "display", value = "none" },
                                          new { id = lblId, attrib = "font-size", value = "65px" });
                }
            }

            word = _wordText;
            answer = "";
            StateHasChanged();
        });

        hubConnection.On<int, string, string, int>("ReceiveOpen", async (counter, imgId, lblId, _money) =>
           {
               _otherMoney = _money;
               StateHasChanged();
               await Open(counter, imgId, lblId, true);
           });

        hubConnection.On("ComeLater", async () =>
           { 
                isFullRoom = true;
                await JSRuntime.InvokeVoidAsync("applyStyleForElement",
                                                    new { id = "blazorBody", attrib = "background-image", value = "url('../Images/wall31.jpeg')" });
                  
                StateHasChanged();              
           });
           

        hubConnection.On<string, string,int>("ReceiveAnswer", async (userName, connectionID,money) =>
           {
               for (int i = 0; i < word.Length; i++)
               {
                   if (word[i] != ' ')
                   {
                       string imgId = "image-" + @i;
                       string lblId = "label-" + @i;

                       await JSRuntime.InvokeVoidAsync("applyStyleForElement",
                                               new { id = imgId, attrib = "display", value = "none" });

                       await JSRuntime.InvokeVoidAsync("applyStyleForElement",
                                               new { id = lblId, attrib = "display", value = "inline" },
                                               new { id = lblId, attrib = "font-size", value = "65px" });
                   }
               }
               System.Threading.Thread.Sleep(1000);
               await JSRuntime.InvokeAsync<object>("alert", "Winner :" + userName);
                   _otherMoney=money;
           });

        await hubConnection.StartAsync();
    }

    Task Send() =>
        hubConnection.SendAsync("LoginUser", userName, connectionID);

    async Task Answer()
    {
        int totalEarnMoney=0;
        if (answer.ToUpper() == word.ToUpper())
        {
            globalScore++;
            for (int i = 0; i < word.Length; i++)
            {
                 bool result = await JSRuntime.InvokeAsync<bool>("getStyleForElement", 
                        new { id = "label-" + @i, attrib = "display"});
                        if(word[i] != ' ' && !result)
                        {
                            money+=10;
                            totalEarnMoney+=10;
                        }
                if (word[i] != ' ')
                {
                    string imgId = "image-" + @i;
                    string lblId = "label-" + @i;                                                           
                    
                    await JSRuntime.InvokeVoidAsync("applyStyleForElement",
                                                    new { id = imgId, attrib = "display", value = "none" });

                    await JSRuntime.InvokeVoidAsync("applyStyleForElement",
                                                    new { id = lblId, attrib = "display", value = "inline" },
                                                    new { id = lblId, attrib = "font-size", value = "65px" });                                                    
                }                
            }
            await hubConnection.SendAsync("sendAnswer", userName, connectionID,money);
            System.Threading.Thread.Sleep(1000);

            await JSRuntime.InvokeAsync<object>("alert", "Winner :" + userName +"\n Total Reward :" +totalEarnMoney+"₺");

            await hubConnection.SendAsync("Refresh");
        }
    }

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }
    private async Task Open(int counter, string imgId, string lblId, bool isOtherOpen = false)
    {
        if (isOtherOpen == false && money >= 10)
        {
            money = money - 10;
            await JSRuntime.InvokeVoidAsync("applyStyleForElement",
         new { id = imgId, attrib = "display", value = "none" });

            await JSRuntime.InvokeVoidAsync("applyStyleForElement",
          new { id = lblId, attrib = "display", value = "inline" },
          new { id = lblId, attrib = "font-size", value = "65px" });

            await hubConnection.SendAsync("OpenClient", counter, imgId, lblId, money);
        }
        else if (isOtherOpen == true)
        {
            await JSRuntime.InvokeVoidAsync("applyStyleForElement",
        new { id = imgId, attrib = "display", value = "none" });

            await JSRuntime.InvokeVoidAsync("applyStyleForElement",
          new { id = lblId, attrib = "display", value = "inline" },
          new { id = lblId, attrib = "font-size", value = "65px" });
        }
    }

    bool IsRenderUI = false;
    protected override void OnAfterRender(bool firstRender)
    {
        IsRenderUI = true;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await JSRuntime.InvokeVoidAsync("FocusScript.setFocus", ReferenceToLoginControl);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
