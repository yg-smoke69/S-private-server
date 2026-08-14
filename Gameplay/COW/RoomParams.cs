using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200300F")]
public class RoomParams
{
	[Token(Token = "0x40124AC")]
	[FieldOffset(Offset = "0x8")]
	public uint configID;

	[Token(Token = "0x40124AD")]
	[FieldOffset(Offset = "0xC")]
	public uint group;

	[Token(Token = "0x40124AE")]
	[FieldOffset(Offset = "0x10")]
	public uint member;

	[Token(Token = "0x40124AF")]
	[FieldOffset(Offset = "0x14")]
	public uint spectator;

	[Token(Token = "0x40124B0")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40124B1")]
	[FieldOffset(Offset = "0x1C")]
	public string code;

	[Token(Token = "0x40124B2")]
	[FieldOffset(Offset = "0x20")]
	public bool enableSpectate;

	[Token(Token = "0x40124B3")]
	[FieldOffset(Offset = "0x24")]
	public uint roomType;

	[Token(Token = "0x40124B4")]
	[FieldOffset(Offset = "0x28")]
	public uint visualStyle;

	[Token(Token = "0x40124B5")]
	[FieldOffset(Offset = "0x2C")]
	public uint setting;

	[Token(Token = "0x40124B6")]
	[FieldOffset(Offset = "0x30")]
	public uint setting2;

	[Token(Token = "0x40124B7")]
	[FieldOffset(Offset = "0x34")]
	public bool emulatorCheck;

	[Token(Token = "0x40124B8")]
	[FieldOffset(Offset = "0x35")]
	public bool contestantRoleCheck;

	[Token(Token = "0x40124B9")]
	[FieldOffset(Offset = "0x36")]
	public bool roomDataInherit;

	[Token(Token = "0x40124BA")]
	[FieldOffset(Offset = "0x38")]
	public string workshopCode;

	[Token(Token = "0x40124BB")]
	[FieldOffset(Offset = "0x40")]
	public long workshopUpldateTime;

	[Token(Token = "0x40124BC")]
	[FieldOffset(Offset = "0x48")]
	public uint workshopSrc;

	[Token(Token = "0x40124BD")]
	[FieldOffset(Offset = "0x4C")]
	public uint ugcScene;

	[Token(Token = "0x40124BE")]
	[FieldOffset(Offset = "0x50")]
	public EInventory.ItemSubType limitedCardType;

	[Token(Token = "0x601412C")]
	[Address(RVA = "0x24176D0", Offset = "0x24176D0", VA = "0x24176D0")]
	public RoomParams()
	{
	}
}
