﻿// Decompiled with JetBrains decompiler
// Type: AL2018.LineBot.Column
// Assembly: LineBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2BBFEF47-CFFC-47E0-9A9F-E00E117F93C2
// Assembly location: C:\inetpub\linebottest\packages\LineBotSDK.0.5.1\lib\net45\LineBot.dll

using System;
using System.Collections.Generic;

namespace AL2018.LineBot
{
  public class Column
  {
    private List<TemplateActionBase> _actions;

    public Uri thumbnailImageUrl { get; set; }

    public string title { get; set; }

    public string text { get; set; }

    public List<TemplateActionBase> actions
    {
      get
      {
        if (this._actions == null)
          this._actions = new List<TemplateActionBase>();
        return this._actions;
      }
      set
      {
        this._actions = value;
      }
    }
  }
}