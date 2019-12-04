﻿using System.Collections.Generic;
using System.Linq;

namespace Kartverket.Geonorge.Download.Models
{
    public class AccessConstraint
    {
        public static string Restricted = "restricted";
        public static string NorgeDigitalRestricted = "norway digital restricted";

        public string Constraint { get; set; }
        public string RequiredRole { get; set; }
        public List<string> RequiredRoles { get; set; }

        public string RequiredRolePolygonSelection { get; set; }
        public List<string> RequiredRolesPolygonSelection { get; set; }


        public bool IsOpen() => string.IsNullOrWhiteSpace(Constraint);

        public bool IsRestricted() => !IsOpen();

        public AccessConstraint() { }

        public AccessConstraint(string constraint, List<string> requiredRoles = null, List<string> requiredRolesPolygonSelection = null)
        {
            Constraint = constraint;
            RequiredRole = requiredRoles?.FirstOrDefault();
            RequiredRoles = requiredRoles;
            RequiredRolePolygonSelection = requiredRolesPolygonSelection?.FirstOrDefault();
            RequiredRolesPolygonSelection = requiredRolesPolygonSelection;
        }
    }
}