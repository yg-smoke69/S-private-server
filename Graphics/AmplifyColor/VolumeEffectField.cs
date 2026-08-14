using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyColor;

[Serializable]
[Token(Token = "0x2003B02")]
public class VolumeEffectField
{
	[Token(Token = "0x4019235")]
	[FieldOffset(Offset = "0x8")]
	public string fieldName;

	[Token(Token = "0x4019236")]
	[FieldOffset(Offset = "0xC")]
	public string fieldType;

	[Token(Token = "0x4019237")]
	[FieldOffset(Offset = "0x10")]
	public float valueSingle;

	[Token(Token = "0x4019238")]
	[FieldOffset(Offset = "0x14")]
	public Color valueColor;

	[Token(Token = "0x4019239")]
	[FieldOffset(Offset = "0x24")]
	public bool valueBoolean;

	[Token(Token = "0x401923A")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 valueVector2;

	[Token(Token = "0x401923B")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 valueVector3;

	[Token(Token = "0x401923C")]
	[FieldOffset(Offset = "0x3C")]
	public Vector4 valueVector4;

	[Token(Token = "0x60176B1")]
	[Address(RVA = "0x2EC4B34", Offset = "0x2EC4B34", VA = "0x2EC4B34")]
	public VolumeEffectField(string fieldName, string fieldType)
	{
	}

	[Token(Token = "0x60176B2")]
	[Address(RVA = "0x2EC7094", Offset = "0x2EC7094", VA = "0x2EC7094")]
	public VolumeEffectField(FieldInfo pi, Component c)
	{
	}

	[Token(Token = "0x60176B3")]
	[Address(RVA = "0x2EC6E50", Offset = "0x2EC6E50", VA = "0x2EC6E50")]
	public static bool IsValidType(string type)
	{
		return default(bool);
	}

	[Token(Token = "0x60176B4")]
	[Address(RVA = "0x2EC8CB0", Offset = "0x2EC8CB0", VA = "0x2EC8CB0")]
	public void UpdateValue(object val)
	{
	}
}
