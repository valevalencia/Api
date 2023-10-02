﻿using DataCape.Models;

namespace BusinessCape.DTOs.Role
{
    public class RoleUpdateDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public List<long> PermissionIds { get; set; } = null!;
        //public bool? StatedAt { get; set; }
    }
}
