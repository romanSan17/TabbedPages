﻿namespace TabbedPages.Models;

public class Note
{
    public string Filename { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;

    public DateTime Date { get; set; } = DateTime.Now;

    public string DateString => Date.ToString("yyyy-MM-dd HH:mm");
}
