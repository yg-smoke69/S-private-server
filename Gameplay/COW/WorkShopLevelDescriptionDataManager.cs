using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032DB")]
internal class WorkShopLevelDescriptionDataManager : SingletonModule<WorkShopLevelDescriptionDataManager>
{
	[Token(Token = "0x20032DC")]
	private sealed class _003CGetKeyByGameMode_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013595")]
		[FieldOffset(Offset = "0x8")]
		internal uint gameMode;

		[Token(Token = "0x601570A")]
		[Address(RVA = "0x21BBB84", Offset = "0x21BBB84", VA = "0x21BBB84")]
		public _003CGetKeyByGameMode_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601570B")]
		[Address(RVA = "0x21BBE20", Offset = "0x21BBE20", VA = "0x21BBE20")]
		internal bool _003C_003Em__0(WorkShopLevelDescriptionData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032DD")]
	private sealed class _003CGetCDNUrlByGameMode_003Ec__AnonStorey1
	{
		[Token(Token = "0x4013596")]
		[FieldOffset(Offset = "0x8")]
		internal uint gameMode;

		[Token(Token = "0x601570C")]
		[Address(RVA = "0x21BBD20", Offset = "0x21BBD20", VA = "0x21BBD20")]
		public _003CGetCDNUrlByGameMode_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601570D")]
		[Address(RVA = "0x21BBDE8", Offset = "0x21BBDE8", VA = "0x21BBDE8")]
		internal bool _003C_003Em__0(WorkShopLevelDescriptionData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4013594")]
	[FieldOffset(Offset = "0xC")]
	private List<WorkShopLevelDescriptionData> m_WorkShopLevelDescList;

	[Token(Token = "0x6015705")]
	[Address(RVA = "0x21BB83C", Offset = "0x21BB83C", VA = "0x21BB83C")]
	public WorkShopLevelDescriptionDataManager()
	{
	}

	[Token(Token = "0x6015706")]
	[Address(RVA = "0x21BB8CC", Offset = "0x21BB8CC", VA = "0x21BB8CC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015707")]
	[Address(RVA = "0x21BB9F0", Offset = "0x21BB9F0", VA = "0x21BB9F0")]
	public string GetKeyByGameMode(uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x6015708")]
	[Address(RVA = "0x21BBB8C", Offset = "0x21BBB8C", VA = "0x21BBB8C")]
	public string GetCDNUrlByGameMode(uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x6015709")]
	[Address(RVA = "0x21BBD28", Offset = "0x21BBD28", VA = "0x21BBD28", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
