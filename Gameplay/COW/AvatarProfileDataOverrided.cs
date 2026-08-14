using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DA7")]
public class AvatarProfileDataOverrided
{
	[Token(Token = "0x401185A")]
	[FieldOffset(Offset = "0x8")]
	public string ProfileTitle;

	[Token(Token = "0x401185B")]
	[FieldOffset(Offset = "0xC")]
	public string Occupation;

	[Token(Token = "0x401185C")]
	[FieldOffset(Offset = "0x10")]
	public string Age;

	[Token(Token = "0x401185D")]
	[FieldOffset(Offset = "0x14")]
	public string Birthday;

	[Token(Token = "0x401185E")]
	[FieldOffset(Offset = "0x18")]
	public string Hobby;

	[Token(Token = "0x401185F")]
	[FieldOffset(Offset = "0x1C")]
	public string Relationship1;

	[Token(Token = "0x4011860")]
	[FieldOffset(Offset = "0x20")]
	public string Relationship2;

	[Token(Token = "0x4011861")]
	[FieldOffset(Offset = "0x24")]
	public string Relationship3;

	[Token(Token = "0x4011862")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID RelationshipID1;

	[Token(Token = "0x4011863")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID RelationshipID2;

	[Token(Token = "0x4011864")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID RelationshipID3;

	[Token(Token = "0x4011865")]
	[FieldOffset(Offset = "0x34")]
	public uint RelationshipRealID1;

	[Token(Token = "0x4011866")]
	[FieldOffset(Offset = "0x38")]
	public uint RelationshipRealID2;

	[Token(Token = "0x4011867")]
	[FieldOffset(Offset = "0x3C")]
	public uint RelationshipRealID3;

	[Token(Token = "0x4011868")]
	[FieldOffset(Offset = "0x40")]
	public uint pID;

	[Token(Token = "0x4011869")]
	[FieldOffset(Offset = "0x44")]
	public uint ID;

	[Token(Token = "0x401186A")]
	[FieldOffset(Offset = "0x48")]
	public uint Level;

	[Token(Token = "0x401186B")]
	[FieldOffset(Offset = "0x4C")]
	public uint UnlockLevel;

	[Token(Token = "0x401186C")]
	[FieldOffset(Offset = "0x50")]
	public uint RewardId;

	[Token(Token = "0x401186D")]
	[FieldOffset(Offset = "0x54")]
	public uint RewardTime;

	[Token(Token = "0x401186E")]
	[FieldOffset(Offset = "0x58")]
	public uint DebrisID;

	[Token(Token = "0x401186F")]
	[FieldOffset(Offset = "0x5C")]
	public uint DebrisCount;

	[Token(Token = "0x4011870")]
	[FieldOffset(Offset = "0x60")]
	public uint CoinValue;

	[Token(Token = "0x4011871")]
	[FieldOffset(Offset = "0x64")]
	public uint GemValue;

	[Token(Token = "0x4011872")]
	[FieldOffset(Offset = "0x68")]
	public uint ItemID;

	[Token(Token = "0x4011873")]
	[FieldOffset(Offset = "0x6C")]
	public uint ItemCnt;

	[Token(Token = "0x4011874")]
	[FieldOffset(Offset = "0x70")]
	public EInventory.AwardType RewardType;

	[Token(Token = "0x60131D4")]
	[Address(RVA = "0x23524A0", Offset = "0x23524A0", VA = "0x23524A0")]
	public AvatarProfileDataOverrided()
	{
	}
}
