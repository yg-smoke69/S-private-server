using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002556")]
public class UIClanSettingController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E73D")]
	[FieldOffset(Offset = "0x48")]
	private UIClanSettingView m_View;

	[Token(Token = "0x400E73E")]
	[FieldOffset(Offset = "0x4C")]
	private EClan.EntryType m_CurAuditType;

	[Token(Token = "0x400E73F")]
	[FieldOffset(Offset = "0x50")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E740")]
	private const int SLOGAN_MIN_LENGTH = 3;

	[Token(Token = "0x400E741")]
	private const int SLOGAN_MAX_LENGTH = 20;

	[Token(Token = "0x400E742")]
	private const int ANNOUNCEMENT_MAX_LENGTH = 80;

	[Token(Token = "0x400E743")]
	[FieldOffset(Offset = "0x54")]
	private BoxCollider m_SloganCollider;

	[Token(Token = "0x400E744")]
	[FieldOffset(Offset = "0x58")]
	private BoxCollider m_NoticeCollider;

	[Token(Token = "0x400E745")]
	[FieldOffset(Offset = "0x5C")]
	private List<string> m_TagIDs;

	[Token(Token = "0x400E746")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_AreaIDs;

	[Token(Token = "0x400E747")]
	[FieldOffset(Offset = "0x64")]
	private ClanInfo m_ClanInfo;

	[Token(Token = "0x400E748")]
	[FieldOffset(Offset = "0x68")]
	private uint m_RankCondition;

	[Token(Token = "0x400E749")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_LevelCondition;

	[Token(Token = "0x600D9AA")]
	[Address(RVA = "0x2B4A034", Offset = "0x2B4A034", VA = "0x2B4A034")]
	public UIClanSettingController()
	{
	}

	[Token(Token = "0x600D9AB")]
	[Address(RVA = "0x2B4A03C", Offset = "0x2B4A03C", VA = "0x2B4A03C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D9AC")]
	[Address(RVA = "0x2B4A0E0", Offset = "0x2B4A0E0", VA = "0x2B4A0E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D9AD")]
	[Address(RVA = "0x2B4B864", Offset = "0x2B4B864", VA = "0x2B4B864", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D9AE")]
	[Address(RVA = "0x2B4B8F4", Offset = "0x2B4B8F4", VA = "0x2B4B8F4")]
	private void OnClickApprovalCondLevel()
	{
	}

	[Token(Token = "0x600D9AF")]
	[Address(RVA = "0x2B4BC00", Offset = "0x2B4BC00", VA = "0x2B4BC00")]
	private void OnClickApprovalCondRank()
	{
	}

	[Token(Token = "0x600D9B0")]
	[Address(RVA = "0x2B4BF0C", Offset = "0x2B4BF0C", VA = "0x2B4BF0C")]
	private void OnClickArea()
	{
	}

	[Token(Token = "0x600D9B1")]
	[Address(RVA = "0x2B4C194", Offset = "0x2B4C194", VA = "0x2B4C194")]
	private void OnClickTag()
	{
	}

	[Token(Token = "0x600D9B2")]
	[Address(RVA = "0x2B4C41C", Offset = "0x2B4C41C", VA = "0x2B4C41C")]
	private void OnChangeSlogan()
	{
	}

	[Token(Token = "0x600D9B3")]
	[Address(RVA = "0x2B4C4D0", Offset = "0x2B4C4D0", VA = "0x2B4C4D0")]
	private void OnSloganEditEnd()
	{
	}

	[Token(Token = "0x600D9B4")]
	[Address(RVA = "0x2B4C54C", Offset = "0x2B4C54C", VA = "0x2B4C54C")]
	private void OnChangeNotice()
	{
	}

	[Token(Token = "0x600D9B5")]
	[Address(RVA = "0x2B4C600", Offset = "0x2B4C600", VA = "0x2B4C600")]
	private void OnNoticeEditEnd()
	{
	}

	[Token(Token = "0x600D9B6")]
	[Address(RVA = "0x2B4C67C", Offset = "0x2B4C67C", VA = "0x2B4C67C")]
	private void OnClickSave()
	{
	}

	[Token(Token = "0x600D9B7")]
	[Address(RVA = "0x2B4D0F8", Offset = "0x2B4D0F8", VA = "0x2B4D0F8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D9B8")]
	[Address(RVA = "0x2B4B17C", Offset = "0x2B4B17C", VA = "0x2B4B17C")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600D9B9")]
	[Address(RVA = "0x2B4D57C", Offset = "0x2B4D57C", VA = "0x2B4D57C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D9BA")]
	[Address(RVA = "0x2B4D358", Offset = "0x2B4D358", VA = "0x2B4D358")]
	private void SetAuditPopupLabel(uint entryType)
	{
	}

	[Token(Token = "0x600D9BB")]
	[Address(RVA = "0x2B4D610", Offset = "0x2B4D610", VA = "0x2B4D610")]
	private void OnChangeAudit()
	{
	}

	[Token(Token = "0x600D9BC")]
	[Address(RVA = "0x2B4D798", Offset = "0x2B4D798", VA = "0x2B4D798")]
	private void _003COnClickApprovalCondLevel_003Em__0(List<string> ids)
	{
	}

	[Token(Token = "0x600D9BD")]
	[Address(RVA = "0x2B4D968", Offset = "0x2B4D968", VA = "0x2B4D968")]
	private void _003COnClickApprovalCondRank_003Em__1(List<string> ids)
	{
	}

	[Token(Token = "0x600D9BE")]
	[Address(RVA = "0x2B4DB38", Offset = "0x2B4DB38", VA = "0x2B4DB38")]
	private void _003COnClickArea_003Em__2(List<string> ids)
	{
	}

	[Token(Token = "0x600D9BF")]
	[Address(RVA = "0x2B4DC2C", Offset = "0x2B4DC2C", VA = "0x2B4DC2C")]
	private void _003COnClickTag_003Em__3(List<string> ids)
	{
	}

	[Token(Token = "0x600D9C0")]
	[Address(RVA = "0x2B4DD20", Offset = "0x2B4DD20", VA = "0x2B4DD20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D9C1")]
	[Address(RVA = "0x2B4DD28", Offset = "0x2B4DD28", VA = "0x2B4DD28")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
