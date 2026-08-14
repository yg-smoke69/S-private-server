using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FB2")]
public class UIAvatarAwakenStoryReplayController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C6D6")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarAwakenStoryReplayView m_View;

	[Token(Token = "0x400C6D7")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400C6D8")]
	[FieldOffset(Offset = "0x30")]
	private RewardWndCfg m_PendingRewardCfg;

	[Token(Token = "0x400C6D9")]
	[FieldOffset(Offset = "0x34")]
	private List<UIPanel> m_ComicPosList;

	[Token(Token = "0x400C6DA")]
	[FieldOffset(Offset = "0x38")]
	private AvatarProfile m_CurrentShowAvatar;

	[Token(Token = "0x6009E62")]
	[Address(RVA = "0x1E850D0", Offset = "0x1E850D0", VA = "0x1E850D0")]
	public UIAvatarAwakenStoryReplayController()
	{
	}

	[Token(Token = "0x6009E63")]
	[Address(RVA = "0x1E85154", Offset = "0x1E85154", VA = "0x1E85154")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009E64")]
	[Address(RVA = "0x1E851F8", Offset = "0x1E851F8", VA = "0x1E851F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009E65")]
	[Address(RVA = "0x1E827A0", Offset = "0x1E827A0", VA = "0x1E827A0")]
	public void SetAvatar(uint curAvatarID)
	{
	}

	[Token(Token = "0x6009E66")]
	[Address(RVA = "0x1E858F8", Offset = "0x1E858F8", VA = "0x1E858F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009E67")]
	[Address(RVA = "0x1E85980", Offset = "0x1E85980", VA = "0x1E85980", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009E68")]
	[Address(RVA = "0x1E854D0", Offset = "0x1E854D0", VA = "0x1E854D0")]
	public void InitStoryList()
	{
	}

	[Token(Token = "0x6009E69")]
	[Address(RVA = "0x1E85B08", Offset = "0x1E85B08", VA = "0x1E85B08")]
	private int SortItem(AvatarAwakenComicData a, AvatarAwakenComicData b)
	{
		return default(int);
	}

	[Token(Token = "0x6009E6A")]
	[Address(RVA = "0x1E85BAC", Offset = "0x1E85BAC", VA = "0x1E85BAC", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009E6B")]
	[Address(RVA = "0x1E85C90", Offset = "0x1E85C90", VA = "0x1E85C90", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009E6C")]
	[Address(RVA = "0x1E85D24", Offset = "0x1E85D24", VA = "0x1E85D24")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009E6D")]
	[Address(RVA = "0x1E85D2C", Offset = "0x1E85D2C", VA = "0x1E85D2C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009E6E")]
	[Address(RVA = "0x1E85D34", Offset = "0x1E85D34", VA = "0x1E85D34")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
