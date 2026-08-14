using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000BA")]
public class EpicClothesTextData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x8")]
	public uint ClothesID;

	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0xC")]
	public string[] Conditions;

	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID WaitingRoomEffect;

	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID[] KillEffects;

	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID[] ActionEffects;

	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID[] InGameActionEffects;

	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID Flag;

	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID ToggleIcon;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x28")]
	public uint ChickenSprite;

	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x2C")]
	public uint LootBox;

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x2538E68", Offset = "0x2538E68", VA = "0x2538E68")]
	public EpicClothesTextData()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x2538EEC", Offset = "0x2538EEC", VA = "0x2538EEC", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x2538F44", Offset = "0x2538F44", VA = "0x2538F44", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x2538FA8", Offset = "0x2538FA8", VA = "0x2538FA8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x2539320", Offset = "0x2539320", VA = "0x2539320")]
	public ResourceID GetKillEffect(int level)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x25394B8", Offset = "0x25394B8", VA = "0x25394B8")]
	public ResourceID GetActionEffect(int level)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x2539528", Offset = "0x2539528", VA = "0x2539528")]
	public ResourceID GetInGameActionEffect(int level)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x2539390", Offset = "0x2539390", VA = "0x2539390")]
	public ResourceID GetEffect(ResourceID[] reses, int level)
	{
		return default(ResourceID);
	}
}
