﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FoolService
{
    [ServiceContract]
    public interface IService1 {
      [OperationContract]
      Int32 GetCard();
    }

}
