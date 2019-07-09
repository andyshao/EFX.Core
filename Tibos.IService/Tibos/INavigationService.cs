﻿using System;
using System.Collections.Generic;
using System.Text;
using Tibos.Domain;
using Tibos.IService;

//EFX Code Generation Template 1.0
//author:Tibos
//blog:www.cnblogs.com/Tibos
//Entity Code Generation Template
namespace Tibos.IService.Tibos
{
	public interface INavigationService:IBaseService<Navigation>
	{
        List<Navigation> GetList(string userId);
    }
}