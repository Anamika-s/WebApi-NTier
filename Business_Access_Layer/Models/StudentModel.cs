using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Business_Access_Layer.Models;

public class StudentModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Name is must")]
    [StringLength(10, ErrorMessage = "Max 10 characteres")]
    public string Name { get; set; }
    public int Marks { get; set; }
}

