using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001850")]
public class CSGetWinterFestStrategySettings
{
	[Token(Token = "0x4009CB1")]
	[FieldOffset(Offset = "0x8")]
	public List<WinterFestStrategyMainBuildingDesc> main_buiding_setting;

	[Token(Token = "0x4009CB2")]
	[FieldOffset(Offset = "0xC")]
	public List<WinterFestStrategyOrderDesc> order_setting;

	[Token(Token = "0x4009CB3")]
	[FieldOffset(Offset = "0x10")]
	public List<WinterFestStrategyBuildingDesc> building_setting;

	[Token(Token = "0x4009CB4")]
	[FieldOffset(Offset = "0x14")]
	public List<WinterFestStrategyResourceDesc> resource_setting;

	[Token(Token = "0x4009CB5")]
	[FieldOffset(Offset = "0x18")]
	public WinterFestStrategySettingDesc other_setting;

	[Token(Token = "0x4009CB6")]
	[FieldOffset(Offset = "0x1C")]
	public List<WinterFestStrategyItemDesc> item_setting;

	[Token(Token = "0x6007EAA")]
	[Address(RVA = "0x30968A8", Offset = "0x30968A8", VA = "0x30968A8")]
	public CSGetWinterFestStrategySettings()
	{
	}
}
