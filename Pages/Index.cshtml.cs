﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages;

public class IndexModel : PageModel
{



public string? Company = "Microsoft";


    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {

        _logger = logger;
    }

    public void OnGet()
    {
        ViewData["MyName"] = "John Doe";
    }

    public void OnPost(){

    }
}
