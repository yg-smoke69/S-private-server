using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002515")]
public class UIChatSquadContainerController : UIChatBaseContainerController, _Attribute
{
	[Token(Token = "0x2002516")]
	private sealed class _003CGoToSquadChannel_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E615")]
		[FieldOffset(Offset = "0x8")]
		internal EChannel.ChannelType type;

		[Token(Token = "0x400E616")]
		[FieldOffset(Offset = "0x10")]
		internal ulong channelID;

		[Token(Token = "0x600D75D")]
		[Address(RVA = "0x207CDF4", Offset = "0x207CDF4", VA = "0x207CDF4")]
		public _003CGoToSquadChannel_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D75E")]
		[Address(RVA = "0x207CF88", Offset = "0x207CF88", VA = "0x207CF88")]
		internal bool _003C_003Em__0(ChatChannelInfo channelInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E611")]
	[FieldOffset(Offset = "0x28")]
	private UIChatSquadContainerView m_View;

	[Token(Token = "0x400E612")]
	[FieldOffset(Offset = "0x2C")]
	private List<ChatChannelInfo> m_ChannelList;

	[Token(Token = "0x400E613")]
	[FieldOffset(Offset = "0x30")]
	private UIModelChat m_ModelChat;

	[Token(Token = "0x400E614")]
	[FieldOffset(Offset = "0x34")]
	private ChatChannelInfo m_CurrenChannel;

	[Token(Token = "0x600D74B")]
	[Address(RVA = "0x207BEC4", Offset = "0x207BEC4", VA = "0x207BEC4")]
	public UIChatSquadContainerController()
	{
	}

	[Token(Token = "0x600D74C")]
	[Address(RVA = "0x207BF50", Offset = "0x207BF50", VA = "0x207BF50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D74D")]
	[Address(RVA = "0x207BFF8", Offset = "0x207BFF8", VA = "0x207BFF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D74E")]
	[Address(RVA = "0x207C534", Offset = "0x207C534", VA = "0x207C534", Slot = "34")]
	public override void InitWidget(Transform parent)
	{
	}

	[Token(Token = "0x600D74F")]
	[Address(RVA = "0x207C61C", Offset = "0x207C61C", VA = "0x207C61C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D750")]
	[Address(RVA = "0x207C204", Offset = "0x207C204", VA = "0x207C204")]
	private void InitChannelList()
	{
	}

	[Token(Token = "0x600D751")]
	[Address(RVA = "0x207C42C", Offset = "0x207C42C", VA = "0x207C42C")]
	private void CreateTab()
	{
	}

	[Token(Token = "0x600D752")]
	[Address(RVA = "0x207C750", Offset = "0x207C750", VA = "0x207C750")]
	private void OnSquadItemClick(object[] param)
	{
	}

	[Token(Token = "0x600D753")]
	[Address(RVA = "0x207C988", Offset = "0x207C988", VA = "0x207C988", Slot = "31")]
	public override GameObject GetContentNode()
	{
		return null;
	}

	[Token(Token = "0x600D754")]
	[Address(RVA = "0x207C9F8", Offset = "0x207C9F8", VA = "0x207C9F8", Slot = "32")]
	public override GameObject GetEmptyNode()
	{
		return null;
	}

	[Token(Token = "0x600D755")]
	[Address(RVA = "0x207CA68", Offset = "0x207CA68", VA = "0x207CA68", Slot = "33")]
	public override UIScrollView GetMessageList()
	{
		return null;
	}

	[Token(Token = "0x600D756")]
	[Address(RVA = "0x207CAD8", Offset = "0x207CAD8", VA = "0x207CAD8", Slot = "35")]
	public override void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D757")]
	[Address(RVA = "0x207CC2C", Offset = "0x207CC2C", VA = "0x207CC2C")]
	public void GoToSquadChannel(EChannel.ChannelType type, ulong channelID)
	{
	}

	[Token(Token = "0x600D758")]
	[Address(RVA = "0x207CDFC", Offset = "0x207CDFC", VA = "0x207CDFC", Slot = "36")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D759")]
	[Address(RVA = "0x207CEF4", Offset = "0x207CEF4", VA = "0x207CEF4", Slot = "37")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D75A")]
	[Address(RVA = "0x207CF70", Offset = "0x207CF70", VA = "0x207CF70")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D75B")]
	[Address(RVA = "0x207CF78", Offset = "0x207CF78", VA = "0x207CF78")]
	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}

	[Token(Token = "0x600D75C")]
	[Address(RVA = "0x207CF80", Offset = "0x207CF80", VA = "0x207CF80")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
