using Il2CppDummyDll;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CEE")]
public class OldMapData
{
	[Token(Token = "0x400687E")]
	[FieldOffset(Offset = "0x8")]
	public string GameName;

	[Token(Token = "0x400687F")]
	[FieldOffset(Offset = "0xC")]
	public string GameDesc;

	[Token(Token = "0x4006880")]
	[FieldOffset(Offset = "0x10")]
	public ulong UpdateTime;

	[Token(Token = "0x4006881")]
	[FieldOffset(Offset = "0x18")]
	public uint EditGameMode;

	[Token(Token = "0x4006882")]
	[FieldOffset(Offset = "0x1C")]
	public uint EditGroupMode;

	[Token(Token = "0x4006883")]
	[FieldOffset(Offset = "0x20")]
	public uint EditTeamCount;

	[Token(Token = "0x4006884")]
	[FieldOffset(Offset = "0x24")]
	public uint TotalCost;

	[Token(Token = "0x4006885")]
	[FieldOffset(Offset = "0x28")]
	public byte[] workshopSetting;

	[Token(Token = "0x4006886")]
	[FieldOffset(Offset = "0x2C")]
	public byte[] modeSetting;

	[Token(Token = "0x4006887")]
	[FieldOffset(Offset = "0x30")]
	public byte[] attributeSetting;

	[Token(Token = "0x6006208")]
	[Address(RVA = "0x2F5A854", Offset = "0x2F5A854", VA = "0x2F5A854")]
	public OldMapData()
	{
	}
}
