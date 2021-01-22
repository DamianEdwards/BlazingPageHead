# BlazingPageHead
Example of Blazor components for managing page head content.

I've used an approach similar to this in other apps and can confirm it updated the page title in a way that ensured it was picked up correctly on client-side navigation events tracked by web analytics libraries (e.g. Application Insights) so that the correct page title is tracked when a page view is reported.

See implementation at `/HeadComponents/PageHeadManager.razor` and `HeadComponents/PageHead.razor`

## Usage
`App.razor`
``` html
<PageHeadManager Suffix="- My Great app">
  <Router ...>
</PageHeadManager>
```

`Index.razor`
``` html
@page "/"

<h1>Hello, world!</h1>

Welcome to your new app.

<PageHead>
    <meta name="author" content="This guy right here" />
    <meta name="keywords" content="some keywords yo" />
    <meta name="abstract" content="what is a page anyway?" />
    <title>Home</title>
    <link href="css/home.css" rel="stylesheet" />
</PageHead>

@code {
    
}
```
