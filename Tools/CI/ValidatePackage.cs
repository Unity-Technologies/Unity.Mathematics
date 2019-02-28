using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Unity.Properties.Serialization;
using UnityEditor;
using UnityEditor.PackageManager.ValidationSuite;
using UnityEngine;

public class ValidatePackage
{
    static List<string> failuresWhitelist = new List<string>{};// "Restricted File Type Validation", "Tests Validation" };

    [MenuItem("Window/Validate Mathematics")]
    public static void ValidateMathematics()
    {
        ValidateInternal("../package");
    }

    static void FilterWhitelistedFailures(string report)
    {
        var reportLines = report.Split(new string[] {"\r\n\r\n"}, StringSplitOptions.RemoveEmptyEntries);
        Array.Copy(reportLines, 2, reportLines, 0, reportLines.Length - 2);
        Regex regex = new Regex($"(\\w+)[ -]+\"([\\w\\s]+)\"\\s+(.*)");

        var issues = string.Empty;

        foreach (var line in reportLines)
        {
            var match = regex.Match(line);
            if (match.Success)
            {
                var status = match.Groups[1].Captures[0].Value;
                if (status != "Failed")
                    continue;
                var check = match.Groups[2].Captures[0].Value;
                var data = match.Groups[3].Captures[0].Value;

                if (status == "Failed" && failuresWhitelist.Contains(check))
                    continue;

                issues += line + "\r\n";
            }
        }

        if (issues != string.Empty)
        {
            throw new Exception(issues);
        }
    }

    public static void ValidateInternal(string packagePath)
    {
        var packageManifest = Path.Combine(packagePath, "package.json");
        if (!File.Exists(packageManifest))
            throw new Exception($"File package.json not found in {packagePath}");

        object dict;
        if (!Json.TryDeserializeObject(File.ReadAllText(packageManifest), out dict))
            throw new Exception($"Invalid package.json file in {packageManifest}");

        Json.TryGetValue((IDictionary<string, object>)dict, "name", out string name);
        Json.TryGetValue((IDictionary<string, object>)dict, "version", out string version);

        var result = ValidationSuite.ValidatePackage($"{name}@{version}", ValidationType.Publishing);
        if (!result)
            FilterWhitelistedFailures(ValidationSuite.GetValidationSuiteReport(name, version));
    }

    public static void Validate()
    {
        var arguments = Environment.GetCommandLineArgs();
        var executeMethodIndex = 0;
        while (executeMethodIndex < arguments.Length)
        {
            if (arguments[executeMethodIndex] == "-executeMethod")
                break;
            executeMethodIndex++;
        }

        // Need to advance by 2 elements because the format is -executeMethod Builders.Build <Target>
        // n.b.: executeMethodIndex is the index of -executeMethod
        var targetIndex = executeMethodIndex + 2;
        if (targetIndex >= arguments.Length || arguments[targetIndex].StartsWith("-"))
            throw new Exception("Wrong argument. To execute this method run unity with the parameter -executeMethod ValidatePackage.Validate <path_to_package>");

	    var packagePath = arguments[targetIndex];
        ValidateInternal(packagePath);
    }
}
