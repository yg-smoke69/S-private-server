using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001842")]
public class CSGetBooyahChessConfigRes
{
	[Token(Token = "0x4009C82")]
	[FieldOffset(Offset = "0x8")]
	public List<BooyahChessZoneDesc> zones;

	[Token(Token = "0x4009C83")]
	[FieldOffset(Offset = "0xC")]
	public BooyahChessSettingDesc setting;

	[Token(Token = "0x4009C84")]
	[FieldOffset(Offset = "0x10")]
	public List<BooyahChessWeaponDesc> weapons;

	[Token(Token = "0x6007E9C")]
	[Address(RVA = "0x3182430", Offset = "0x3182430", VA = "0x3182430")]
	public CSGetBooyahChessConfigRes()
	{
	}
}
