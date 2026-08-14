using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E76")]
public class ModifierControlSkillCDByRegion : _Attribute
{
	[Token(Token = "0x4011BB8")]
	[FieldOffset(Offset = "0x8")]
	public string SkillType;

	[Token(Token = "0x601368D")]
	[Address(RVA = "0x228E614", Offset = "0x228E614", VA = "0x228E614")]
	public ModifierControlSkillCDByRegion()
	{
	}

	[Token(Token = "0x601368E")]
	[Address(RVA = "0x228E6B4", Offset = "0x228E6B4", VA = "0x228E6B4", Slot = "4")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
