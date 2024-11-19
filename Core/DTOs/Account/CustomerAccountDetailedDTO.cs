﻿namespace Core.DTOs.Account;

public class CustomerAccountDetailedDTO
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public string OpeningDate { get; set; } = string.Empty;
}