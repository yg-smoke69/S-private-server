using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x200250B")]
public class UIChatController : UIBaseChatController<UIChatMessageItemController>
{
	[Token(Token = "0x200250C")]
	private sealed class _003CGotoChannel_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E5F8")]
		[FieldOffset(Offset = "0x8")]
		internal EChannel.ChannelType type;

		[Token(Token = "0x600D6F8")]
		[Address(RVA = "0x2632A60", Offset = "0x2632A60", VA = "0x2632A60")]
		public _003CGotoChannel_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D6F9")]
		[Address(RVA = "0x2634680", Offset = "0x2634680", VA = "0x2634680")]
		internal bool _003C_003Em__0(ChatChannelInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E5ED")]
	[FieldOffset(Offset = "0xF0")]
	private UIChatView m_View;

	[Token(Token = "0x400E5EE")]
	[FieldOffset(Offset = "0xF4")]
	private List<ChatChannelInfo> m_ShowChannelList;

	[Token(Token = "0x400E5EF")]
	[FieldOffset(Offset = "0xF8")]
	private uint m_WorldCDCallID;

	[Token(Token = "0x400E5F0")]
	[FieldOffset(Offset = "0xFC")]
	private uint m_MentoringCDCallID;

	[Token(Token = "0x400E5F1")]
	[FieldOffset(Offset = "0x100")]
	private StringBuilder m_WorldCDText;

	[Token(Token = "0x400E5F2")]
	[FieldOffset(Offset = "0x104")]
	private Dictionary<int, UIChatBaseContainerController> m_ChannelType2Container;

	[Token(Token = "0x400E5F3")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 m_NewMessageNodeOrgPos;

	[Token(Token = "0x400E5F4")]
	private const int NEW_MESSAGE_NODE_OFFSET_Y = 90;

	[Token(Token = "0x400E5F5")]
	[FieldOffset(Offset = "0x118")]
	private ulong m_StartShowTime;

	[Token(Token = "0x400E5F6")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<ChatChannelInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E5F7")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<ChatChannelInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17001144")]
	public ulong StartShowTime
	{
		[Token(Token = "0x600D6CF")]
		[Address(RVA = "0x262E984", Offset = "0x262E984", VA = "0x262E984")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600D6D0")]
		[Address(RVA = "0x262E9E4", Offset = "0x262E9E4", VA = "0x262E9E4")]
		set
		{
		}
	}

	[Token(Token = "0x600D6CE")]
	[Address(RVA = "0x262E8B8", Offset = "0x262E8B8", VA = "0x262E8B8")]
	public UIChatController()
	{
	}

	[Token(Token = "0x600D6D1")]
	[Address(RVA = "0x262EA64", Offset = "0x262EA64", VA = "0x262EA64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D6D2")]
	[Address(RVA = "0x262EB08", Offset = "0x262EB08", VA = "0x262EB08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D6D3")]
	[Address(RVA = "0x262F204", Offset = "0x262F204", VA = "0x262F204", Slot = "36")]
	protected override void AfterInit()
	{
	}

	[Token(Token = "0x600D6D4")]
	[Address(RVA = "0x2630A08", Offset = "0x2630A08", VA = "0x2630A08", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D6D5")]
	[Address(RVA = "0x2630AE4", Offset = "0x2630AE4", VA = "0x2630AE4", Slot = "35")]
	protected override ChatChannelInfo GetCurShowChannel()
	{
		return null;
	}

	[Token(Token = "0x600D6D6")]
	[Address(RVA = "0x2630C1C", Offset = "0x2630C1C", VA = "0x2630C1C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D6D7")]
	[Address(RVA = "0x2630F74", Offset = "0x2630F74", VA = "0x2630F74", Slot = "43")]
	protected override void OnChatDataChanged(uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D6D8")]
	[Address(RVA = "0x2631138", Offset = "0x2631138", VA = "0x2631138")]
	private void RefreshChannelList()
	{
	}

	[Token(Token = "0x600D6D9")]
	[Address(RVA = "0x262F9AC", Offset = "0x262F9AC", VA = "0x262F9AC")]
	private void FilterChatChannel()
	{
	}

	[Token(Token = "0x600D6DA")]
	[Address(RVA = "0x2631E80", Offset = "0x2631E80", VA = "0x2631E80", Slot = "44")]
	protected override void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D6DB")]
	[Address(RVA = "0x2632514", Offset = "0x2632514", VA = "0x2632514")]
	private UIChatBaseContainerController GetOrCreateContainerCtrl(EChannel.ChannelType m_ChannelType)
	{
		return null;
	}

	[Token(Token = "0x600D6DC")]
	[Address(RVA = "0x2631680", Offset = "0x2631680", VA = "0x2631680")]
	public void GotoChannel(EChannel.ChannelType type, ulong roomid = 0uL, bool forceToFriendTab = true)
	{
	}

	[Token(Token = "0x600D6DD")]
	[Address(RVA = "0x2632A68", Offset = "0x2632A68", VA = "0x2632A68")]
	private void OnSwitchChannel(object[] data)
	{
	}

	[Token(Token = "0x600D6DE")]
	[Address(RVA = "0x2632950", Offset = "0x2632950", VA = "0x2632950")]
	private UIChatBaseContainerController GetContainerCtrl(EChannel.ChannelType m_ChannelType)
	{
		return null;
	}

	[Token(Token = "0x600D6DF")]
	[Address(RVA = "0x26337E4", Offset = "0x26337E4", VA = "0x26337E4")]
	public UIChatBaseContainerController GetCurContainerCtrl()
	{
		return null;
	}

	[Token(Token = "0x600D6E0")]
	[Address(RVA = "0x26338B0", Offset = "0x26338B0", VA = "0x26338B0")]
	private void OnBaseProfileUpdate(object[] data)
	{
	}

	[Token(Token = "0x600D6E1")]
	[Address(RVA = "0x2633964", Offset = "0x2633964", VA = "0x2633964", Slot = "46")]
	protected override uint GetChatInterestedPropID()
	{
		return default(uint);
	}

	[Token(Token = "0x600D6E2")]
	[Address(RVA = "0x2633A14", Offset = "0x2633A14", VA = "0x2633A14", Slot = "42")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D6E3")]
	[Address(RVA = "0x2633B38", Offset = "0x2633B38", VA = "0x2633B38", Slot = "45")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D6E4")]
	[Address(RVA = "0x2633C24", Offset = "0x2633C24", VA = "0x2633C24", Slot = "40")]
	protected override void AfterSendSuccess()
	{
	}

	[Token(Token = "0x600D6E5")]
	[Address(RVA = "0x2633FAC", Offset = "0x2633FAC", VA = "0x2633FAC")]
	private void OnSpeakerSend(object[] data)
	{
	}

	[Token(Token = "0x600D6E6")]
	[Address(RVA = "0x262FAF8", Offset = "0x262FAF8", VA = "0x262FAF8")]
	private void RefreshSpeakerNum()
	{
	}

	[Token(Token = "0x600D6E7")]
	[Address(RVA = "0x2634020", Offset = "0x2634020", VA = "0x2634020")]
	private void OnSpeakerClick()
	{
	}

	[Token(Token = "0x600D6E8")]
	[Address(RVA = "0x2632F18", Offset = "0x2632F18", VA = "0x2632F18")]
	private void RefreshDefaultInputValue()
	{
	}

	[Token(Token = "0x600D6E9")]
	[Address(RVA = "0x262FED0", Offset = "0x262FED0", VA = "0x262FED0")]
	private void ResetDefaultInputValue()
	{
	}

	[Token(Token = "0x600D6EA")]
	[Address(RVA = "0x2633380", Offset = "0x2633380", VA = "0x2633380")]
	private void RefreshMentoringInputValue()
	{
	}

	[Token(Token = "0x600D6EB")]
	[Address(RVA = "0x26345DC", Offset = "0x26345DC", VA = "0x26345DC")]
	private static bool _003CFilterChatChannel_003Em__0(ChatChannelInfo v)
	{
		return default(bool);
	}

	[Token(Token = "0x600D6EC")]
	[Address(RVA = "0x2634610", Offset = "0x2634610", VA = "0x2634610")]
	private static bool _003CGotoChannel_003Em__1(ChatChannelInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D6ED")]
	[Address(RVA = "0x2634640", Offset = "0x2634640", VA = "0x2634640")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D6EE")]
	[Address(RVA = "0x2634644", Offset = "0x2634644", VA = "0x2634644")]
	public void _003C_003EiFixBaseProxy_AfterInit()
	{
	}

	[Token(Token = "0x600D6EF")]
	[Address(RVA = "0x2634648", Offset = "0x2634648", VA = "0x2634648")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D6F0")]
	[Address(RVA = "0x263464C", Offset = "0x263464C", VA = "0x263464C")]
	public ChatChannelInfo _003C_003EiFixBaseProxy_GetCurShowChannel()
	{
		return null;
	}

	[Token(Token = "0x600D6F1")]
	[Address(RVA = "0x2634650", Offset = "0x2634650", VA = "0x2634650")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D6F2")]
	[Address(RVA = "0x2634654", Offset = "0x2634654", VA = "0x2634654")]
	public void _003C_003EiFixBaseProxy_OnChatDataChanged(uint P0, object[] P1)
	{
	}

	[Token(Token = "0x600D6F3")]
	[Address(RVA = "0x2634658", Offset = "0x2634658", VA = "0x2634658")]
	public void _003C_003EiFixBaseProxy_RefreshContentNode()
	{
	}

	[Token(Token = "0x600D6F4")]
	[Address(RVA = "0x263465C", Offset = "0x263465C", VA = "0x263465C")]
	public uint _003C_003EiFixBaseProxy_GetChatInterestedPropID()
	{
		return default(uint);
	}

	[Token(Token = "0x600D6F5")]
	[Address(RVA = "0x2634660", Offset = "0x2634660", VA = "0x2634660")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	[Token(Token = "0x600D6F6")]
	[Address(RVA = "0x2634678", Offset = "0x2634678", VA = "0x2634678")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x600D6F7")]
	[Address(RVA = "0x263467C", Offset = "0x263467C", VA = "0x263467C")]
	public void _003C_003EiFixBaseProxy_AfterSendSuccess()
	{
	}
}
