using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000C7")]
public class BigHeadDataConfigManager : SingletonModule<BigHeadDataConfigManager>
{
	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ulong, BigHeadDataConfig> DatasMap;

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x180A060", Offset = "0x180A060", VA = "0x180A060")]
	public BigHeadDataConfigManager()
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x180A124", Offset = "0x180A124", VA = "0x180A124", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x180A178", Offset = "0x180A178", VA = "0x180A178", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x180A238", Offset = "0x180A238", VA = "0x180A238")]
	public BigHeadDataConfig GetData(uint map_id, uint mode_id, bool isWaitingRoom)
	{
		return null;
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x180A3B4", Offset = "0x180A3B4", VA = "0x180A3B4")]
	private BigHeadDataConfig LoadConfig(uint id)
	{
		return null;
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x180A610", Offset = "0x180A610", VA = "0x180A610")]
	private BigHeadDataConfig LoadConfig(ResourceID resId)
	{
		return null;
	}
}
