﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DomainClasses.Entities;
using DomainClasses.Entities.Users;

namespace ServiceLayer.Contracts
{
    public interface IPermissionService
    {
        XElement GetPermissionsAsXml(params string[] permissionNames);
        IList<string> GetUserPermissionsAsList(XElement permissionsAsXml);
        IList<string> GetUserPermissionsAsList(IList<XElement> permissionsAsXmls);

    }
}
