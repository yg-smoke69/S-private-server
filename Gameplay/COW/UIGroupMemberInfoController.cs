using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x20026B7")]
internal class UIGroupMemberInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x20026B8")]
	public delegate void InviteClickCallBack(int member_idx, ulong account_id);

	[Token(Token = "0x400EEDF")]
	[FieldOffset(Offset = "0x28")]
	private int MemberIndex;

	[Token(Token = "0x400EEE0")]
	[FieldOffset(Offset = "0x2C")]
	private GroupMemberInfo m_MemInfo;

	[Token(Token = "0x400EEE1")]
	[FieldOffset(Offset = "0x30")]
	private UIGroupMemberInfoView m_View;

	[Token(Token = "0x400EEE2")]
	[FieldOffset(Offset = "0x34")]
	private UIBriefProfileInfoController m_CallSign;

	[Token(Token = "0x400EEE3")]
	[FieldOffset(Offset = "0x38")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400EEE4")]
	[FieldOffset(Offset = "0x3C")]
	private float m_FadeIconTime;

	[Token(Token = "0x400EEE5")]
	[FieldOffset(Offset = "0x40")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x400EEE6")]
	[FieldOffset(Offset = "0x44")]
	private float m_NextChangeChatBubbleTime;

	[Token(Token = "0x400EEE7")]
	[FieldOffset(Offset = "0x48")]
	private float m_NextBubbleAnimTime;

	[Token(Token = "0x400EEE8")]
	private const float CHAT_BUBBLE_CDTIME = 3f;

	[Token(Token = "0x400EEE9")]
	private const float CHAT_BUBBLE_END_ANIM = 2.8f;

	[Token(Token = "0x400EEEA")]
	private const int ChatBubbleWidth = 172;

	[Token(Token = "0x400EEEB")]
	private const int ChatBubbleShortWidth = 52;

	[Token(Token = "0x400EEEC")]
	[FieldOffset(Offset = "0x4C")]
	private ChatStickerData m_StickerData;

	[Token(Token = "0x400EEED")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsMute;

	[Token(Token = "0x400EEEE")]
	[FieldOffset(Offset = "0x54")]
	private InviteClickCallBack m_CallBack;

	[Token(Token = "0x1700119E")]
	public bool IsMute
	{
		[Token(Token = "0x600E98E")]
		[Address(RVA = "0x1D01D08", Offset = "0x1D01D08", VA = "0x1D01D08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600E98F")]
		[Address(RVA = "0x1D01D60", Offset = "0x1D01D60", VA = "0x1D01D60")]
		set
		{
		}
	}

	[Token(Token = "0x600E98D")]
	[Address(RVA = "0x1D01C7C", Offset = "0x1D01C7C", VA = "0x1D01C7C")]
	public UIGroupMemberInfoController()
	{
	}

	[Token(Token = "0x600E990")]
	[Address(RVA = "0x1D01DC0", Offset = "0x1D01DC0", VA = "0x1D01DC0")]
	public GroupMemberInfo GetMemberInfo()
	{
		return null;
	}

	[Token(Token = "0x600E991")]
	[Address(RVA = "0x1D01E18", Offset = "0x1D01E18", VA = "0x1D01E18")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E992")]
	[Address(RVA = "0x1D01EBC", Offset = "0x1D01EBC", VA = "0x1D01EBC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E993")]
	[Address(RVA = "0x1D02784", Offset = "0x1D02784", VA = "0x1D02784")]
	private void Update()
	{
	}

	[Token(Token = "0x600E994")]
	[Address(RVA = "0x1D0292C", Offset = "0x1D0292C", VA = "0x1D0292C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E995")]
	[Address(RVA = "0x1D02A84", Offset = "0x1D02A84", VA = "0x1D02A84")]
	public void SetCallSignData(GroupMemberInfo memInfo)
	{
	}

	[Token(Token = "0x600E996")]
	[Address(RVA = "0x1D02BA0", Offset = "0x1D02BA0", VA = "0x1D02BA0")]
	public void SetUIData(GroupMemberInfo memInfo, bool leader, int idx = 0)
	{
	}

	[Token(Token = "0x600E997")]
	[Address(RVA = "0x1D03DB0", Offset = "0x1D03DB0", VA = "0x1D03DB0")]
	private void OnInteractMuteStateChange(object[] data)
	{
	}

	[Token(Token = "0x600E998")]
	[Address(RVA = "0x1D04058", Offset = "0x1D04058", VA = "0x1D04058")]
	public void SetMute(bool isMute)
	{
	}

	[Token(Token = "0x600E999")]
	[Address(RVA = "0x1D03FAC", Offset = "0x1D03FAC", VA = "0x1D03FAC")]
	private void RefreshView(bool isMute, bool isInit = false)
	{
	}

	[Token(Token = "0x600E99A")]
	[Address(RVA = "0x1D03CC0", Offset = "0x1D03CC0", VA = "0x1D03CC0")]
	public void SetVoiceVisible(bool flag)
	{
	}

	[Token(Token = "0x600E99B")]
	[Address(RVA = "0x1D03BA8", Offset = "0x1D03BA8", VA = "0x1D03BA8")]
	public void SetMuteVisible(bool flag)
	{
	}

	[Token(Token = "0x600E99C")]
	[Address(RVA = "0x1D041A8", Offset = "0x1D041A8", VA = "0x1D041A8")]
	public void RefreshProfile()
	{
	}

	[Token(Token = "0x600E99D")]
	[Address(RVA = "0x1D042A4", Offset = "0x1D042A4", VA = "0x1D042A4")]
	private void OnChannelResume(object[] data)
	{
	}

	[Token(Token = "0x600E99E")]
	[Address(RVA = "0x1D043FC", Offset = "0x1D043FC", VA = "0x1D043FC")]
	private void OnTeamateVadStateChange(object[] data)
	{
	}

	[Token(Token = "0x600E99F")]
	[Address(RVA = "0x1D045A0", Offset = "0x1D045A0", VA = "0x1D045A0")]
	private void OnMuteStateChange(object[] data)
	{
	}

	[Token(Token = "0x600E9A0")]
	[Address(RVA = "0x1D03508", Offset = "0x1D03508", VA = "0x1D03508")]
	public void SetRelationshipState()
	{
	}

	[Token(Token = "0x600E9A1")]
	[Address(RVA = "0x1D033C8", Offset = "0x1D033C8", VA = "0x1D033C8")]
	public void SetReadyState(bool ready, bool leader)
	{
	}

	[Token(Token = "0x600E9A2")]
	[Address(RVA = "0x1D04748", Offset = "0x1D04748", VA = "0x1D04748")]
	public void SetFriendState(bool friend, [Optional] InviteClickCallBack cb)
	{
	}

	[Token(Token = "0x600E9A3")]
	[Address(RVA = "0x1D03930", Offset = "0x1D03930", VA = "0x1D03930")]
	public void SetOptionalMapResState(EGroup.PlayerPatchOptionalResStatus status)
	{
	}

	[Token(Token = "0x600E9A4")]
	[Address(RVA = "0x1D048F0", Offset = "0x1D048F0", VA = "0x1D048F0")]
	public void OnInviteBtnClick()
	{
	}

	[Token(Token = "0x600E9A5")]
	[Address(RVA = "0x1D04C00", Offset = "0x1D04C00", VA = "0x1D04C00")]
	public void EnableInivte(bool v)
	{
	}

	[Token(Token = "0x600E9A6")]
	[Address(RVA = "0x1D04CC0", Offset = "0x1D04CC0", VA = "0x1D04CC0")]
	public void ShowFriendIcon(bool v)
	{
	}

	[Token(Token = "0x600E9A7")]
	[Address(RVA = "0x1D04D60", Offset = "0x1D04D60", VA = "0x1D04D60")]
	private void OnGroupChangeNtf(object[] data)
	{
	}

	[Token(Token = "0x600E9A8")]
	[Address(RVA = "0x1D04DC8", Offset = "0x1D04DC8", VA = "0x1D04DC8")]
	private void OnClickAvatar()
	{
	}

	[Token(Token = "0x600E9A9")]
	[Address(RVA = "0x1D034B4", Offset = "0x1D034B4", VA = "0x1D034B4")]
	private void RefreshLadderIcon()
	{
	}

	[Token(Token = "0x600E9AA")]
	[Address(RVA = "0x1D05480", Offset = "0x1D05480", VA = "0x1D05480")]
	private void UpdateNickNameAndAlias()
	{
	}

	[Token(Token = "0x600E9AB")]
	[Address(RVA = "0x1D056E8", Offset = "0x1D056E8", VA = "0x1D056E8")]
	public void SetChatBubbleWorldPosition(Vector3 position)
	{
	}

	[Token(Token = "0x600E9AC")]
	[Address(RVA = "0x1D057C8", Offset = "0x1D057C8", VA = "0x1D057C8")]
	protected void OnContentClick()
	{
	}

	[Token(Token = "0x600E9AD")]
	[Address(RVA = "0x1D05A00", Offset = "0x1D05A00", VA = "0x1D05A00")]
	private void SetChatBubbleData(bool isSticker)
	{
	}

	[Token(Token = "0x600E9AE")]
	[Address(RVA = "0x1D06184", Offset = "0x1D06184", VA = "0x1D06184", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E9AF")]
	[Address(RVA = "0x1D066C0", Offset = "0x1D066C0", VA = "0x1D066C0", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E9B0")]
	[Address(RVA = "0x1D064CC", Offset = "0x1D064CC", VA = "0x1D064CC")]
	private void UpdateGroupChatBubble()
	{
	}

	[Token(Token = "0x600E9B1")]
	[Address(RVA = "0x1D06778", Offset = "0x1D06778", VA = "0x1D06778")]
	private bool _003COnClickAvatar_003Em__0(ClanMember temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600E9B2")]
	[Address(RVA = "0x1D067EC", Offset = "0x1D067EC", VA = "0x1D067EC")]
	private void _003COnClickAvatar_003Em__1()
	{
	}

	[Token(Token = "0x600E9B3")]
	[Address(RVA = "0x1D06900", Offset = "0x1D06900", VA = "0x1D06900")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E9B4")]
	[Address(RVA = "0x1D06908", Offset = "0x1D06908", VA = "0x1D06908")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
