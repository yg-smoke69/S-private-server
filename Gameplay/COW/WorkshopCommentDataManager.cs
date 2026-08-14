using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000272")]
public class WorkshopCommentDataManager : SingletonModule<WorkshopCommentDataManager>
{
	[Token(Token = "0x2000273")]
	private sealed class _003CGetWorkshopCommentDataById_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x21BE5BC", Offset = "0x21BE5BC", VA = "0x21BE5BC")]
		public _003CGetWorkshopCommentDataById_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x21BE740", Offset = "0x21BE740", VA = "0x21BE740")]
		internal bool _003C_003Em__0(WorkshopCommentConfigData e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x21BE778", Offset = "0x21BE778", VA = "0x21BE778")]
		internal bool _003C_003Em__1(WorkshopCommentConfigData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000EE2")]
	[FieldOffset(Offset = "0xC")]
	private List<WorkshopCommentConfigData> m_PositiveList;

	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x10")]
	private List<WorkshopCommentConfigData> m_NegativeList;

	[Token(Token = "0x4000EE4")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<WorkshopCommentConfigData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4000EE5")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<WorkshopCommentConfigData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x21BDE58", Offset = "0x21BDE58", VA = "0x21BDE58")]
	public WorkshopCommentDataManager()
	{
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x21BDF34", Offset = "0x21BDF34", VA = "0x21BDF34", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x21BE34C", Offset = "0x21BE34C", VA = "0x21BE34C")]
	public List<WorkshopCommentConfigData> GetPositiveCommentDataList()
	{
		return null;
	}

	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x21BE3A4", Offset = "0x21BE3A4", VA = "0x21BE3A4")]
	public List<WorkshopCommentConfigData> GetNegativeCommentDataList()
	{
		return null;
	}

	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x21BE3FC", Offset = "0x21BE3FC", VA = "0x21BE3FC")]
	public WorkshopCommentConfigData GetWorkshopCommentDataById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x21BE5C4", Offset = "0x21BE5C4", VA = "0x21BE5C4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x21BE6B0", Offset = "0x21BE6B0", VA = "0x21BE6B0")]
	private static int _003COnInit_003Em__0(WorkshopCommentConfigData a, WorkshopCommentConfigData b)
	{
		return default(int);
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x21BE6F8", Offset = "0x21BE6F8", VA = "0x21BE6F8")]
	private static int _003COnInit_003Em__1(WorkshopCommentConfigData a, WorkshopCommentConfigData b)
	{
		return default(int);
	}
}
