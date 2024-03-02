using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Repository.Entities;

public partial class Student1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Marks { get; set; }

    public string? Address { get; set; }
}
