using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032DE")]
internal class WorkShopLevelExpDataManager : SingletonModule<WorkShopLevelExpDataManager>
{
	[Token(Token = "0x4013597")]
	[FieldOffset(Offset = "0xC")]
	private List<WorkShopLevelExp> m_WorkShopLevelExpList;

	[Token(Token = "0x4013598")]
	[FieldOffset(Offset = "0x10")]
	private List<uint> m_LevelLst;

	[Token(Token = "0x601570E")]
	[Address(RVA = "0x21BC520", Offset = "0x21BC520", VA = "0x21BC520")]
	public WorkShopLevelExpDataManager()
	{
	}

	[Token(Token = "0x601570F")]
	[Address(RVA = "0x21BC5E4", Offset = "0x21BC5E4", VA = "0x21BC5E4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015710")]
	[Address(RVA = "0x21BC834", Offset = "0x21BC834", VA = "0x21BC834")]
	public List<WorkShopLevelExp> GetWorkShopLevelExpList()
	{
		return null;
	}

	[Token(Token = "0x6015711")]
	[Address(RVA = "0x21BC88C", Offset = "0x21BC88C", VA = "0x21BC88C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6015712")]
	[Address(RVA = "0x21BC978", Offset = "0x21BC978", VA = "0x21BC978")]
	public bool CheckLevelIsMax(uint exp)
	{
		return default(bool);
	}

	[Token(Token = "0x6015713")]
	[Address(RVA = "0x21BCB38", Offset = "0x21BCB38", VA = "0x21BCB38")]
	public WorkShopLevelExp GetDataByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x6015714")]
	[Address(RVA = "0x21BCCF4", Offset = "0x21BCCF4", VA = "0x21BCCF4")]
	public void GetLevelByExp(uint exp, out uint level1, out uint nextexp)
	{
	}
}
