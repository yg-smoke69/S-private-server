using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200208B")]
public class UICupMatchTeamMemberItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400CC00")]
	[FieldOffset(Offset = "0x0")]
	private static Color OnlineColor;

	[Token(Token = "0x400CC01")]
	[FieldOffset(Offset = "0x10")]
	private static Color OfflineColor;

	[Token(Token = "0x400CC02")]
	[FieldOffset(Offset = "0x38")]
	private UICupMatchTeamMemberItemView m_View;

	[Token(Token = "0x400CC03")]
	[FieldOffset(Offset = "0x3C")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400CC04")]
	[FieldOffset(Offset = "0x40")]
	private UIModelCupMatch.AccountInfoBasicWithCupInfo m_TeamMemberData;

	[Token(Token = "0x400CC05")]
	[FieldOffset(Offset = "0x44")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CC06")]
	[FieldOffset(Offset = "0x48")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CC07")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsSelf;

	[Token(Token = "0x400CC08")]
	[FieldOffset(Offset = "0x4D")]
	private bool _003CShowPresence_003Ek__BackingField;

	[Token(Token = "0x400CC09")]
	[FieldOffset(Offset = "0x4E")]
	private bool _003CShowPopupMenu_003Ek__BackingField;

	[Token(Token = "0x17000FDB")]
	public bool ShowPresence
	{
		[Token(Token = "0x600A76A")]
		[Address(RVA = "0x11DC188", Offset = "0x11DC188", VA = "0x11DC188")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A76B")]
		[Address(RVA = "0x11DC190", Offset = "0x11DC190", VA = "0x11DC190")]
		set
		{
		}
	}

	[Token(Token = "0x17000FDC")]
	public bool ShowPopupMenu
	{
		[Token(Token = "0x600A76C")]
		[Address(RVA = "0x11DC198", Offset = "0x11DC198", VA = "0x11DC198")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A76D")]
		[Address(RVA = "0x11DC1A0", Offset = "0x11DC1A0", VA = "0x11DC1A0")]
		set
		{
		}
	}

	[Token(Token = "0x600A769")]
	[Address(RVA = "0x11DC180", Offset = "0x11DC180", VA = "0x11DC180")]
	public UICupMatchTeamMemberItemController()
	{
	}

	[Token(Token = "0x600A76E")]
	[Address(RVA = "0x11DC1A8", Offset = "0x11DC1A8", VA = "0x11DC1A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A76F")]
	[Address(RVA = "0x11DC250", Offset = "0x11DC250", VA = "0x11DC250", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A770")]
	[Address(RVA = "0x11DC5F4", Offset = "0x11DC5F4", VA = "0x11DC5F4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A771")]
	[Address(RVA = "0x11DC67C", Offset = "0x11DC67C", VA = "0x11DC67C")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x600A772")]
	[Address(RVA = "0x11DC9F4", Offset = "0x11DC9F4", VA = "0x11DC9F4")]
	private void OnTicketBtnClick()
	{
	}

	[Token(Token = "0x600A773")]
	[Address(RVA = "0x11DCE2C", Offset = "0x11DCE2C", VA = "0x11DCE2C")]
	private void OnTierBtnClick()
	{
	}

	[Token(Token = "0x600A774")]
	[Address(RVA = "0x11DD074", Offset = "0x11DD074", VA = "0x11DD074", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A775")]
	[Address(RVA = "0x11DD9F8", Offset = "0x11DD9F8", VA = "0x11DD9F8")]
	public void SetCupMatchKey(int key)
	{
	}

	[Token(Token = "0x600A776")]
	[Address(RVA = "0x11DD8B8", Offset = "0x11DD8B8", VA = "0x11DD8B8")]
	private void RefreshTicketState()
	{
	}

	[Token(Token = "0x600A777")]
	[Address(RVA = "0x11DDA58", Offset = "0x11DDA58", VA = "0x11DDA58")]
	private void RefreshSelfTicketState()
	{
	}

	[Token(Token = "0x600A778")]
	[Address(RVA = "0x11DDE64", Offset = "0x11DDE64", VA = "0x11DDE64")]
	private void RefreshTeammateTicketState()
	{
	}

	[Token(Token = "0x600A779")]
	[Address(RVA = "0x11DD57C", Offset = "0x11DD57C", VA = "0x11DD57C")]
	private void UpdateOnlineStateView()
	{
	}

	[Token(Token = "0x600A77A")]
	[Address(RVA = "0x11DE124", Offset = "0x11DE124", VA = "0x11DE124", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A77B")]
	[Address(RVA = "0x11DE2FC", Offset = "0x11DE2FC", VA = "0x11DE2FC", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A77D")]
	[Address(RVA = "0x11DE444", Offset = "0x11DE444", VA = "0x11DE444")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A77E")]
	[Address(RVA = "0x11DE44C", Offset = "0x11DE44C", VA = "0x11DE44C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
