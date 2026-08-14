using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200251A")]
public class UIChatWhisperContainerController : UIChatBaseContainerController, _Attribute, IConvertible
{
	[Token(Token = "0x200251B")]
	private sealed class _003COnSearchClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E62A")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x600D792")]
		[Address(RVA = "0x2081A4C", Offset = "0x2081A4C", VA = "0x2081A4C")]
		public _003COnSearchClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D793")]
		[Address(RVA = "0x2084FCC", Offset = "0x2084FCC", VA = "0x2084FCC")]
		internal bool _003C_003Em__0(ChatWhisperNameData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200251C")]
	private sealed class _003CConstructCacheList_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E62B")]
		[FieldOffset(Offset = "0x8")]
		internal List<ChatChannelInfo> list;

		[Token(Token = "0x400E62C")]
		[FieldOffset(Offset = "0xC")]
		internal UIChatWhisperContainerController _0024this;

		[Token(Token = "0x600D794")]
		[Address(RVA = "0x2084BBC", Offset = "0x2084BBC", VA = "0x2084BBC")]
		public _003CConstructCacheList_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600D795")]
		[Address(RVA = "0x2084DA8", Offset = "0x2084DA8", VA = "0x2084DA8")]
		internal int _003C_003Em__0(FriendAccountInfo x, FriendAccountInfo y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200251D")]
	private sealed class _003CConstructCacheList_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E62D")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400E62E")]
		[FieldOffset(Offset = "0xC")]
		internal _003CConstructCacheList_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x600D796")]
		[Address(RVA = "0x2084BC4", Offset = "0x2084BC4", VA = "0x2084BC4")]
		public _003CConstructCacheList_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600D797")]
		[Address(RVA = "0x2084EF4", Offset = "0x2084EF4", VA = "0x2084EF4")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E621")]
	[FieldOffset(Offset = "0x28")]
	private UIChatWhisperContainerView m_View;

	[Token(Token = "0x400E622")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelFriends m_FriendsModel;

	[Token(Token = "0x400E623")]
	[FieldOffset(Offset = "0x30")]
	private UIModelChat m_Chat;

	[Token(Token = "0x400E624")]
	[FieldOffset(Offset = "0x34")]
	private List<ChatWhisperNameData> m_CacheList;

	[Token(Token = "0x400E625")]
	[FieldOffset(Offset = "0x38")]
	private FriendAccountInfo curWhisperTo;

	[Token(Token = "0x400E626")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_LastRefreshTime;

	[Token(Token = "0x400E627")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HasSearch;

	[Token(Token = "0x400E628")]
	[FieldOffset(Offset = "0x49")]
	private bool m_InputNodeShow;

	[Token(Token = "0x400E629")]
	private const float NAMELIST_CLIP_OFFSET_Y = 90f;

	[Token(Token = "0x600D76D")]
	[Address(RVA = "0x207F760", Offset = "0x207F760", VA = "0x207F760")]
	public UIChatWhisperContainerController()
	{
	}

	[Token(Token = "0x600D76E")]
	[Address(RVA = "0x207F7F4", Offset = "0x207F7F4", VA = "0x207F7F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D76F")]
	[Address(RVA = "0x207F898", Offset = "0x207F898", VA = "0x207F898", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D770")]
	[Address(RVA = "0x20800DC", Offset = "0x20800DC", VA = "0x20800DC")]
	private void OnFriendBtnClick()
	{
	}

	[Token(Token = "0x600D771")]
	[Address(RVA = "0x20801C4", Offset = "0x20801C4", VA = "0x20801C4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D772")]
	[Address(RVA = "0x2080228", Offset = "0x2080228", VA = "0x2080228")]
	public void GoToWhisperChannel(ulong id, bool forceToFriendTab)
	{
	}

	[Token(Token = "0x600D773")]
	[Address(RVA = "0x20805F0", Offset = "0x20805F0", VA = "0x20805F0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D774")]
	[Address(RVA = "0x20807F4", Offset = "0x20807F4", VA = "0x20807F4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D775")]
	[Address(RVA = "0x2080878", Offset = "0x2080878", VA = "0x2080878")]
	private void OnSentGiftClick()
	{
	}

	[Token(Token = "0x600D776")]
	[Address(RVA = "0x2081370", Offset = "0x2081370", VA = "0x2081370")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x600D777")]
	[Address(RVA = "0x20815F0", Offset = "0x20815F0", VA = "0x20815F0")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x600D778")]
	[Address(RVA = "0x20816EC", Offset = "0x20816EC", VA = "0x20816EC")]
	private void OnSearchClick()
	{
	}

	[Token(Token = "0x600D779")]
	[Address(RVA = "0x2081A54", Offset = "0x2081A54", VA = "0x2081A54")]
	private void ResetInput()
	{
	}

	[Token(Token = "0x600D77A")]
	[Address(RVA = "0x2081E8C", Offset = "0x2081E8C", VA = "0x2081E8C")]
	private void OnRefreshClick()
	{
	}

	[Token(Token = "0x600D77B")]
	[Address(RVA = "0x2082220", Offset = "0x2082220", VA = "0x2082220")]
	private void OnRecentTabClick(UIToggleButton button)
	{
	}

	[Token(Token = "0x600D77C")]
	[Address(RVA = "0x2082464", Offset = "0x2082464", VA = "0x2082464")]
	private void RefreshRecentWhisperNameList()
	{
	}

	[Token(Token = "0x600D77D")]
	[Address(RVA = "0x2082E48", Offset = "0x2082E48", VA = "0x2082E48")]
	private void OnFriendTabClick(UIToggleButton button)
	{
	}

	[Token(Token = "0x600D77E")]
	[Address(RVA = "0x2081BEC", Offset = "0x2081BEC", VA = "0x2081BEC")]
	private void RefreshFriendNameList()
	{
	}

	[Token(Token = "0x600D77F")]
	[Address(RVA = "0x208308C", Offset = "0x208308C", VA = "0x208308C", Slot = "31")]
	public override GameObject GetContentNode()
	{
		return null;
	}

	[Token(Token = "0x600D780")]
	[Address(RVA = "0x20830FC", Offset = "0x20830FC", VA = "0x20830FC", Slot = "32")]
	public override GameObject GetEmptyNode()
	{
		return null;
	}

	[Token(Token = "0x600D781")]
	[Address(RVA = "0x208316C", Offset = "0x208316C", VA = "0x208316C", Slot = "33")]
	public override UIScrollView GetMessageList()
	{
		return null;
	}

	[Token(Token = "0x600D782")]
	[Address(RVA = "0x20831DC", Offset = "0x20831DC", VA = "0x20831DC", Slot = "35")]
	public override void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D783")]
	[Address(RVA = "0x2083A30", Offset = "0x2083A30", VA = "0x2083A30", Slot = "34")]
	public override void InitWidget(Transform parent)
	{
	}

	[Token(Token = "0x600D784")]
	[Address(RVA = "0x2084084", Offset = "0x2084084", VA = "0x2084084", Slot = "36")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D785")]
	[Address(RVA = "0x2084150", Offset = "0x2084150", VA = "0x2084150", Slot = "37")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D786")]
	[Address(RVA = "0x20841E4", Offset = "0x20841E4", VA = "0x20841E4", Slot = "38")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D787")]
	[Address(RVA = "0x20842DC", Offset = "0x20842DC", VA = "0x20842DC", Slot = "39")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D788")]
	[Address(RVA = "0x2084358", Offset = "0x2084358", VA = "0x2084358")]
	private void OnItemSelect(object[] param)
	{
	}

	[Token(Token = "0x600D789")]
	[Address(RVA = "0x20849BC", Offset = "0x20849BC", VA = "0x20849BC")]
	private void OnDeleteClick(object[] param)
	{
	}

	[Token(Token = "0x600D78A")]
	[Address(RVA = "0x2082684", Offset = "0x2082684", VA = "0x2082684")]
	private int ConstructCacheList(EWhipserContainerShowTab tab)
	{
		return default(int);
	}

	[Token(Token = "0x600D78B")]
	[Address(RVA = "0x2084BCC", Offset = "0x2084BCC", VA = "0x2084BCC")]
	private void OnBaseProfileUpdate(object[] data)
	{
	}

	[Token(Token = "0x600D78C")]
	[Address(RVA = "0x2084CB8", Offset = "0x2084CB8", VA = "0x2084CB8")]
	private bool _003CInitWidget_003Em__0(FriendAccountInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D78D")]
	[Address(RVA = "0x2084D80", Offset = "0x2084D80", VA = "0x2084D80")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D78E")]
	[Address(RVA = "0x2084D88", Offset = "0x2084D88", VA = "0x2084D88")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600D78F")]
	[Address(RVA = "0x2084D90", Offset = "0x2084D90", VA = "0x2084D90")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D790")]
	[Address(RVA = "0x2084D98", Offset = "0x2084D98", VA = "0x2084D98")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D791")]
	[Address(RVA = "0x2084DA0", Offset = "0x2084DA0", VA = "0x2084DA0")]
	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
