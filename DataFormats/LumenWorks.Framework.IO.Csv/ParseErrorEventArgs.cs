using System;
using Il2CppDummyDll;

namespace LumenWorks.Framework.IO.Csv;

[Token(Token = "0x2003B90")]
public class ParseErrorEventArgs : EventArgs
{
	[Token(Token = "0x401963D")]
	[FieldOffset(Offset = "0x8")]
	private MalformedCsvException _error;

	[Token(Token = "0x401963E")]
	[FieldOffset(Offset = "0xC")]
	private ParseErrorAction _action;

	[Token(Token = "0x17001890")]
	public MalformedCsvException Error
	{
		[Token(Token = "0x6017C78")]
		[Address(RVA = "0x1C68978", Offset = "0x1C68978", VA = "0x1C68978")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001891")]
	public ParseErrorAction Action
	{
		[Token(Token = "0x6017C79")]
		[Address(RVA = "0x1C68970", Offset = "0x1C68970", VA = "0x1C68970")]
		get
		{
			return default(ParseErrorAction);
		}
		[Token(Token = "0x6017C7A")]
		[Address(RVA = "0x1C6A170", Offset = "0x1C6A170", VA = "0x1C6A170")]
		set
		{
		}
	}

	[Token(Token = "0x6017C77")]
	[Address(RVA = "0x1C688DC", Offset = "0x1C688DC", VA = "0x1C688DC")]
	public ParseErrorEventArgs(MalformedCsvException error, ParseErrorAction defaultAction)
	{
	}
}
