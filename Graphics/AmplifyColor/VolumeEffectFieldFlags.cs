using System;
using System.Reflection;
using Il2CppDummyDll;

namespace AmplifyColor;

[Serializable]
[Token(Token = "0x2003B07")]
public class VolumeEffectFieldFlags
{
	[Token(Token = "0x4019248")]
	[FieldOffset(Offset = "0x8")]
	public string fieldName;

	[Token(Token = "0x4019249")]
	[FieldOffset(Offset = "0xC")]
	public string fieldType;

	[Token(Token = "0x401924A")]
	[FieldOffset(Offset = "0x10")]
	public bool blendFlag;

	[Token(Token = "0x60176D5")]
	[Address(RVA = "0x2EC7C84", Offset = "0x2EC7C84", VA = "0x2EC7C84")]
	public VolumeEffectFieldFlags(FieldInfo pi)
	{
	}

	[Token(Token = "0x60176D6")]
	[Address(RVA = "0x2EC7A18", Offset = "0x2EC7A18", VA = "0x2EC7A18")]
	public VolumeEffectFieldFlags(VolumeEffectField field)
	{
	}
}
