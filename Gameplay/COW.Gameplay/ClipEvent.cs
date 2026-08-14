using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay;

[Serializable]
[Token(Token = "0x20003EB")]
public class ClipEvent
{
	[Token(Token = "0x40039B1")]
	[FieldOffset(Offset = "0x8")]
	public AnimEventType m_EventType;

	[Token(Token = "0x40039B2")]
	[FieldOffset(Offset = "0xC")]
	public float m_Time;

	[Token(Token = "0x40039B3")]
	[FieldOffset(Offset = "0x10")]
	public string m_FunctionName;

	[Token(Token = "0x40039B4")]
	[FieldOffset(Offset = "0x14")]
	public string m_StringParameter;

	[Token(Token = "0x40039B5")]
	[FieldOffset(Offset = "0x18")]
	public float m_FloatParameter;

	[Token(Token = "0x40039B6")]
	[FieldOffset(Offset = "0x1C")]
	public int m_IntParameter;

	[Token(Token = "0x40039B7")]
	[FieldOffset(Offset = "0x20")]
	public Object m_GameObjectParameter;

	[Token(Token = "0x6001267")]
	[Address(RVA = "0x24A26DC", Offset = "0x24A26DC", VA = "0x24A26DC")]
	public ClipEvent()
	{
	}
}
