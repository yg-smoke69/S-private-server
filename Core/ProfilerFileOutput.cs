using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B29")]
public class ProfilerFileOutput : MonoBehaviour
{
	[Token(Token = "0x40192C4")]
	[FieldOffset(Offset = "0x0")]
	public static ProfilerFileOutput instance;

	[Token(Token = "0x40192C5")]
	[FieldOffset(Offset = "0xC")]
	private List<string> m_OutputText;

	[Token(Token = "0x40192C6")]
	[FieldOffset(Offset = "0x10")]
	private string m_OutputFilePath;

	[Token(Token = "0x40192C7")]
	[FieldOffset(Offset = "0x14")]
	private StreamWriter m_Writer;

	[Token(Token = "0x60177CC")]
	[Address(RVA = "0x1E30960", Offset = "0x1E30960", VA = "0x1E30960")]
	public ProfilerFileOutput()
	{
	}

	[Token(Token = "0x60177CD")]
	[Address(RVA = "0x1E309EC", Offset = "0x1E309EC", VA = "0x1E309EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60177CE")]
	[Address(RVA = "0x1E30B74", Offset = "0x1E30B74", VA = "0x1E30B74")]
	private void Update()
	{
	}

	[Token(Token = "0x60177CF")]
	[Address(RVA = "0x1E30E18", Offset = "0x1E30E18", VA = "0x1E30E18")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60177D0")]
	[Address(RVA = "0x1E30E9C", Offset = "0x1E30E9C", VA = "0x1E30E9C")]
	public void Log(string msg)
	{
	}

	[Token(Token = "0x60177D1")]
	[Address(RVA = "0x1E30B84", Offset = "0x1E30B84", VA = "0x1E30B84")]
	public void Flush()
	{
	}

	[Token(Token = "0x60177D2")]
	[Address(RVA = "0x1E30F7C", Offset = "0x1E30F7C", VA = "0x1E30F7C")]
	public void FlushToFile()
	{
	}

	[Token(Token = "0x60177D3")]
	[Address(RVA = "0x1E30E68", Offset = "0x1E30E68", VA = "0x1E30E68")]
	public void Close()
	{
	}
}
