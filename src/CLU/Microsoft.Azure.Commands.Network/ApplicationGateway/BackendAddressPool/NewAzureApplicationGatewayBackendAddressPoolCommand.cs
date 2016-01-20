﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using Microsoft.Azure.Commands.Network.Models;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.New, "AzureRmApplicationGatewayBackendAddressPool"), OutputType(typeof(PSApplicationGatewayBackendAddressPool))]
    [CliCommandAlias("network app gateway backend address pool create")]
    public class NewAzureApplicationGatewayBackendAddressPoolCommand : AzureApplicationGatewayBackendAddressPoolBase
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            WriteObject(base.NewObject());
        }
    }
}
