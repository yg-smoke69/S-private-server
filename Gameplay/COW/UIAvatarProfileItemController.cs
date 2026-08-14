using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024C7")]
public class UIAvatarProfileItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400E409")]
	[FieldOffset(Offset = "0x38")]
	private uint m_AvatarID;

	[Token(Token = "0x400E40A")]
	[FieldOffset(Offset = "0x3C")]
	private string m_AwardDesc;

	[Token(Token = "0x400E40B")]
	[FieldOffset(Offset = "0x40")]
	private AvatarProfileDataOverrided m_ProfileInfo;

	[Token(Token = "0x400E40C")]
	[FieldOffset(Offset = "0x44")]
	private EProfileItemStatus m_Status;

	[Token(Token = "0x400E40D")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarProfileItemView m_View;

	[Token(Token = "0x400E40E")]
	[FieldOffset(Offset = "0x4C")]
	private UIAvatarSkillSlotController m_skillCtrl;

	[Token(Token = "0x400E40F")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_UnlockEffect;

	[Token(Token = "0x400E410")]
	[FieldOffset(Offset = "0x54")]
	private UIModelAvatarProfile m_ModelAvatarProfile;

	[Token(Token = "0x600D35B")]
	[Address(RVA = "0x2B71910", Offset = "0x2B71910", VA = "0x2B71910")]
	public UIAvatarProfileItemController()
	{
	}

	[Token(Token = "0x600D35C")]
	[Address(RVA = "0x2B71918", Offset = "0x2B71918", VA = "0x2B71918", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D35D")]
	[Address(RVA = "0x2B71C14", Offset = "0x2B71C14", VA = "0x2B71C14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D35E")]
	[Address(RVA = "0x2B71CB8", Offset = "0x2B71CB8", VA = "0x2B71CB8")]
	public void SetData(AvatarProfileDataOverrided data)
	{
	}

	[Token(Token = "0x600D35F")]
	[Address(RVA = "0x2B72E18", Offset = "0x2B72E18", VA = "0x2B72E18")]
	private void CheckEffect()
	{
	}

	[Token(Token = "0x600D360")]
	[Address(RVA = "0x2B7375C", Offset = "0x2B7375C", VA = "0x2B7375C")]
	private void OnUnlockClick()
	{
	}

	[Token(Token = "0x600D361")]
	[Address(RVA = "0x2B73C5C", Offset = "0x2B73C5C", VA = "0x2B73C5C")]
	private void OnAwardClick()
	{
	}

	[Token(Token = "0x600D362")]
	[Address(RVA = "0x2B73E6C", Offset = "0x2B73E6C", VA = "0x2B73E6C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D363")]
	[Address(RVA = "0x2B73F70", Offset = "0x2B73F70", VA = "0x2B73F70", Slot = "37")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D364")]
	[Address(RVA = "0x2B7403C", Offset = "0x2B7403C", VA = "0x2B7403C", Slot = "38")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D365")]
	[Address(RVA = "0x2B740D0", Offset = "0x2B740D0", VA = "0x2B740D0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D366")]
	[Address(RVA = "0x2B74158", Offset = "0x2B74158", VA = "0x2B74158")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D367")]
	[Address(RVA = "0x2B74160", Offset = "0x2B74160", VA = "0x2B74160")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
