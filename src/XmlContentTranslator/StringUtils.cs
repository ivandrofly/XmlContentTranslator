using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XmlContentTranslator
{
    public static class StringUtils
    {
        public static string Max50(string text)
        {
            if (text.Length > 50)
                return text.Substring(0, 50).Trim() + "...";
            return text;
        }

        public static string GetGitPath()
        {
            var envPath = Environment.GetEnvironmentVariable("PATH");
            if (!string.IsNullOrWhiteSpace(envPath))
            {
                foreach (var p in envPath.Split(Path.PathSeparator))
                {
                    var path = Path.Combine(p, "git.exe");
                    if (File.Exists(path))
                        return path;
                }
            }

            var gitPath = Path.Combine("Git", "bin", "git.exe");

            var envProgramFiles = Environment.GetEnvironmentVariable("ProgramFiles");
            if (!string.IsNullOrWhiteSpace(envProgramFiles))
            {
                var path = Path.Combine(envProgramFiles, gitPath);
                if (File.Exists(path))
                    return path;
            }

            envProgramFiles = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            if (!string.IsNullOrWhiteSpace(envProgramFiles))
            {
                var path = Path.Combine(envProgramFiles, gitPath);
                if (File.Exists(path))
                    return path;
            }

            var envSystemDrive = Environment.GetEnvironmentVariable("SystemDrive");
            if (!string.IsNullOrWhiteSpace(envSystemDrive))
            {
                var path = Path.Combine(envSystemDrive, "Program Files", gitPath);
                if (File.Exists(path))
                    return path;

                path = Path.Combine(envSystemDrive, "Program Files (x86)", gitPath);
                if (File.Exists(path))
                    return path;

                path = Path.Combine(envSystemDrive, gitPath);
                if (File.Exists(path))
                    return path;
            }

            try
            {
                var cRoot = new DriveInfo("C").RootDirectory.FullName;
                if (string.IsNullOrWhiteSpace(envSystemDrive) || !cRoot.StartsWith(envSystemDrive, StringComparison.OrdinalIgnoreCase))
                {
                    var path = Path.Combine(cRoot, "Program Files", gitPath);
                    if (File.Exists(path))
                        return path;

                    path = Path.Combine(cRoot, "Program Files (x86)", gitPath);
                    if (File.Exists(path))
                        return path;

                    path = Path.Combine(cRoot, gitPath);
                    if (File.Exists(path))
                        return path;
                }
            }
            catch
            {
            }
            return string.Empty;
        }
    }
}
