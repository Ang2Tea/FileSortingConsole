﻿using FileSorting.Core;
using FileSorting.Core.Configs;
using FileSortingConsole;
using FileSortingConsole.Parser;

ConfigParser<StandartConfig> configParser = new();
ConsoleLogger logger = new();
FilesSorting sorting = new(configParser.Parse(), logger);

sorting.StartMovingFile();