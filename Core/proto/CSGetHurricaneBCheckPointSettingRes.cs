using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001949")]
public class CSGetHurricaneBCheckPointSettingRes
{
	[Token(Token = "0x4009F5B")]
	[FieldOffset(Offset = "0x8")]
	public List<HurricaneBMapShapeDesc> maps_shape;

	[Token(Token = "0x4009F5C")]
	[FieldOffset(Offset = "0xC")]
	public List<HurricaneBEleConfigDesc> maps_config;

	[Token(Token = "0x4009F5D")]
	[FieldOffset(Offset = "0x10")]
	public List<HurricaneBEleRandomDesc> random_descs;

	[Token(Token = "0x6007FA2")]
	[Address(RVA = "0x3185E68", Offset = "0x3185E68", VA = "0x3185E68")]
	public CSGetHurricaneBCheckPointSettingRes()
	{
	}
}
