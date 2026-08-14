using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E74")]
public class ModifierKeyValueInt : _Attribute
{
	[Token(Token = "0x4011BB6")]
	[FieldOffset(Offset = "0x8")]
	public List<ModeVariableBinding> values;

	[Token(Token = "0x6013689")]
	[Address(RVA = "0x228E9F8", Offset = "0x228E9F8", VA = "0x228E9F8")]
	public ModifierKeyValueInt()
	{
	}

	[Token(Token = "0x601368A")]
	[Address(RVA = "0x228EA00", Offset = "0x228EA00", VA = "0x228EA00", Slot = "4")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
