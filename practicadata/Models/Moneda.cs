﻿using System;
using System.Collections.Generic;

namespace practicadata.Models;

public partial class Moneda
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Simbolo { get; set; }
}
