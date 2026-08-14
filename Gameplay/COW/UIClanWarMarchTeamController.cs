using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200255C")]
public class UIClanWarMarchTeamController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E75D")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarMarchTeamView m_View;

	[Token(Token = "0x400E75E")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIClanWarMarchMemberItemController> m_MemberUIList;

	[Token(Token = "0x400E75F")]
	[FieldOffset(Offset = "0x30")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E760")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_LastRefreshTime;

	[Token(Token = "0x400E761")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayCallID;

	[Token(Token = "0x600D9F2")]
	[Address(RVA = "0x28F73AC", Offset = "0x28F73AC", VA = "0x28F73AC")]
	public UIClanWarMarchTeamController()
	{
	}

	[Token(Token = "0x600D9F3")]
	[Address(RVA = "0x28F7430", Offset = "0x28F7430", VA = "0x28F7430", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D9F4")]
	[Address(RVA = "0x28F75A0", Offset = "0x28F75A0", VA = "0x28F75A0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D9F5")]
	[Address(RVA = "0x28F7634", Offset = "0x28F7634", VA = "0x28F7634")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D9F6")]
	[Address(RVA = "0x28F76D8", Offset = "0x28F76D8", VA = "0x28F76D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D9F7")]
	[Address(RVA = "0x28F8344", Offset = "0x28F8344", VA = "0x28F8344", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D9F8")]
	[Address(RVA = "0x28F7D98", Offset = "0x28F7D98", VA = "0x28F7D98")]
	private void InitView()
	{
	}

	[Token(Token = "0x600D9F9")]
	[Address(RVA = "0x28F8510", Offset = "0x28F8510", VA = "0x28F8510")]
	private void RefreshRecruitCD()
	{
	}

	[Token(Token = "0x600D9FA")]
	[Address(RVA = "0x28F877C", Offset = "0x28F877C", VA = "0x28F877C")]
	private bool CheckRecruitBtnCD()
	{
		return default(bool);
	}

	[Token(Token = "0x600D9FB")]
	[Address(RVA = "0x28F7524", Offset = "0x28F7524", VA = "0x28F7524")]
	private void RefreshView(bool canSendRequest = true)
	{
	}

	[Token(Token = "0x600D9FC")]
	[Address(RVA = "0x28F88C8", Offset = "0x28F88C8", VA = "0x28F88C8")]
	public void RefreshTeamList(bool canSendRequest = true)
	{
	}

	[Token(Token = "0x600D9FD")]
	[Address(RVA = "0x28F8FE4", Offset = "0x28F8FE4", VA = "0x28F8FE4")]
	private void RefreshOps()
	{
	}

	[Token(Token = "0x600D9FE")]
	[Address(RVA = "0x28FB054", Offset = "0x28FB054", VA = "0x28FB054")]
	private void ResetOps()
	{
	}

	[Token(Token = "0x600D9FF")]
	[Address(RVA = "0x28FB0D8", Offset = "0x28FB0D8", VA = "0x28FB0D8")]
	private void UpdateReadyStatus(object[] data)
	{
	}

	[Token(Token = "0x600DA00")]
	[Address(RVA = "0x28FB2B4", Offset = "0x28FB2B4", VA = "0x28FB2B4")]
	private void UpdateRefreshState(bool inCD = false)
	{
	}

	[Token(Token = "0x600DA01")]
	[Address(RVA = "0x28FB384", Offset = "0x28FB384", VA = "0x28FB384")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x600DA02")]
	[Address(RVA = "0x28FB5E0", Offset = "0x28FB5E0", VA = "0x28FB5E0")]
	private void OnLeaderboardBtnClick()
	{
	}

	[Token(Token = "0x600DA03")]
	[Address(RVA = "0x28FB77C", Offset = "0x28FB77C", VA = "0x28FB77C")]
	private void OnJoinBtnClick()
	{
	}

	[Token(Token = "0x600DA04")]
	[Address(RVA = "0x28FBBB0", Offset = "0x28FBBB0", VA = "0x28FBBB0")]
	private void OnLeaveBtnClick()
	{
	}

	[Token(Token = "0x600DA05")]
	[Address(RVA = "0x28FBEEC", Offset = "0x28FBEEC", VA = "0x28FBEEC")]
	private void OnInviteBtnClick()
	{
	}

	[Token(Token = "0x600DA06")]
	[Address(RVA = "0x28FBFFC", Offset = "0x28FBFFC", VA = "0x28FBFFC")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600DA07")]
	[Address(RVA = "0x28FC468", Offset = "0x28FC468", VA = "0x28FC468")]
	private void OnRecruitBtnClick()
	{
	}

	[Token(Token = "0x600DA08")]
	[Address(RVA = "0x28FC588", Offset = "0x28FC588", VA = "0x28FC588")]
	private void OnReadyBtnClick()
	{
	}

	[Token(Token = "0x600DA09")]
	[Address(RVA = "0x28FC600", Offset = "0x28FC600", VA = "0x28FC600")]
	private void OnStartBtnClick()
	{
	}

	[Token(Token = "0x600DA0A")]
	[Address(RVA = "0x28FCADC", Offset = "0x28FCADC", VA = "0x28FCADC")]
	private void _003CRefreshRecruitCD_003Em__0()
	{
	}

	[Token(Token = "0x600DA0B")]
	[Address(RVA = "0x28FCB80", Offset = "0x28FCB80", VA = "0x28FCB80")]
	private void _003CRefreshOps_003Em__1()
	{
	}

	[Token(Token = "0x600DA0C")]
	[Address(RVA = "0x28FCB84", Offset = "0x28FCB84", VA = "0x28FCB84")]
	private void _003CRefreshOps_003Em__2()
	{
	}

	[Token(Token = "0x600DA0D")]
	[Address(RVA = "0x28FCB88", Offset = "0x28FCB88", VA = "0x28FCB88")]
	private void _003COnLeaveBtnClick_003Em__3()
	{
	}

	[Token(Token = "0x600DA0E")]
	[Address(RVA = "0x28FCBB8", Offset = "0x28FCBB8", VA = "0x28FCBB8")]
	private void _003COnRefreshBtnClick_003Em__4()
	{
	}

	[Token(Token = "0x600DA0F")]
	[Address(RVA = "0x28FCBC0", Offset = "0x28FCBC0", VA = "0x28FCBC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DA10")]
	[Address(RVA = "0x28FCBC8", Offset = "0x28FCBC8", VA = "0x28FCBC8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
