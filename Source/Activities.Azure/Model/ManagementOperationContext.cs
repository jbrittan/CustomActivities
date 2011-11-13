﻿// <autogenerated/>

// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------
#pragma warning disable 1591
namespace TfsBuildExtensions.Activities.Azure.Model
{
    using System.Security.Cryptography.X509Certificates;

    public class ManagementOperationContext
    {
        public string SubscriptionId
        {
            get;
            set;
        }

        public X509Certificate2 Certificate
        {
            get;
            set;
        }

        public string ServiceName
        {
            get;
            set;
        }

        public string OperationId
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}