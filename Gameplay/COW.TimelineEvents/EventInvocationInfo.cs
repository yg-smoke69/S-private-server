using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.TimelineEvents;

[Token(Token = "0x2000A4B")]
public class EventInvocationInfo
{
	[Token(Token = "0x4005B99")]
	[FieldOffset(Offset = "0x8")]
	public Behaviour TargetBehaviour;

	[Token(Token = "0x4005B9A")]
	[FieldOffset(Offset = "0xC")]
	public MethodInfo MethodInfo;

	[Token(Token = "0x4005B9B")]
	[FieldOffset(Offset = "0x0")]
	public static Type[] SupportedTypes;

	[Token(Token = "0x4005B9C")]
	[FieldOffset(Offset = "0x10")]
	public string Key;

	[Token(Token = "0x6004FF5")]
	[Address(RVA = "0x28A70D4", Offset = "0x28A70D4", VA = "0x28A70D4")]
	public EventInvocationInfo(string key, Behaviour targetBehaviour, MethodInfo methodInfo)
	{
	}

	[Token(Token = "0x6004FF6")]
	[Address(RVA = "0x28A7104", Offset = "0x28A7104", VA = "0x28A7104")]
	public void Invoke(object value)
	{
	}

	[Token(Token = "0x6004FF7")]
	[Address(RVA = "0x28A71F4", Offset = "0x28A71F4", VA = "0x28A71F4")]
	public void InvokEnum(int value)
	{
	}

	[Token(Token = "0x6004FF8")]
	[Address(RVA = "0x28A73A8", Offset = "0x28A73A8", VA = "0x28A73A8")]
	public void InvokeNoArgs()
	{
	}

	[Token(Token = "0x6004FF9")]
	[Address(RVA = "0x28A73C8", Offset = "0x28A73C8", VA = "0x28A73C8")]
	public void Invoke(bool isSingleArg, string value)
	{
	}
}
