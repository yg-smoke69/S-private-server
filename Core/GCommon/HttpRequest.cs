using System;
using System.Collections.Generic;
using COW;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200405D")]
public class HttpRequest
{
	[Token(Token = "0x401B156")]
	[FieldOffset(Offset = "0x0")]
	public static bool DelegateCheck;

	[Token(Token = "0x401B157")]
	private const int MAX_RETRY_COUNT = 5;

	[Token(Token = "0x401B158")]
	[FieldOffset(Offset = "0x8")]
	public string URL;

	[Token(Token = "0x401B159")]
	[FieldOffset(Offset = "0xC")]
	public string Cmd;

	[Token(Token = "0x401B15A")]
	[FieldOffset(Offset = "0x10")]
	public float Timeout;

	[Token(Token = "0x401B15B")]
	[FieldOffset(Offset = "0x14")]
	public byte[] Data;

	[Token(Token = "0x401B15C")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<string, string> Headers;

	[Token(Token = "0x401B15D")]
	[FieldOffset(Offset = "0x1C")]
	public WWW www;

	[Token(Token = "0x401B15E")]
	[FieldOffset(Offset = "0x20")]
	public Action<HttpErrorCode, object> OnFinished;

	[Token(Token = "0x401B15F")]
	[FieldOffset(Offset = "0x24")]
	public Type ResponseType;

	[Token(Token = "0x401B160")]
	[FieldOffset(Offset = "0x28")]
	public EHttpDataType DataType;

	[Token(Token = "0x401B161")]
	[FieldOffset(Offset = "0x2C")]
	public uint HttpOption;

	[Token(Token = "0x401B162")]
	[FieldOffset(Offset = "0x30")]
	public bool IsDone;

	[Token(Token = "0x401B163")]
	[FieldOffset(Offset = "0x31")]
	public bool IsBlock;

	[Token(Token = "0x401B164")]
	[FieldOffset(Offset = "0x32")]
	public bool IsTimeOut;

	[Token(Token = "0x401B165")]
	[FieldOffset(Offset = "0x33")]
	public bool GetAnswer;

	[Token(Token = "0x401B166")]
	[FieldOffset(Offset = "0x34")]
	private int m_SendCount;

	[Token(Token = "0x401B167")]
	[FieldOffset(Offset = "0x38")]
	private string m_LastErrorMessage;

	[Token(Token = "0x401B168")]
	[FieldOffset(Offset = "0x3C")]
	public LoadingType loadingType;

	[Token(Token = "0x401B169")]
	[FieldOffset(Offset = "0x40")]
	private object blockAnswer;

	[Token(Token = "0x17001CBB")]
	public string LastErrorMessage
	{
		[Token(Token = "0x601A332")]
		[Address(RVA = "0x32B8A04", Offset = "0x32B8A04", VA = "0x32B8A04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A331")]
	[Address(RVA = "0x32BAA54", Offset = "0x32BAA54", VA = "0x32BAA54")]
	public HttpRequest()
	{
	}

	[Token(Token = "0x601A333")]
	[Address(RVA = "0x32BB4A4", Offset = "0x32BB4A4", VA = "0x32BB4A4")]
	public void Start(string token)
	{
	}

	[Token(Token = "0x601A334")]
	[Address(RVA = "0x32BB73C", Offset = "0x32BB73C", VA = "0x32BB73C")]
	public bool NeedRetry()
	{
		return default(bool);
	}

	[Token(Token = "0x601A335")]
	[Address(RVA = "0x32BB750", Offset = "0x32BB750", VA = "0x32BB750")]
	public bool HasRetried()
	{
		return default(bool);
	}

	[Token(Token = "0x601A336")]
	[Address(RVA = "0x32BA3D4", Offset = "0x32BA3D4", VA = "0x32BA3D4")]
	public bool IsStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x601A337")]
	[Address(RVA = "0x32B97D0", Offset = "0x32B97D0", VA = "0x32B97D0")]
	public bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A338")]
	[Address(RVA = "0x32B9858", Offset = "0x32B9858", VA = "0x32B9858")]
	public bool IsUnauthorized()
	{
		return default(bool);
	}

	[Token(Token = "0x601A339")]
	[Address(RVA = "0x32BA328", Offset = "0x32BA328", VA = "0x32BA328")]
	public void RemoveBlock()
	{
	}

	[Token(Token = "0x601A33A")]
	[Address(RVA = "0x32B95E0", Offset = "0x32B95E0", VA = "0x32B95E0")]
	public void InvokeTimeOut()
	{
	}

	[Token(Token = "0x601A33B")]
	[Address(RVA = "0x32B9948", Offset = "0x32B9948", VA = "0x32B9948")]
	public void Notify()
	{
	}

	[Token(Token = "0x601A33C")]
	[Address(RVA = "0x32B9524", Offset = "0x32B9524", VA = "0x32B9524")]
	public void Dispose()
	{
	}

	[Token(Token = "0x601A33D")]
	[Address(RVA = "0x32BB764", Offset = "0x32BB764", VA = "0x32BB764")]
	private HttpErrorCode GetResponseCode()
	{
		return default(HttpErrorCode);
	}

	[Token(Token = "0x601A33E")]
	[Address(RVA = "0x32BC018", Offset = "0x32BC018", VA = "0x32BC018")]
	private HttpErrorCode GetDetailedExectionError()
	{
		return default(HttpErrorCode);
	}

	[Token(Token = "0x601A33F")]
	[Address(RVA = "0x32BB958", Offset = "0x32BB958", VA = "0x32BB958")]
	private void InvokeFinished(HttpErrorCode errorCode, object res, string errorMsg)
	{
	}
}
