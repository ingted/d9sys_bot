﻿// Decompiled with JetBrains decompiler
// Type: LineBot.Models.SendMsgObject
// Assembly: LineBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2BBFEF47-CFFC-47E0-9A9F-E00E117F93C2
// Assembly location: C:\inetpub\linebottest\packages\LineBotSDK.0.5.1\lib\net45\LineBot.dll

using System;
using System.Collections.Generic;

namespace LineBot.Models
{
  [Obsolete("Line舊版API，已過時")]
  public class SendMsgObject
  {
    public List<string> to { get; set; }

    public int toChannel { get; set; }

    public string eventType { get; set; }

    public Content content { get; set; }
  }
}
