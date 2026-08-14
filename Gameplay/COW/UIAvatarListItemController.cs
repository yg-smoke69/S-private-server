using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024B9")]
public class UIAvatarListItemController : UIEasyListItemController
{
	[Token(Token = "0x400E3B4")]
	[FieldOffset(Offset = "0x38")]
	private uint m_AvatarID;

	[Token(Token = "0x400E3B5")]
	[FieldOffset(Offset = "0x3C")]
	private UIAvatarListItemView m_View;

	[Token(Token = "0x400E3B6")]
	[FieldOffset(Offset = "0x40")]
	private Transform[] m_SlotList;

	[Token(Token = "0x400E3B7")]
	[FieldOffset(Offset = "0x44")]
	private UIAvatarSkillSlotMono[] m_SlotCtrlList;

	[Token(Token = "0x400E3B8")]
	[FieldOffset(Offset = "0x48")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400E3B9")]
	[FieldOffset(Offset = "0x4C")]
	private AvatarProfile m_profile;

	[Token(Token = "0x400E3BA")]
	[FieldOffset(Offset = "0x50")]
	private int m_MaxLevel;

	[Token(Token = "0x400E3BB")]
	[FieldOffset(Offset = "0x54")]
	private bool m_CurrentSelect;

	[Token(Token = "0x400E3BC")]
	[FieldOffset(Offset = "0x58")]
	private uint m_DelayCallID;

	[Token(Token = "0x17001131")]
	public uint AvatarID
	{
		[Token(Token = "0x600D2A7")]
		[Address(RVA = "0x2A9DFD8", Offset = "0x2A9DFD8", VA = "0x2A9DFD8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600D2A6")]
	[Address(RVA = "0x2A9DFC8", Offset = "0x2A9DFC8", VA = "0x2A9DFC8")]
	public UIAvatarListItemController()
	{
	}

	[Token(Token = "0x600D2A8")]
	[Address(RVA = "0x2A9E030", Offset = "0x2A9E030", VA = "0x2A9E030", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D2A9")]
	[Address(RVA = "0x2A9E08C", Offset = "0x2A9E08C", VA = "0x2A9E08C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D2AA")]
	[Address(RVA = "0x2A9E130", Offset = "0x2A9E130", VA = "0x2A9E130", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D2AB")]
	[Address(RVA = "0x2A9E74C", Offset = "0x2A9E74C", VA = "0x2A9E74C")]
	public void SetGameObjectActive(GameObject go, bool active)
	{
	}

	[Token(Token = "0x600D2AC")]
	[Address(RVA = "0x2A9E810", Offset = "0x2A9E810", VA = "0x2A9E810", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D2AD")]
	[Address(RVA = "0x2A9EAF8", Offset = "0x2A9EAF8", VA = "0x2A9EAF8")]
	private void OnSetNewbieGuideState()
	{
	}

	[Token(Token = "0x600D2AE")]
	[Address(RVA = "0x2A9F094", Offset = "0x2A9F094", VA = "0x2A9F094")]
	public void GetGuideData(out Vector2Int guideSize, out List<EventDelegate> guideOnClick)
	{
	}

	[Token(Token = "0x600D2AF")]
	[Address(RVA = "0x2A9F250", Offset = "0x2A9F250", VA = "0x2A9F250", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D2B0")]
	[Address(RVA = "0x2AA0318", Offset = "0x2AA0318", VA = "0x2AA0318")]
	private void UpdateTips()
	{
	}

	[Token(Token = "0x600D2B1")]
	[Address(RVA = "0x2AA0C64", Offset = "0x2AA0C64", VA = "0x2AA0C64")]
	private void OnUpdateLoveInfo(object[] data)
	{
	}

	[Token(Token = "0x600D2B2")]
	[Address(RVA = "0x2AA0F94", Offset = "0x2AA0F94", VA = "0x2AA0F94")]
	private void OnUpdateDownloadInfo(object[] data)
	{
	}

	[Token(Token = "0x600D2B3")]
	[Address(RVA = "0x2A9FD40", Offset = "0x2A9FD40", VA = "0x2A9FD40")]
	private void OnUpdateAvatarListSelect(object[] data)
	{
	}

	[Token(Token = "0x600D2B4")]
	[Address(RVA = "0x2AA0FF0", Offset = "0x2AA0FF0", VA = "0x2AA0FF0")]
	private void OnUpdateRedTips(object[] data)
	{
	}

	[Token(Token = "0x600D2B5")]
	[Address(RVA = "0x2AA0578", Offset = "0x2AA0578", VA = "0x2AA0578")]
	private bool CheckHasTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D2B6")]
	[Address(RVA = "0x2AA0648", Offset = "0x2AA0648", VA = "0x2AA0648")]
	private bool CheckHasAwakenTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D2B7")]
	[Address(RVA = "0x2AA07DC", Offset = "0x2AA07DC", VA = "0x2AA07DC")]
	private bool CheckAvatarGuideTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D2B8")]
	[Address(RVA = "0x2AA0024", Offset = "0x2AA0024", VA = "0x2AA0024")]
	public void ShowIPTag()
	{
	}

	[Token(Token = "0x600D2B9")]
	[Address(RVA = "0x2AA1058", Offset = "0x2AA1058", VA = "0x2AA1058", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D2BA")]
	[Address(RVA = "0x2A9D9AC", Offset = "0x2A9D9AC", VA = "0x2A9D9AC")]
	public void SetGuide()
	{
	}

	[Token(Token = "0x600D2BB")]
	[Address(RVA = "0x2AA1694", Offset = "0x2AA1694", VA = "0x2AA1694")]
	private void SetAwakenIcon()
	{
	}

	[Token(Token = "0x600D2BC")]
	[Address(RVA = "0x2AA18C8", Offset = "0x2AA18C8", VA = "0x2AA18C8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600D2BD")]
	[Address(RVA = "0x2AA192C", Offset = "0x2AA192C", VA = "0x2AA192C")]
	private void _003COnUpdateLoveInfo_003Em__0()
	{
	}

	[Token(Token = "0x600D2BE")]
	[Address(RVA = "0x2AA1970", Offset = "0x2AA1970", VA = "0x2AA1970")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D2BF")]
	[Address(RVA = "0x2AA1978", Offset = "0x2AA1978", VA = "0x2AA1978")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D2C0")]
	[Address(RVA = "0x2AA1980", Offset = "0x2AA1980", VA = "0x2AA1980")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D2C1")]
	[Address(RVA = "0x2AA1988", Offset = "0x2AA1988", VA = "0x2AA1988")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D2C2")]
	[Address(RVA = "0x2AA1990", Offset = "0x2AA1990", VA = "0x2AA1990")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
