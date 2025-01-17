﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookeyWebApp.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1,100, ErrorMessage = "Display Order must be in range from 1 to 100")]
    public int DisplayOrder { get; set; }

    public DateTime CreatedDateTime { get; set; } = DateTime.Now; 
}
