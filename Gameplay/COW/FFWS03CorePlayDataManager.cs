using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000133")]
public class FFWS03CorePlayDataManager : SingletonModule<FFWS03CorePlayDataManager>
{
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, FFWS03SimulationContentData> m_dicSimulation;

	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, FFWS03WeaponListData> m_dicWeapon;

	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, FFWS03CharacterResourceData> m_dicCharacter;

	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, FFWS03ReportData> m_dicReportData;

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x2301294", Offset = "0x2301294", VA = "0x2301294")]
	public FFWS03CorePlayDataManager()
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x23013F4", Offset = "0x23013F4", VA = "0x23013F4")]
	public FFWS03SimulationContentData GetSimulationContentDataByRank(uint rank)
	{
		return null;
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x2301660", Offset = "0x2301660", VA = "0x2301660")]
	public FFWS03SimulationContentData GetSimulationContentDataByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x2301748", Offset = "0x2301748", VA = "0x2301748")]
	public string GetRandomWeaponName()
	{
		return null;
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x23018C0", Offset = "0x23018C0", VA = "0x23018C0")]
	public FFWS03WeaponListData GetRandomWeapon()
	{
		return null;
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x2301A94", Offset = "0x2301A94", VA = "0x2301A94")]
	public FFWS03WeaponListData GetWeaponDataByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x2301B7C", Offset = "0x2301B7C", VA = "0x2301B7C")]
	public string GetNameByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x2301D00", Offset = "0x2301D00", VA = "0x2301D00")]
	public FFWS03CharacterResourceData GetCharacterResourceDataByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x2301DE8", Offset = "0x2301DE8", VA = "0x2301DE8")]
	public FFWS03ReportData GetRandomDataByType(uint reportType)
	{
		return null;
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x23021A8", Offset = "0x23021A8", VA = "0x23021A8")]
	public FFWS03ReportData GetReportDataByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x2302290", Offset = "0x2302290", VA = "0x2302290", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x2302970", Offset = "0x2302970", VA = "0x2302970", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
