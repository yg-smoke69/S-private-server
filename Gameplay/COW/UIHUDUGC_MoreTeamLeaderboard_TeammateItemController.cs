using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200245B")]
internal class UIHUDUGC_MoreTeamLeaderboard_TeammateItemController : UIHUDUGC_BaseLeaderboard_TeammateItemController
{
	[Token(Token = "0x400E1DD")]
	[FieldOffset(Offset = "0x3C")]
	private UIHUDUGC_MoreTeamLeaderboard_TeammateItemView m_View;

	[Token(Token = "0x400E1DE")]
	[FieldOffset(Offset = "0x40")]
	private List<int> m_ScoreTypes;

	[Token(Token = "0x400E1DF")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<int, UILabel> m_LabelDict;

	[Token(Token = "0x600CEBB")]
	[Address(RVA = "0x2E193F0", Offset = "0x2E193F0", VA = "0x2E193F0")]
	public UIHUDUGC_MoreTeamLeaderboard_TeammateItemController()
	{
	}

	[Token(Token = "0x600CEBC")]
	[Address(RVA = "0x2E1947C", Offset = "0x2E1947C", VA = "0x2E1947C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CEBD")]
	[Address(RVA = "0x2E19520", Offset = "0x2E19520", VA = "0x2E19520", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CEBE")]
	[Address(RVA = "0x2E1847C", Offset = "0x2E1847C", VA = "0x2E1847C")]
	public void SetViewData(List<int> scoreTypes)
	{
	}

	[Token(Token = "0x600CEBF")]
	[Address(RVA = "0x2E195DC", Offset = "0x2E195DC", VA = "0x2E195DC", Slot = "38")]
	protected override void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	[Token(Token = "0x600CEC0")]
	[Address(RVA = "0x2E19B9C", Offset = "0x2E19B9C", VA = "0x2E19B9C", Slot = "37")]
	protected override void SetSelf(bool isSelf)
	{
	}

	[Token(Token = "0x600CEC1")]
	[Address(RVA = "0x2E19C7C", Offset = "0x2E19C7C", VA = "0x2E19C7C", Slot = "39")]
	public override void RefreshInfo(CBNPMCENMKE infoType)
	{
	}

	[Token(Token = "0x600CEC2")]
	[Address(RVA = "0x2E19DC8", Offset = "0x2E19DC8", VA = "0x2E19DC8", Slot = "40")]
	public override void RefreshAllInfo()
	{
	}

	[Token(Token = "0x600CEC3")]
	[Address(RVA = "0x2E1A014", Offset = "0x2E1A014", VA = "0x2E1A014")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CEC4")]
	[Address(RVA = "0x2E1A01C", Offset = "0x2E1A01C", VA = "0x2E1A01C")]
	public void _003C_003EiFixBaseProxy_ShowProfileInfo(BaseProfileInfo P0)
	{
	}

	[Token(Token = "0x600CEC5")]
	[Address(RVA = "0x2E1A024", Offset = "0x2E1A024", VA = "0x2E1A024")]
	public void _003C_003EiFixBaseProxy_SetSelf(bool P0)
	{
	}

	[Token(Token = "0x600CEC6")]
	[Address(RVA = "0x2E1A02C", Offset = "0x2E1A02C", VA = "0x2E1A02C")]
	public void _003C_003EiFixBaseProxy_RefreshInfo(CBNPMCENMKE P0)
	{
	}

	[Token(Token = "0x600CEC7")]
	[Address(RVA = "0x2E1A034", Offset = "0x2E1A034", VA = "0x2E1A034")]
	public void _003C_003EiFixBaseProxy_RefreshAllInfo()
	{
	}
}
