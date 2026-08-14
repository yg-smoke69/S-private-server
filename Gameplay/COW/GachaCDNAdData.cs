using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E3E")]
public class GachaCDNAdData
{
	[Token(Token = "0x4011AD8")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<uint, List<AdvertDesc>> m_GachaAdsDescDict;

	[Token(Token = "0x4011AD9")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, AdvertDesc> m_GachaTabADDict;

	[Token(Token = "0x4011ADA")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, AdvertDesc> m_TurntableCDNDict;

	[Token(Token = "0x4011ADB")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, AdvertDesc> m_LuckyBagCDNDict;

	[Token(Token = "0x4011ADC")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, AdvertDesc> m_GachaCDNBgCDNDict;

	[Token(Token = "0x4011ADD")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<uint, AdvertDesc> m_GachaTitleCDNDict;

	[Token(Token = "0x4011ADE")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, AdvertDesc> m_GachaFrontEndCDNBgCDNDict;

	[Token(Token = "0x4011ADF")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, AdvertDesc> m_GachaSplashCDNDict;

	[Token(Token = "0x4011AE0")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6013561")]
	[Address(RVA = "0x1050894", Offset = "0x1050894", VA = "0x1050894")]
	public GachaCDNAdData()
	{
	}

	[Token(Token = "0x6013562")]
	[Address(RVA = "0x10509E4", Offset = "0x10509E4", VA = "0x10509E4")]
	public void ResetData()
	{
	}

	[Token(Token = "0x6013563")]
	[Address(RVA = "0x1050BD8", Offset = "0x1050BD8", VA = "0x1050BD8")]
	public void GetGachaAdRes()
	{
	}

	[Token(Token = "0x6013564")]
	[Address(RVA = "0x10519D0", Offset = "0x10519D0", VA = "0x10519D0")]
	public List<AdvertDesc> GetCurAdList(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6013565")]
	[Address(RVA = "0x1051AB8", Offset = "0x1051AB8", VA = "0x1051AB8")]
	public AdvertDesc GetTabRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6013566")]
	[Address(RVA = "0x1051BA0", Offset = "0x1051BA0", VA = "0x1051BA0")]
	public AdvertDesc GetTurntableCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6013567")]
	[Address(RVA = "0x1051C88", Offset = "0x1051C88", VA = "0x1051C88")]
	public AdvertDesc GetGachaCDNBgCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6013568")]
	[Address(RVA = "0x1051D70", Offset = "0x1051D70", VA = "0x1051D70")]
	public AdvertDesc GetGachaTitleCDNBgRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6013569")]
	[Address(RVA = "0x1051E94", Offset = "0x1051E94", VA = "0x1051E94")]
	public AdvertDesc GetLuckBagCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601356A")]
	[Address(RVA = "0x1051F7C", Offset = "0x1051F7C", VA = "0x1051F7C")]
	public AdvertDesc GetSplashCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601356B")]
	[Address(RVA = "0x1052064", Offset = "0x1052064", VA = "0x1052064")]
	public AdvertDesc GetFrontEndCDNBgRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601356C")]
	[Address(RVA = "0x1051050", Offset = "0x1051050", VA = "0x1051050")]
	public void ProcessData(List<AdvertDesc> adList)
	{
	}

	[Token(Token = "0x601356D")]
	[Address(RVA = "0x105214C", Offset = "0x105214C", VA = "0x105214C")]
	private static int _003CProcessData_003Em__0(AdvertDesc a, AdvertDesc b)
	{
		return default(int);
	}
}
