#pragma checksum "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bcf194fba401e0c04d1e7d084a827a81d2ee98b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class Authors : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Authors.razor"
       

    public Author author { get; set; }
    public List<Author> authorList { get; set; }

    public bool IsVisible { get; set; }
    public bool Result { get; set; }
    public string RecordName { get; set; }
    public string[] Cities { get; set; }

    ElementReference firstNameTextBox;

    protected override void OnInitialized()
    {
        try
        {
            Console.WriteLine("Authors - OnInitialized");
            base.OnInitialized();

            throw new Exception("OnInitializedException");
        }
        catch (Exception)
        {

            //throw;
        }

    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Authors - OnInitializedAsync");

        author = new Author();
        //authorList = await authorService.GetAuthors();

        authorList = new List<Author>();
        authorList = await Http.GetJsonAsync<List<Author>>("https://localhost:44394/api/authors");
        authorList = authorList.OrderByDescending(auth => auth.AuthorId).ToList();

        //authorList = null;

        await base.OnInitializedAsync();
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("Authors - OnParametersSet");
        base.OnParametersSet();
    }

    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("Authors - OnParametersSetAsync");
        await base.OnParametersSetAsync();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("Authors - OnAfterRender - firstRender = " + firstRender);
        base.OnAfterRender(firstRender);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine("Authors - OnAfterRenderAsync - firstRender = " + firstRender);

        //if (firstRender && Cities == null)
        //{
        //    Cities = await JSRuntime.InvokeAsync<string[]>("getCities");

        //    StateHasChanged();
        //}

        await base.OnAfterRenderAsync(firstRender);
    }

    protected override bool ShouldRender()
    {
        Console.WriteLine("Authors - ShouldRender");
        return base.ShouldRender();
    }

    public void Dispose()
    {
        try
        {
            Console.WriteLine("Authors - Dispose");
            throw new Exception("DisposeException");
        }
        catch (Exception)
        {

            //throw;
        }

    }

    private async Task LoadAuthors()
    {
        authorList = await Http.GetJsonAsync<List<Author>>("https://localhost:44394/api/authors");
        authorList = authorList.OrderByDescending(auth => auth.AuthorId).ToList();

        StateHasChanged();

    }

    private async Task SaveAuthor()
    {
        //Result = await authorService.SaveAuthor(author);
        if (author.AuthorId == 0)
            await Http.PostJsonAsync("https://localhost:44394/api/authors", author);
        else
            await Http.PutJsonAsync("https://localhost:44394/api/authors/" + author.AuthorId, author);

        await LoadAuthors();

        Result = true;
        IsVisible = true;

        var firstName = author.FirstName;
        var lastName = author.LastName;

        RecordName = firstName + " " + lastName;

        author = new Author();

        //await JSRuntime.InvokeVoidAsync("saveMessage", firstName, lastName);
        //await JSRuntime.InvokeVoidAsync("setFocusOnElement", firstNameTextBox);
    }

    private async Task DeleteAuthor(int authorId)
    {
        try
        {
            throw new Exception("DeleteAuthorException");

            await Http.DeleteAsync("https://localhost:44394/api/authors/" + authorId);

            await LoadAuthors();
        }
        catch (Exception)
        {

            //throw;
        }

    }

    private void EditAuthor(Author argAuthor)
    {
        author = argAuthor;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService authorService { get; set; }
    }
}
#pragma warning restore 1591
