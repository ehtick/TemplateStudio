﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization
{
    internal class LocalizationTool
    {
        public LocalizationTool()
        {
        }

        public void GenerateProjectTemplatesAndCommandsHandler(ToolCommandInfo commandInfo)
        {
            if (commandInfo.Arguments == null || commandInfo.Arguments.Length < 3)
            {
                throw new Exception("Error executing command. Too few arguments.");
            }
            string sourceDirectory = commandInfo.Arguments[0];
            string destinationDirectory = commandInfo.Arguments[1];
            List<string> cultures = new List<string>(commandInfo.Arguments[2].Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries));
            ProjectTemplateGenerator projectTemplateGenerator = new ProjectTemplateGenerator(sourceDirectory, destinationDirectory);
            projectTemplateGenerator.GenerateProjectTemplates(cultures);
            RightClickCommandGenerator rightClickCommandGenerator = new RightClickCommandGenerator(sourceDirectory, destinationDirectory);
            rightClickCommandGenerator.GenerateRightClickCommands(cultures);
        }

        public void ExtractLocalizableItems(ToolCommandInfo commandInfo)
        {
            if (commandInfo.Arguments == null || commandInfo.Arguments.Length < 3)
            {
                throw new Exception("Error executing command. Too few arguments.");
            }
            string sourceDirectory = commandInfo.Arguments[0];
            string destinationDirectory = commandInfo.Arguments[1];
            List<string> cultures = new List<string>(commandInfo.Arguments[2].Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries));
            LocalizableItemsExtractor extractor = new LocalizableItemsExtractor(sourceDirectory, destinationDirectory);
            extractor.ExtractVsix(cultures);
            extractor.ExtractProjectTemplates(cultures);
            extractor.ExtractCommandTemplates(cultures);
            extractor.ExtractTemplateEngineTemplates(cultures);
            extractor.ExtractWtsTemplates(cultures);
            extractor.ExtractResourceFiles(cultures);
        }
    }
}
