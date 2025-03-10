// documentation: https://docs.uipath.com/studio/standalone/2024.10/user-guide/coded-automations-introduction

using Demo_CustomClassInsideUiPathProject.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using Newtonsoft.Json;

namespace Demo_CustomClassInsideUiPathProject
{
    public class UserGroup
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public List<string> Users { get; set; }

        public UserGroup()
        {
            Address = new Address();
            Users = new List<string>();
            
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}