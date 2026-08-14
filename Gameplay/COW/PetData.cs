using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001EE")]
public class PetData : CSVBaseData
{
	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x8")]
	public string DefaultName;

	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0xC")]
	public string IdleAction;

	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x10")]
	public string FeedAction;

	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x14")]
	public string LobbyAction;

	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x18")]
	public string HDLobbyWalkAction;

	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x1C")]
	public int ID;

	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x20")]
	public int RareType;

	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x24")]
	public float NameHeight;

	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x28")]
	public uint MaxLevel;

	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x2C")]
	public float WanderAnimBaseSpeed;

	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x30")]
	public float WalkAnimBaseSpeed;

	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x34")]
	public float RunAnimBaseSpeed;

	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x38")]
	public float LobbyScale;

	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x3C")]
	public float IngameHeightMode;

	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x40")]
	public float IngameScaleMode;

	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x44")]
	public ResourceID IngameModel;

	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x48")]
	public ResourceID IngameModel3P;

	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x4C")]
	public ResourceID IngameSkinPrefabMode;

	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x50")]
	public ResourceID IngameSkinPrefab3PMode;

	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x54")]
	public ResourceID PreviewModel;

	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x58")]
	public ResourceID FeedSfx;

	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x5C")]
	public ResourceID LobbySfx;

	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x60")]
	public ResourceID LobbyVfx;

	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x64")]
	public ResourceID MultiFeedVFX;

	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x68")]
	public ResourceID FeedVFX;

	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x6C")]
	public ResourceID InGameBasicActionRes;

	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x70")]
	public ResourceID LobbyBasicActionRes;

	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x74")]
	public ResourceID ExtraActionRes;

	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x78")]
	public ResourceID WalkSfx;

	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x7C")]
	public float WalkSpeed;

	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x80")]
	public ResourceID IdleVoice;

	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x84")]
	public ResourceID CheerVoice;

	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x88")]
	public ResourceID ShowVoice;

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x1BFCAA8", Offset = "0x1BFCAA8", VA = "0x1BFCAA8")]
	public PetData()
	{
	}

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x1BFCB2C", Offset = "0x1BFCB2C", VA = "0x1BFCB2C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x1BFCB90", Offset = "0x1BFCB90", VA = "0x1BFCB90", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
