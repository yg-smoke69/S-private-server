using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B28")]
public class DebuggerFileOutput : MonoBehaviour
{
	[Token(Token = "0x40192C0")]
	[FieldOffset(Offset = "0x0")]
	public static DebuggerFileOutput instance;

	[Token(Token = "0x40192C1")]
	[FieldOffset(Offset = "0xC")]
	private List<string> m_OutputText;

	[Token(Token = "0x40192C2")]
	[FieldOffset(Offset = "0x10")]
	private string m_OutputFilePath;

	[Token(Token = "0x40192C3")]
	[FieldOffset(Offset = "0x14")]
	private StreamWriter m_Writer;

	[Token(Token = "0x60177C3")]
	[Address(RVA = "0x2317F88", Offset = "0x2317F88", VA = "0x2317F88")]
	public DebuggerFileOutput()
	{
	}

	[Token(Token = "0x60177C4")]
	[Address(RVA = "0x2318014", Offset = "0x2318014", VA = "0x2318014")]
	private void Start()
	{
	}

	[Token(Token = "0x60177C5")]
	[Address(RVA = "0x231821C", Offset = "0x231821C", VA = "0x231821C")]
	private void Update()
	{
	}

	[Token(Token = "0x60177C6")]
	[Address(RVA = "0x2318574", Offset = "0x2318574", VA = "0x2318574")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60177C7")]
	[Address(RVA = "0x2317800", Offset = "0x2317800", VA = "0x2317800")]
	public void Log(string msg)
	{
	}

	[Token(Token = "0x60177C8")]
	[Address(RVA = "0x231822C", Offset = "0x231822C", VA = "0x231822C")]
	public void Flush()
	{
	}

	[Token(Token = "0x60177C9")]
	[Address(RVA = "0x2316B1C", Offset = "0x2316B1C", VA = "0x2316B1C")]
	public void FlushToFile()
	{
	}

	[Token(Token = "0x60177CA")]
	[Address(RVA = "0x2316D2C", Offset = "0x2316D2C", VA = "0x2316D2C")]
	public void Close()
	{
	}
}
