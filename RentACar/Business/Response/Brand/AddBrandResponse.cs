﻿namespace Business.Response.Brand;

public class AddBrandResponse
{
    public string Id { get; set; }
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public AddBrandResponse(int id, string name, DateTime createdAt) 
    {
        Id = id;
        Name = name;
        CreatedAt = createdAt;
    }
}