using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002505")]
public class UIChannelItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400E5DF")]
	[FieldOffset(Offset = "0x38")]
	private UIChannelItemView m_View;

	[Token(Token = "0x400E5E0")]
	[FieldOffset(Offset = "0x3C")]
	private ChatChannelInfo m_Info;

	[Token(Token = "0x400E5E1")]
	[FieldOffset(Offset = "0x40")]
	private ETipsType m_TipsType;

	[Token(Token = "0x400E5E2")]
	[FieldOffset(Offset = "0x44")]
	private bool isSelect;

	[Token(Token = "0x400E5E3")]
	[FieldOffset(Offset = "0x0")]
	public static Color32 UnseletColor;

	[Token(Token = "0x400E5E4")]
	[FieldOffset(Offset = "0x4")]
	public static Color32 SelectColor;

	[Token(Token = "0x400E5E5")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<uint, string> m_StrKeyDic;

	[Token(Token = "0x600D68F")]
	[Address(RVA = "0x2629C24", Offset = "0x2629C24", VA = "0x2629C24")]
	public UIChannelItemController()
	{
	}

	[Token(Token = "0x600D690")]
	[Address(RVA = "0x2629C2C", Offset = "0x2629C2C", VA = "0x2629C2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D691")]
	[Address(RVA = "0x2629DC0", Offset = "0x2629DC0", VA = "0x2629DC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D692")]
	[Address(RVA = "0x2629ECC", Offset = "0x2629ECC", VA = "0x2629ECC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D693")]
	[Address(RVA = "0x2629F70", Offset = "0x2629F70", VA = "0x2629F70", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D694")]
	[Address(RVA = "0x262A3D8", Offset = "0x262A3D8", VA = "0x262A3D8")]
	public void RefreshUnreadTips()
	{
	}

	[Token(Token = "0x600D695")]
	[Address(RVA = "0x262A57C", Offset = "0x262A57C", VA = "0x262A57C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D696")]
	[Address(RVA = "0x262A91C", Offset = "0x262A91C", VA = "0x262A91C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600D697")]
	[Address(RVA = "0x262AA98", Offset = "0x262AA98", VA = "0x262AA98", Slot = "37")]
	private void COW_002EITipsDelegate_002EOnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600D699")]
	[Address(RVA = "0x262AEA4", Offset = "0x262AEA4", VA = "0x262AEA4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D69A")]
	[Address(RVA = "0x262AEAC", Offset = "0x262AEAC", VA = "0x262AEAC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D69B")]
	[Address(RVA = "0x262AEB4", Offset = "0x262AEB4", VA = "0x262AEB4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D69C")]
	[Address(RVA = "0x262AEBC", Offset = "0x262AEBC", VA = "0x262AEBC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
