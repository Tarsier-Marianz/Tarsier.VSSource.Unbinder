using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarsier.Sources.Enumeration;
using Tarsier.UI;

namespace Tarsier.VSSource.Unbinder.Helpers {
    public class ParseType {
        public static ParseMessageType GetType(FileType type) {
            if(type == FileType.Solution) {
                return ParseMessageType.Solution;
            } else if(type == FileType.CsProj) {
                return ParseMessageType.CsProj;
            } else if(type == FileType.VbProj) {
                return ParseMessageType.VbProj;
            } else if(type == FileType.VsSource) {
                return ParseMessageType.VsSource;
            } else {
                return ParseMessageType.None;
            }
        }

        public static string GetStringType(FileType type) {
            if(type == FileType.Solution) {
                return "Solution";
            } else if(type == FileType.CsProj) {
                return "C# Project";
            } else if(type == FileType.VbProj) {
                return "VB Project";
            } else if(type == FileType.VsSource) {
                return "Source Control";
            } else {
                return "Unknown";
            }
        }
    }
}