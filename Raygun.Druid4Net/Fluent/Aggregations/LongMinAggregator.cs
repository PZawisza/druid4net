﻿namespace Raygun.Druid4Net
{
  public class LongMinAggregator : BaseAggregator
  {
    public override string Type => "longMin";

    public LongMinAggregator(string name, string fieldName = null) 
      : base (name, fieldName)
    {
    }
  }
}