using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DB3")]
public class BillboardLocalizationDataManager : SingletonModule<BillboardLocalizationDataManager>
{
	[Token(Token = "0x401189C")]
	[FieldOffset(Offset = "0x0")]
	public static string RegionSettingKey;

	[Token(Token = "0x401189D")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, BillboardLocalizationData> m_BillboardLocalizationDict;

	[Token(Token = "0x601321E")]
	[Address(RVA = "0x180B448", Offset = "0x180B448", VA = "0x180B448")]
	public BillboardLocalizationDataManager()
	{
	}

	[Token(Token = "0x601321F")]
	[Address(RVA = "0x180B50C", Offset = "0x180B50C", VA = "0x180B50C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013220")]
	[Address(RVA = "0x180B758", Offset = "0x180B758", VA = "0x180B758", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013221")]
	[Address(RVA = "0x180B820", Offset = "0x180B820", VA = "0x180B820")]
	public BillboardLocalizationData FindLocDataByRegion(string region)
	{
		return null;
	}
}
