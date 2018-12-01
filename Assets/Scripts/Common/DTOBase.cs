using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace CCG
{
    public abstract class DTOBase
    {
        protected VOBase _vo;

        public void SetVO(VOBase vo)
        {
            _vo = vo;
        }
    }
}