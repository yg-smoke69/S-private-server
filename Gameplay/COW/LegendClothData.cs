using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20000B7")]
public class LegendClothData : CsvDataIndexedReading, _Attribute
{
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x8")]
	public uint SetId;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0xC")]
	public uint LegentType;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x10")]
	public uint Level;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID ParachuteEffectMale;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID ParachuteEffectFemale;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x1C")]
	public Color ColorVal;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID ColorIcon;

	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID ParachuteEffectIcon;

	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x34")]
	public ResourceID TeamEffectIcon;

	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x38")]
	public string Title;

	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x3C")]
	public string Story;

	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x40")]
	public ResourceID IPTag;

	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x44")]
	public List<ResourceID> OtherTags;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x48")]
	public uint ArriveAnimId;

	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x4C")]
	public ResourceID FootHaloMale;

	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x50")]
	public ResourceID FootHaloFemale;

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x54")]
	public ResourceID FootHaloIcon;

	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x58")]
	public uint BundleId;

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x1EF9C74", Offset = "0x1EF9C74", VA = "0x1EF9C74")]
	public LegendClothData()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x1EF9C7C", Offset = "0x1EF9C7C", VA = "0x1EF9C7C", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x1EF9CD4", Offset = "0x1EF9CD4", VA = "0x1EF9CD4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x1EF9D38", Offset = "0x1EF9D38", VA = "0x1EF9D38", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x1EFA594", Offset = "0x1EFA594", VA = "0x1EFA594", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x1EFB97C", Offset = "0x1EFB97C", VA = "0x1EFB97C")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x1EFB984", Offset = "0x1EFB984", VA = "0x1EFB984")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
