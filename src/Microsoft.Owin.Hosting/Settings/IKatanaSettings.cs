﻿// <copyright file="IKatanaSettings.cs" company="Katana contributors">
//   Copyright 2011-2012 Katana contributors
// </copyright>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Owin;

namespace Microsoft.Owin.Hosting.Settings
{
    public interface IKatanaSettings
    {
        string DefaultServer { get; }
        string DefaultScheme { get; }
        string DefaultHost { get; }
        int? DefaultPort { get; }
        TextWriter DefaultOutput { get; }

        string ServerAssemblyPrefix { get; }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "By design")]
        Func<Func<string, Action<IAppBuilder>>> LoaderFactory { get; }
        Func<IAppBuilder> BuilderFactory { get; }
    }
}