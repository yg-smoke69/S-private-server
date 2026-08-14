using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E75")]
public class ModifierInIntArray : _Attribute
{
	[Token(Token = "0x4011BB7")]
	[FieldOffset(Offset = "0x8")]
	public List<int> values;

	[Token(Token = "0x601368B")]
	[Address(RVA = "0x228E858", Offset = "0x228E858", VA = "0x228E858")]
	public ModifierInIntArray()
	{
	}

	[Token(Token = "0x601368C")]
	[Address(RVA = "0x228E860", Offset = "0x228E860", VA = "0x228E860", Slot = "4")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
