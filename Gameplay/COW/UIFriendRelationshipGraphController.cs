using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002624")]
public class UIFriendRelationshipGraphController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400EB8B")]
	private const float SWAP_C_LAYER_FRIEND_CDTIME = 10f;

	[Token(Token = "0x400EB8C")]
	[FieldOffset(Offset = "0x48")]
	private UIFriendRelationshipGraphView m_View;

	[Token(Token = "0x400EB8D")]
	[FieldOffset(Offset = "0x4C")]
	private UIPopupWindowTopBtnController m_CloseBtn;

	[Token(Token = "0x400EB8E")]
	[FieldOffset(Offset = "0x50")]
	private UIFriendRelationshipGraphContainer m_SelfItemContainer;

	[Token(Token = "0x400EB8F")]
	[FieldOffset(Offset = "0x54")]
	private UIFriendRelationshipGraphItemController m_SelfItem;

	[Token(Token = "0x400EB90")]
	[FieldOffset(Offset = "0x58")]
	private UIFriendRelationshipGraphContainer m_CloseFriendContainer;

	[Token(Token = "0x400EB91")]
	[FieldOffset(Offset = "0x5C")]
	private UIFriendRelationshipGraphItemController m_CloseFriendItem;

	[Token(Token = "0x400EB92")]
	[FieldOffset(Offset = "0x60")]
	private List<UIFriendRelationshipGraphContainer> m_BLayerContainer;

	[Token(Token = "0x400EB93")]
	[FieldOffset(Offset = "0x64")]
	private List<UIFriendRelationshipGraphItemController> m_BLayerItems;

	[Token(Token = "0x400EB94")]
	[FieldOffset(Offset = "0x68")]
	private List<UIFriendRelationshipGraphContainer> m_CLayerContainer;

	[Token(Token = "0x400EB95")]
	[FieldOffset(Offset = "0x6C")]
	private List<UIFriendRelationshipGraphItemController> m_CLayerItems;

	[Token(Token = "0x400EB96")]
	[FieldOffset(Offset = "0x70")]
	private bool m_ShowCLayerAnim;

	[Token(Token = "0x400EB97")]
	[FieldOffset(Offset = "0x74")]
	private uint m_CLayerSwapAnimDelayCallID;

	[Token(Token = "0x400EB98")]
	[FieldOffset(Offset = "0x78")]
	private int m_CurrentCLayerFriendIndex;

	[Token(Token = "0x400EB99")]
	[FieldOffset(Offset = "0x7C")]
	private List<UIFriendRelationshipGraphContainer> m_DLayerContainer;

	[Token(Token = "0x400EB9A")]
	[FieldOffset(Offset = "0x80")]
	private List<UIFriendRelationshipGraphItemController> m_DLayerItems;

	[Token(Token = "0x400EB9B")]
	[FieldOffset(Offset = "0x84")]
	private UIModelFriends m_ModelFriend;

	[Token(Token = "0x400EB9C")]
	[FieldOffset(Offset = "0x88")]
	private UIModelRelationShip m_ModelRelationShip;

	[Token(Token = "0x400EB9D")]
	[FieldOffset(Offset = "0x8C")]
	private FriendAccountInfo m_CloseFriendInfo;

	[Token(Token = "0x400EB9E")]
	[FieldOffset(Offset = "0x90")]
	private List<FriendAccountInfo> m_GameFriendList;

	[Token(Token = "0x400EB9F")]
	[FieldOffset(Offset = "0x94")]
	private List<FriendAccountInfo> m_SearchFriendList;

	[Token(Token = "0x17001160")]
	private List<UIFriendRelationshipGraphContainer> BLayerContainer
	{
		[Token(Token = "0x600E234")]
		[Address(RVA = "0x2506934", Offset = "0x2506934", VA = "0x2506934")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001161")]
	private List<UIFriendRelationshipGraphItemController> BLayerItems
	{
		[Token(Token = "0x600E235")]
		[Address(RVA = "0x2506A0C", Offset = "0x2506A0C", VA = "0x2506A0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001162")]
	public int BLayerItemNum
	{
		[Token(Token = "0x600E236")]
		[Address(RVA = "0x2506AE4", Offset = "0x2506AE4", VA = "0x2506AE4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001163")]
	private List<UIFriendRelationshipGraphContainer> CLayerContainer
	{
		[Token(Token = "0x600E237")]
		[Address(RVA = "0x2506BAC", Offset = "0x2506BAC", VA = "0x2506BAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001164")]
	private List<UIFriendRelationshipGraphItemController> CLayerItems
	{
		[Token(Token = "0x600E238")]
		[Address(RVA = "0x2506C84", Offset = "0x2506C84", VA = "0x2506C84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001165")]
	public int CLayerItemNum
	{
		[Token(Token = "0x600E239")]
		[Address(RVA = "0x2506D5C", Offset = "0x2506D5C", VA = "0x2506D5C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001166")]
	private bool ShowCLayerAnim
	{
		[Token(Token = "0x600E23A")]
		[Address(RVA = "0x2506E24", Offset = "0x2506E24", VA = "0x2506E24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001167")]
	private uint CLayerSwapAnimDelayCallID
	{
		[Token(Token = "0x600E23B")]
		[Address(RVA = "0x2506E7C", Offset = "0x2506E7C", VA = "0x2506E7C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001168")]
	private int CurrentCLayerFriendIndex
	{
		[Token(Token = "0x600E23C")]
		[Address(RVA = "0x2506ED4", Offset = "0x2506ED4", VA = "0x2506ED4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001169")]
	private List<UIFriendRelationshipGraphContainer> DLayerContainer
	{
		[Token(Token = "0x600E23D")]
		[Address(RVA = "0x2506F2C", Offset = "0x2506F2C", VA = "0x2506F2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700116A")]
	private List<UIFriendRelationshipGraphItemController> DLayerItems
	{
		[Token(Token = "0x600E23E")]
		[Address(RVA = "0x2507004", Offset = "0x2507004", VA = "0x2507004")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700116B")]
	private FriendAccountInfo CloseFriendInfo
	{
		[Token(Token = "0x600E23F")]
		[Address(RVA = "0x25070DC", Offset = "0x25070DC", VA = "0x25070DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700116C")]
	private List<FriendAccountInfo> GameFriendList
	{
		[Token(Token = "0x600E240")]
		[Address(RVA = "0x2507134", Offset = "0x2507134", VA = "0x2507134")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700116D")]
	private List<FriendAccountInfo> SearchFriendList
	{
		[Token(Token = "0x600E241")]
		[Address(RVA = "0x250720C", Offset = "0x250720C", VA = "0x250720C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600E232")]
	[Address(RVA = "0x2506880", Offset = "0x2506880", VA = "0x2506880")]
	public UIFriendRelationshipGraphController()
	{
	}

	[Token(Token = "0x600E233")]
	[Address(RVA = "0x2506890", Offset = "0x2506890", VA = "0x2506890")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E242")]
	[Address(RVA = "0x25072E4", Offset = "0x25072E4", VA = "0x25072E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E243")]
	[Address(RVA = "0x2507B90", Offset = "0x2507B90", VA = "0x2507B90", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600E244")]
	[Address(RVA = "0x250A6BC", Offset = "0x250A6BC", VA = "0x250A6BC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E245")]
	[Address(RVA = "0x250A864", Offset = "0x250A864", VA = "0x250A864", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E246")]
	[Address(RVA = "0x250AADC", Offset = "0x250AADC", VA = "0x250AADC", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600E247")]
	[Address(RVA = "0x250AC60", Offset = "0x250AC60", VA = "0x250AC60", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600E248")]
	[Address(RVA = "0x250ADF8", Offset = "0x250ADF8", VA = "0x250ADF8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E249")]
	[Address(RVA = "0x250B14C", Offset = "0x250B14C", VA = "0x250B14C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E24A")]
	[Address(RVA = "0x250B204", Offset = "0x250B204", VA = "0x250B204")]
	private void FillBLayerData()
	{
	}

	[Token(Token = "0x600E24B")]
	[Address(RVA = "0x250BA70", Offset = "0x250BA70", VA = "0x250BA70")]
	private void FillCLayerData()
	{
	}

	[Token(Token = "0x600E24C")]
	[Address(RVA = "0x250C0B8", Offset = "0x250C0B8", VA = "0x250C0B8")]
	private void FillDLayerData()
	{
	}

	[Token(Token = "0x600E24D")]
	[Address(RVA = "0x250A590", Offset = "0x250A590", VA = "0x250A590")]
	private void RefreshSearchFriendList()
	{
	}

	[Token(Token = "0x600E24E")]
	[Address(RVA = "0x2509C84", Offset = "0x2509C84", VA = "0x2509C84")]
	private void RefreshRelationshipInfo()
	{
	}

	[Token(Token = "0x600E24F")]
	[Address(RVA = "0x2509FA8", Offset = "0x2509FA8", VA = "0x2509FA8")]
	private void RefreshGameFriendList()
	{
	}

	[Token(Token = "0x600E250")]
	[Address(RVA = "0x250C830", Offset = "0x250C830", VA = "0x250C830")]
	private void OnLeaveBtnClick()
	{
	}

	[Token(Token = "0x600E251")]
	[Address(RVA = "0x250C894", Offset = "0x250C894", VA = "0x250C894")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x600E252")]
	[Address(RVA = "0x250C9EC", Offset = "0x250C9EC", VA = "0x250C9EC")]
	private int SortGameFriend(FriendAccountInfo xFriend, FriendAccountInfo yFriend)
	{
		return default(int);
	}

	[Token(Token = "0x600E253")]
	[Address(RVA = "0x250CB58", Offset = "0x250CB58", VA = "0x250CB58")]
	private void OnHandleDetailInfoClick()
	{
	}

	[Token(Token = "0x600E254")]
	[Address(RVA = "0x250CE68", Offset = "0x250CE68", VA = "0x250CE68")]
	private void OnHandleOpenBriefBox(object[] data)
	{
	}

	[Token(Token = "0x600E255")]
	[Address(RVA = "0x250CF80", Offset = "0x250CF80", VA = "0x250CF80")]
	private void OnHandleCloseBriefBox(object[] data)
	{
	}

	[Token(Token = "0x600E256")]
	[Address(RVA = "0x250AF4C", Offset = "0x250AF4C", VA = "0x250AF4C")]
	private void RefreshAddFriendState()
	{
	}

	[Token(Token = "0x600E257")]
	[Address(RVA = "0x250D24C", Offset = "0x250D24C", VA = "0x250D24C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E258")]
	[Address(RVA = "0x250D254", Offset = "0x250D254", VA = "0x250D254")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600E259")]
	[Address(RVA = "0x250D25C", Offset = "0x250D25C", VA = "0x250D25C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E25A")]
	[Address(RVA = "0x250D264", Offset = "0x250D264", VA = "0x250D264")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E25B")]
	[Address(RVA = "0x250D26C", Offset = "0x250D26C", VA = "0x250D26C")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600E25C")]
	[Address(RVA = "0x250D274", Offset = "0x250D274", VA = "0x250D274")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
