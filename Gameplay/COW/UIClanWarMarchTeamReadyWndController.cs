using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200255F")]
public class UIClanWarMarchTeamReadyWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E767")]
	[FieldOffset(Offset = "0x48")]
	private UIClanWarMarchTeamReadyWndView m_View;

	[Token(Token = "0x400E768")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIClanWarMarchTeamReadyItemController> m_MemberUIList;

	[Token(Token = "0x400E769")]
	[FieldOffset(Offset = "0x50")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E76A")]
	[FieldOffset(Offset = "0x0")]
	private static OnFinished _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600DA1C")]
	[Address(RVA = "0x28FD774", Offset = "0x28FD774", VA = "0x28FD774")]
	public UIClanWarMarchTeamReadyWndController()
	{
	}

	[Token(Token = "0x600DA1D")]
	[Address(RVA = "0x28FD77C", Offset = "0x28FD77C", VA = "0x28FD77C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA1E")]
	[Address(RVA = "0x28FD820", Offset = "0x28FD820", VA = "0x28FD820", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DA1F")]
	[Address(RVA = "0x28FDB38", Offset = "0x28FDB38", VA = "0x28FDB38", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DA20")]
	[Address(RVA = "0x28FDBCC", Offset = "0x28FDBCC", VA = "0x28FDBCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA21")]
	[Address(RVA = "0x28FE37C", Offset = "0x28FE37C", VA = "0x28FE37C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DA22")]
	[Address(RVA = "0x28FE404", Offset = "0x28FE404", VA = "0x28FE404", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600DA23")]
	[Address(RVA = "0x28FE45C", Offset = "0x28FE45C", VA = "0x28FE45C")]
	private void ExitReadyStatus()
	{
	}

	[Token(Token = "0x600DA24")]
	[Address(RVA = "0x28FDE58", Offset = "0x28FDE58", VA = "0x28FDE58")]
	private void InitView()
	{
	}

	[Token(Token = "0x600DA25")]
	[Address(RVA = "0x28FE598", Offset = "0x28FE598", VA = "0x28FE598")]
	private void InitCdn()
	{
	}

	[Token(Token = "0x600DA26")]
	[Address(RVA = "0x28FD8F4", Offset = "0x28FD8F4", VA = "0x28FD8F4")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600DA27")]
	[Address(RVA = "0x28FE6E4", Offset = "0x28FE6E4", VA = "0x28FE6E4")]
	private void RefreshTeamList()
	{
	}

	[Token(Token = "0x600DA28")]
	[Address(RVA = "0x28FEB84", Offset = "0x28FEB84", VA = "0x28FEB84")]
	private void RefreshOps()
	{
	}

	[Token(Token = "0x600DA29")]
	[Address(RVA = "0x28FD95C", Offset = "0x28FD95C", VA = "0x28FD95C")]
	private void CheckStartMatchMaking()
	{
	}

	[Token(Token = "0x600DA2A")]
	[Address(RVA = "0x28FEEE0", Offset = "0x28FEEE0", VA = "0x28FEEE0")]
	private void OnReadyBtnClick()
	{
	}

	[Token(Token = "0x600DA2B")]
	[Address(RVA = "0x28FEF58", Offset = "0x28FEF58", VA = "0x28FEF58")]
	private void _003CInitView_003Em__0()
	{
	}

	[Token(Token = "0x600DA2C")]
	[Address(RVA = "0x28FEFA8", Offset = "0x28FEFA8", VA = "0x28FEFA8")]
	private static void _003CInitView_003Em__1()
	{
	}

	[Token(Token = "0x600DA2D")]
	[Address(RVA = "0x28FEFAC", Offset = "0x28FEFAC", VA = "0x28FEFAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DA2E")]
	[Address(RVA = "0x28FEFB4", Offset = "0x28FEFB4", VA = "0x28FEFB4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600DA2F")]
	[Address(RVA = "0x28FEFBC", Offset = "0x28FEFBC", VA = "0x28FEFBC")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
