using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000222")]
public class SceneEditPrefabConfigData : CSVBaseData
{
	[Token(Token = "0x2000223")]
	public enum ItemShowType
	{
		[Token(Token = "0x4000CD0")]
		AllPlatform,
		[Token(Token = "0x4000CD1")]
		CraftlandOnly,
		[Token(Token = "0x4000CD2")]
		FEOnly
	}

	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID EditAttributeConfigResID;

	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID FunctionAttributeConfigResID;

	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x14")]
	public string ItemTips;

	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID PrefabResID;

	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID IconResID;

	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x20")]
	public string Name;

	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x24")]
	public bool CanOverAll;

	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x28")]
	public uint[] CanOverAllExcept;

	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x2C")]
	public bool CannotBeCovered;

	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x30")]
	public float BoundExpands;

	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x34")]
	public uint[] Foundations;

	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x38")]
	public uint Cost;

	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x3C")]
	public bool ShowTex;

	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x40")]
	public ResourceID ShadowResID;

	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x44")]
	public bool HasSubItem;

	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x45")]
	public bool ShowGrass;

	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x48")]
	public uint HP;

	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x4C")]
	public bool IsPreciseAdjust;

	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x50")]
	public uint ItemType;

	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x54")]
	public bool ShowBitMap;

	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x58")]
	public uint NumLimit;

	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x5C")]
	public bool ShowIconMap;

	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x5D")]
	public bool CanAdjustFloor;

	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x60")]
	public int UniqueIntersection;

	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x64")]
	public float GroupSelectedScale;

	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x68")]
	public int ItemShowControl;

	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x6C")]
	public int ItemColor;

	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x241F724", Offset = "0x241F724", VA = "0x241F724")]
	public SceneEditPrefabConfigData()
	{
	}

	[Token(Token = "0x6000AD5")]
	[Address(RVA = "0x241F830", Offset = "0x241F830", VA = "0x241F830", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AD6")]
	[Address(RVA = "0x241F894", Offset = "0x241F894", VA = "0x241F894", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000AD7")]
	[Address(RVA = "0x24207AC", Offset = "0x24207AC", VA = "0x24207AC")]
	public bool CanPutOn(SceneEditPrefabConfigData otherConfig)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x242095C", Offset = "0x242095C", VA = "0x242095C")]
	public bool IsDynamicCreate()
	{
		return default(bool);
	}

	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x24209DC", Offset = "0x24209DC", VA = "0x24209DC")]
	public bool IsShowBitMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x2420A34", Offset = "0x2420A34", VA = "0x2420A34")]
	public bool IsShowIconMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6000ADB")]
	[Address(RVA = "0x2420A8C", Offset = "0x2420A8C", VA = "0x2420A8C")]
	public bool CanShadingColor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x2420AF0", Offset = "0x2420AF0", VA = "0x2420AF0")]
	public bool CanShadingColor(PNDELHDACMC type)
	{
		return default(bool);
	}
}
