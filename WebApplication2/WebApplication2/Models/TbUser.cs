using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TbUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
