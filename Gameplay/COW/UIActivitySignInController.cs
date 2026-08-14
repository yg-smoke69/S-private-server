using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F77")]
public class UIActivitySignInController : UIActivityBaseController, _Attribute
{
	[Token(Token = "0x400C596")]
	[FieldOffset(Offset = "0x28")]
	private UIActivitySignInView m_View;

	[Token(Token = "0x400C597")]
	private const int MaxItemPerLine = 6;

	[Token(Token = "0x400C598")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIAnnouncementRewardItemController> m_ItemList;

	[Token(Token = "0x400C599")]
	[FieldOffset(Offset = "0x30")]
	private int m_lastSignedIndex;

	[Token(Token = "0x400C59A")]
	[FieldOffset(Offset = "0x34")]
	private Transform[] m_ItemContainerList;

	[Token(Token = "0x400C59B")]
	[FieldOffset(Offset = "0x38")]
	private UITaskController m_ParentCtrl;

	[Token(Token = "0x6009C32")]
	[Address(RVA = "0x1F1D9B4", Offset = "0x1F1D9B4", VA = "0x1F1D9B4")]
	public UIActivitySignInController()
	{
	}

	[Token(Token = "0x6009C33")]
	[Address(RVA = "0x1F1DA48", Offset = "0x1F1DA48", VA = "0x1F1DA48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009C34")]
	[Address(RVA = "0x1F1DAEC", Offset = "0x1F1DAEC", VA = "0x1F1DAEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009C35")]
	[Address(RVA = "0x1F1E1E8", Offset = "0x1F1E1E8", VA = "0x1F1E1E8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009C36")]
	[Address(RVA = "0x1F1E460", Offset = "0x1F1E460", VA = "0x1F1E460", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009C37")]
	[Address(RVA = "0x1F1E590", Offset = "0x1F1E590", VA = "0x1F1E590")]
	private void ClearItem()
	{
	}

	[Token(Token = "0x6009C38")]
	[Address(RVA = "0x1F1E760", Offset = "0x1F1E760", VA = "0x1F1E760")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x6009C39")]
	[Address(RVA = "0x1F1EAEC", Offset = "0x1F1EAEC", VA = "0x1F1EAEC")]
	private void RepositionItem()
	{
	}

	[Token(Token = "0x6009C3A")]
	[Address(RVA = "0x1F1ED54", Offset = "0x1F1ED54", VA = "0x1F1ED54")]
	private void ScrollToLastSignedLine()
	{
	}

	[Token(Token = "0x6009C3B")]
	[Address(RVA = "0x1F1F1D0", Offset = "0x1F1F1D0", VA = "0x1F1F1D0")]
	private void RefreshSignDesc()
	{
	}

	[Token(Token = "0x6009C3C")]
	[Address(RVA = "0x1F1F680", Offset = "0x1F1F680", VA = "0x1F1F680", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009C3D")]
	[Address(RVA = "0x1F1F748", Offset = "0x1F1F748", VA = "0x1F1F748")]
	private void AutoSignIn()
	{
	}

	[Token(Token = "0x6009C3E")]
	[Address(RVA = "0x1F1FA84", Offset = "0x1F1FA84", VA = "0x1F1FA84")]
	private void OnMembershipSignInBtnClick()
	{
	}

	[Token(Token = "0x6009C3F")]
	[Address(RVA = "0x1F1FCEC", Offset = "0x1F1FCEC", VA = "0x1F1FCEC", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009C40")]
	[Address(RVA = "0x1F1FD80", Offset = "0x1F1FD80", VA = "0x1F1FD80")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009C41")]
	[Address(RVA = "0x1F1FD88", Offset = "0x1F1FD88", VA = "0x1F1FD88")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009C42")]
	[Address(RVA = "0x1F1FD90", Offset = "0x1F1FD90", VA = "0x1F1FD90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
