﻿using Objects.Utils;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Objects.BuiltElements.Revit
{
  public class ParameterUpdater : Base
  {
    public string revitId { get; set; }
    public Base parameters { get; set; }


    [SchemaInfo("ParameterUpdater", "Updates parameters on a Revit element by id", "Revit", "Families")]
    public ParameterUpdater([SchemaParamInfo("A Revit ElementId or UniqueId")] string id, List<Parameter> parameters)
    {
      this.revitId = id;
      this.parameters = parameters.ToBase();
    }

    public ParameterUpdater()
    {

    }
  }
}
