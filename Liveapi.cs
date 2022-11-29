using System;
using System.Collections.Generic;

namespace backendprojects.Models;

public partial class Liveapi
{
    public int Id { get; set; }

    public string Newsname { get; set; } = null!;

    public string Newstopics { get; set; } = null!;

    public string Descriptions { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string? Newsimage { get; set; }
}
