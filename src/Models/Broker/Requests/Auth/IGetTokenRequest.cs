﻿using System;

namespace LT.DigitalOffice.Models.Broker.Requests.Auth;

public interface IGetTokenRequest
{
  Guid UserId { get; }

  static object CreateObj(Guid userId)
  {
    return new
    {
      UserId = userId
    };
  }
}
