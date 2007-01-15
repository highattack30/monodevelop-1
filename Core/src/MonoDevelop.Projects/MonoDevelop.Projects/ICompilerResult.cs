// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version value="$version"/>
// </file>

using System.Collections;
using System.CodeDom.Compiler;
using System.Xml;

namespace MonoDevelop.Projects
{
	/// <summary>
	/// Each language module which is capable of compiling source
	/// files gives back an ICompilerResult object which contains
	/// the output of the compiler and the compilerresults which contain
	/// all warnings and errors.
	/// </summary>
	public interface ICompilerResult
	{
		/// <summary>
		/// the compilerresults which contain all warnings and errors the compiler
		/// produces.
		/// </summary>
		CompilerResults CompilerResults {
			get;
		}
		
		int WarningCount  { get; }
		
		int ErrorCount { get; }
		
		int BuildCount { get; }
		
		int FailedBuildCount { get; }
		
		/// <summary>
		/// The console output of the compiler as string.
		/// </summary>
		string CompilerOutput {
			get;
		}
		
		void AddError (string file, int line, int col, string errorNum, string text);
		void AddError (string text);
		void AddWarning (string file, int line, int col, string errorNum, string text);
		void AddWarning (string text);
	}
}
