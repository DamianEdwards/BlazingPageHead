# BlazingPageHead
Example of Blazor components for managing page head content.

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
