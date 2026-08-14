using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200012B")]
public class EventClothEffectsData : CSVBaseData
{
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x8")]
	public uint StateID;

	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0xC")]
	public uint ClothID;

	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x10")]
	public uint EffectsTriggerID;

	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID EffectIDM;

	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID EffectIDF;

	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID LobbyEffectIDM;

	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID LobbyEffectIDF;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID MaleRefID;

	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID FEMaleRefID;

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x253B2A0", Offset = "0x253B2A0", VA = "0x253B2A0")]
	public EventClothEffectsData()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x253B3A8", Offset = "0x253B3A8", VA = "0x253B3A8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x253B40C", Offset = "0x253B40C", VA = "0x253B40C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x253BD5C", Offset = "0x253BD5C", VA = "0x253BD5C")]
	public bool HasLobbySpecializedEffect(bool isFemale)
	{
		return default(bool);
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x253BE68", Offset = "0x253BE68", VA = "0x253BE68")]
	public ResourceID GetLobbyEffect(bool isFemale)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x253B158", Offset = "0x253B158", VA = "0x253B158")]
	public static EventClothEffectsData PartialClone(EventClothEffectsData d)
	{
		return null;
	}
}
