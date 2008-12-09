// 
// ViActions.cs
// 
// Author:
//   Michael Hutchinson <mhutchinson@novell.com>
// 
// Copyright (C) 2008 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;

namespace Mono.TextEditor.Vi
{
	
	
	public static class ViActions
	{
		public static void MoveToNextEmptyLine (TextEditorData data)
		{
			if (data.Caret.Line == data.Document.LineCount - 1) {
				data.Caret.Offset = data.Document.Length;
				return;
			}
			
			int line = data.Caret.Line + 1;
			LineSegment currentLine = data.Document.GetLine (line);
			while (line < data.Document.LineCount - 1) {
				line++;
				LineSegment nextLine = data.Document.GetLine (line);
				if (currentLine.EditableLength != 0 && nextLine.EditableLength == 0) {
					data.Caret.Offset = nextLine.Offset;
					return;
				}
				currentLine = nextLine;
			}
			
			data.Caret.Offset = currentLine.Offset;
		}
		
		public static void MoveToPreviousEmptyLine (TextEditorData data)
		{
			if (data.Caret.Line == 0) {
				data.Caret.Offset = 0;
				return;
			}
			
			int line = data.Caret.Line - 1;
			LineSegment currentLine = data.Document.GetLine (line);
			while (line > 0) {
				line--;
				LineSegment previousLine = data.Document.GetLine (line);
				if (currentLine.EditableLength != 0 && previousLine.EditableLength == 0) {
					data.Caret.Offset = previousLine.Offset;
					return;
				}
				currentLine = previousLine;
			}
			
			data.Caret.Offset = currentLine.Offset;
		}
		
		public static void NewLineBelow (TextEditorData data)
		{
			LineSegment currentLine = data.Document.GetLine (data.Caret.Line);
			data.Caret.Offset = currentLine.Offset + currentLine.EditableLength;
			MiscActions.InsertNewLine (data);
		}
		
		public static void NewLineAbove (TextEditorData data)
		{
			if (data.Caret.Line == 0) {
				data.Caret.Offset = 0;
				MiscActions.InsertNewLine (data);
				data.Caret.Offset = 0;
				return;
			}
			
			LineSegment currentLine = data.Document.GetLine (data.Caret.Line - 1);
			data.Caret.Offset = currentLine.Offset + currentLine.EditableLength;
			MiscActions.InsertNewLine (data);
		}
		
		public static void Join (TextEditorData data)
		{
			int startLine, endLine, startOffset, length, lastSpaceOffset;
			
			if (data.IsSomethingSelected) {
				startLine = data.Document.OffsetToLineNumber (data.SelectionRange.Offset);
				endLine = data.Document.OffsetToLineNumber (data.SelectionRange.EndOffset - 1);
			} else {
				startLine = endLine = data.Caret.Line;
			}
			
			//single-line joins
			if (endLine == startLine)
				endLine++;
			
			if (endLine >= data.Document.LineCount)
				return;
			
			LineSegment seg = data.Document.GetLine (startLine);
			startOffset = seg.Offset;
			StringBuilder sb = new StringBuilder (data.Document.GetTextAt (seg).TrimEnd ());
			lastSpaceOffset = startOffset + sb.Length;
			
			for (int i = startLine + 1; i <= endLine; i++) {
				seg = data.Document.GetLine (i);
				lastSpaceOffset = startOffset + sb.Length;
				sb.Append (" ");
				sb.Append (data.Document.GetTextAt (seg).Trim ());
			}
			length = (seg.Offset - startOffset) + seg.EditableLength;
			
			data.Document.Replace (startOffset, length, sb.ToString ());
			data.Caret.Offset = lastSpaceOffset;
		}
	}
}
