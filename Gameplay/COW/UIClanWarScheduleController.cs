using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200256A")]
public class UIClanWarScheduleController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E793")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarScheduleView m_View;

	[Token(Token = "0x400E794")]
	[FieldOffset(Offset = "0x2C")]
	private UIClanWarMarchTeamController m_ClanWarMarchTeamCtrl;

	[Token(Token = "0x400E795")]
	[FieldOffset(Offset = "0x30")]
	private UIClanWarRankController m_ClanWarRankCtrl;

	[Token(Token = "0x400E796")]
	[FieldOffset(Offset = "0x34")]
	private UILobbyChatController m_ChatBtn;

	[Token(Token = "0x400E797")]
	[FieldOffset(Offset = "0x38")]
	private List<UISprite> m_ProgressBarList;

	[Token(Token = "0x400E798")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_TeamBoxPosList;

	[Token(Token = "0x400E799")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> m_ProgressEndList;

	[Token(Token = "0x400E79A")]
	[FieldOffset(Offset = "0x44")]
	private List<UIClanWarTeamBoxItemController> m_TeamBoxBtnList;

	[Token(Token = "0x400E79B")]
	[FieldOffset(Offset = "0x48")]
	private uint m_DelayCallID;

	[Token(Token = "0x400E79C")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x600DA7A")]
	[Address(RVA = "0x29087A0", Offset = "0x29087A0", VA = "0x29087A0")]
	public UIClanWarScheduleController()
	{
	}

	[Token(Token = "0x600DA7B")]
	[Address(RVA = "0x2908824", Offset = "0x2908824", VA = "0x2908824", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DA7C")]
	[Address(RVA = "0x2909B68", Offset = "0x2909B68", VA = "0x2909B68", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DA7D")]
	[Address(RVA = "0x2909C00", Offset = "0x2909C00", VA = "0x2909C00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA7E")]
	[Address(RVA = "0x2909CA4", Offset = "0x2909CA4", VA = "0x2909CA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA7F")]
	[Address(RVA = "0x290B054", Offset = "0x290B054", VA = "0x290B054", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DA80")]
	[Address(RVA = "0x290A038", Offset = "0x290A038", VA = "0x290A038")]
	private void InitView(EClan.ClanWarPhaseType stage = EClan.ClanWarPhaseType.ClanWarPhaseType_NONE)
	{
	}

	[Token(Token = "0x600DA81")]
	[Address(RVA = "0x290B6D4", Offset = "0x290B6D4", VA = "0x290B6D4")]
	public void RefreshBaseProfile()
	{
	}

	[Token(Token = "0x600DA82")]
	[Address(RVA = "0x2908908", Offset = "0x2908908", VA = "0x2908908")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600DA83")]
	[Address(RVA = "0x290B288", Offset = "0x290B288", VA = "0x290B288")]
	private void OnRefreshContainer(object[] data)
	{
	}

	[Token(Token = "0x600DA84")]
	[Address(RVA = "0x290B7D0", Offset = "0x290B7D0", VA = "0x290B7D0")]
	private void OnBoxButtonClick(object[] data)
	{
	}

	[Token(Token = "0x600DA85")]
	[Address(RVA = "0x290BB08", Offset = "0x290BB08", VA = "0x290BB08")]
	private void OnSingleBoxButtonClick()
	{
	}

	[Token(Token = "0x600DA86")]
	[Address(RVA = "0x290BF14", Offset = "0x290BF14", VA = "0x290BF14")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x600DA87")]
	[Address(RVA = "0x290C170", Offset = "0x290C170", VA = "0x290C170")]
	private void _003CInitView_003Em__0()
	{
	}

	[Token(Token = "0x600DA88")]
	[Address(RVA = "0x290C264", Offset = "0x290C264", VA = "0x290C264")]
	private void _003CRefreshView_003Em__1()
	{
	}

	[Token(Token = "0x600DA89")]
	[Address(RVA = "0x290C2F0", Offset = "0x290C2F0", VA = "0x290C2F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DA8A")]
	[Address(RVA = "0x290C2F8", Offset = "0x290C2F8", VA = "0x290C2F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
