using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004078")]
public class NetworkMessageDispatcher
{
	[Token(Token = "0x2004079")]
	public delegate void NetworkMessageHandler<T>(T arg);

	[Token(Token = "0x401B1CC")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<uint, NetworkMessageHandlerPair> m_Handlers;

	[Token(Token = "0x401B1CD")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, string> m_InvokeExceptionCmds;

	[Token(Token = "0x401B1CE")]
	[FieldOffset(Offset = "0x10")]
	private bool m_EnableSimpleInvokeExceptionInfo;

	[Token(Token = "0x401B1CF")]
	[FieldOffset(Offset = "0x14")]
	private object[] m_Param;

	[Token(Token = "0x17001CC4")]
	public bool EnableSimpleInvokeExceptionInfo
	{
		[Token(Token = "0x601A397")]
		[Address(RVA = "0x296D4AC", Offset = "0x296D4AC", VA = "0x296D4AC")]
		set
		{
		}
	}

	[Token(Token = "0x601A396")]
	[Address(RVA = "0x296D3A0", Offset = "0x296D3A0", VA = "0x296D3A0")]
	public NetworkMessageDispatcher()
	{
	}

	[Token(Token = "0x601A398")]
	public void RegisterHandler<T>(uint cmd, NetworkMessageHandler<T> handler)
	{
	}

	[Token(Token = "0x601A399")]
	[Address(RVA = "0x2979834", Offset = "0x2979834", VA = "0x2979834")]
	public void UnregisterHandlers(uint cmd)
	{
	}

	[Token(Token = "0x601A39A")]
	public void UnregisterHandler<T>(uint cmd, NetworkMessageHandler<T> handler)
	{
	}

	[Token(Token = "0x601A39B")]
	[Address(RVA = "0x29798EC", Offset = "0x29798EC", VA = "0x29798EC")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A39C")]
	[Address(RVA = "0x2969DA4", Offset = "0x2969DA4", VA = "0x2969DA4")]
	public Type GetCmdType(uint cmd)
	{
		return null;
	}

	[Token(Token = "0x601A39D")]
	[Address(RVA = "0x2969E5C", Offset = "0x2969E5C", VA = "0x2969E5C")]
	public void Invoke(uint cmd, object msg)
	{
	}
}
