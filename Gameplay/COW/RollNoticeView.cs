using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D0B")]
public class RollNoticeView : MonoBehaviour
{
	[Token(Token = "0x2002D0C")]
	private enum ERollState
	{
		[Token(Token = "0x401130E")]
		None,
		[Token(Token = "0x401130F")]
		Start,
		[Token(Token = "0x4011310")]
		Pause,
		[Token(Token = "0x4011311")]
		Resume,
		[Token(Token = "0x4011312")]
		End,
		[Token(Token = "0x4011313")]
		Wait
	}

	[Token(Token = "0x40112E1")]
	[FieldOffset(Offset = "0xC")]
	public uint RollSpeed;

	[Token(Token = "0x40112E2")]
	[FieldOffset(Offset = "0x10")]
	public uint DurationOfStay;

	[Token(Token = "0x40112E3")]
	[FieldOffset(Offset = "0x14")]
	public uint RollInterval;

	[Token(Token = "0x40112E4")]
	[FieldOffset(Offset = "0x18")]
	public uint RequestCD;

	[Token(Token = "0x40112E5")]
	[FieldOffset(Offset = "0x1C")]
	public float FriendsNodeShowAnimTime;

	[Token(Token = "0x40112E6")]
	[FieldOffset(Offset = "0x20")]
	public UIPanel MessagePanel;

	[Token(Token = "0x40112E7")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FriendsBg;

	[Token(Token = "0x40112E8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FriendsNode;

	[Token(Token = "0x40112E9")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel FriendsMessageView;

	[Token(Token = "0x40112EA")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget FriendsMessageWidget;

	[Token(Token = "0x40112EB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LoudSpeakerBg;

	[Token(Token = "0x40112EC")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LoudSpeakerNode;

	[Token(Token = "0x40112ED")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LoudSpeakerMessageView;

	[Token(Token = "0x40112EE")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget LoudSpeakerMessageWidget;

	[Token(Token = "0x40112EF")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NormalBg;

	[Token(Token = "0x40112F0")]
	[FieldOffset(Offset = "0x48")]
	public GameObject NormalNode;

	[Token(Token = "0x40112F1")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel NormalMessageView;

	[Token(Token = "0x40112F2")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget NormalMessageWidget;

	[Token(Token = "0x40112F3")]
	[FieldOffset(Offset = "0x54")]
	private Queue<RollNoticeData> m_GMNoticeList;

	[Token(Token = "0x40112F4")]
	[FieldOffset(Offset = "0x58")]
	private Queue<RollNoticeData> m_FriendsNoticeList;

	[Token(Token = "0x40112F5")]
	[FieldOffset(Offset = "0x5C")]
	private Queue<RollNoticeData> m_LoudSpeakerNoticeList;

	[Token(Token = "0x40112F6")]
	[FieldOffset(Offset = "0x60")]
	private Queue<RollNoticeData> m_NormalNoticeList;

	[Token(Token = "0x40112F7")]
	[FieldOffset(Offset = "0x64")]
	private RollNoticeData m_RollingNotice;

	[Token(Token = "0x40112F8")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_StartPos;

	[Token(Token = "0x40112F9")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_StopPos;

	[Token(Token = "0x40112FA")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_EndPos;

	[Token(Token = "0x40112FB")]
	[FieldOffset(Offset = "0x8C")]
	private UILabel m_MsgTxt;

	[Token(Token = "0x40112FC")]
	[FieldOffset(Offset = "0x90")]
	private UIWidget m_MsgWidget;

	[Token(Token = "0x40112FD")]
	[FieldOffset(Offset = "0x94")]
	private UIPanel m_MsgPanel;

	[Token(Token = "0x40112FE")]
	[FieldOffset(Offset = "0x98")]
	private UISprite m_MsgSprite;

	[Token(Token = "0x40112FF")]
	[FieldOffset(Offset = "0x9C")]
	private Vector4 m_DefaultPanelClip;

	[Token(Token = "0x4011300")]
	[FieldOffset(Offset = "0xAC")]
	private Vector4 m_CurPanelClip;

	[Token(Token = "0x4011301")]
	[FieldOffset(Offset = "0xBC")]
	private float m_TimeElapsed;

	[Token(Token = "0x4011302")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_UpdateFriendNode;

	[Token(Token = "0x4011303")]
	[FieldOffset(Offset = "0xC1")]
	private bool m_IsShowing;

	[Token(Token = "0x4011304")]
	[FieldOffset(Offset = "0xC4")]
	private float m_PanelWidth;

	[Token(Token = "0x4011305")]
	[FieldOffset(Offset = "0xC8")]
	private TweenPosition m_TweenPos;

	[Token(Token = "0x4011306")]
	[FieldOffset(Offset = "0xCC")]
	private TweenAlpha m_TweenAlpha;

	[Token(Token = "0x4011307")]
	[FieldOffset(Offset = "0xD0")]
	private TweenScale m_TweenScale;

	[Token(Token = "0x4011308")]
	[FieldOffset(Offset = "0xD4")]
	private List<uint> m_DelayCallIds;

	[Token(Token = "0x4011309")]
	[FieldOffset(Offset = "0xD8")]
	private ERollState m_RollState;

	[Token(Token = "0x401130A")]
	[FieldOffset(Offset = "0xDC")]
	private float m_RequestTime;

	[Token(Token = "0x401130B")]
	[FieldOffset(Offset = "0xE0")]
	private UIModelBroadcast m_ModelBroadcast;

	[Token(Token = "0x401130C")]
	[FieldOffset(Offset = "0xE4")]
	private UIModelRelationShip m_ModelRelation;

	[Token(Token = "0x6012D64")]
	[Address(RVA = "0x240B098", Offset = "0x240B098", VA = "0x240B098")]
	public RollNoticeView()
	{
	}

	[Token(Token = "0x6012D65")]
	[Address(RVA = "0x240B290", Offset = "0x240B290", VA = "0x240B290")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012D66")]
	[Address(RVA = "0x240B488", Offset = "0x240B488", VA = "0x240B488")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012D67")]
	[Address(RVA = "0x240B928", Offset = "0x240B928", VA = "0x240B928")]
	private void Update()
	{
	}

	[Token(Token = "0x6012D68")]
	[Address(RVA = "0x240BC98", Offset = "0x240BC98", VA = "0x240BC98")]
	public void StartShow()
	{
	}

	[Token(Token = "0x6012D69")]
	[Address(RVA = "0x240C3FC", Offset = "0x240C3FC", VA = "0x240C3FC")]
	public void StartShow(RollNoticeData data)
	{
	}

	[Token(Token = "0x6012D6A")]
	[Address(RVA = "0x240BF7C", Offset = "0x240BF7C", VA = "0x240BF7C")]
	public void RollPre()
	{
	}

	[Token(Token = "0x6012D6B")]
	[Address(RVA = "0x240C6E4", Offset = "0x240C6E4", VA = "0x240C6E4")]
	public void RollStart()
	{
	}

	[Token(Token = "0x6012D6C")]
	[Address(RVA = "0x240BB68", Offset = "0x240BB68", VA = "0x240BB68")]
	private void UpdateFriendNode()
	{
	}

	[Token(Token = "0x6012D6D")]
	[Address(RVA = "0x240CC64", Offset = "0x240CC64", VA = "0x240CC64")]
	private void RollPause()
	{
	}

	[Token(Token = "0x6012D6E")]
	[Address(RVA = "0x240CE8C", Offset = "0x240CE8C", VA = "0x240CE8C")]
	private void PreResume()
	{
	}

	[Token(Token = "0x6012D6F")]
	[Address(RVA = "0x240D024", Offset = "0x240D024", VA = "0x240D024")]
	private void RollResume()
	{
	}

	[Token(Token = "0x6012D70")]
	[Address(RVA = "0x240D254", Offset = "0x240D254", VA = "0x240D254")]
	private void RollEnd()
	{
	}

	[Token(Token = "0x6012D71")]
	[Address(RVA = "0x240D7B8", Offset = "0x240D7B8", VA = "0x240D7B8")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x6012D72")]
	[Address(RVA = "0x240B600", Offset = "0x240B600", VA = "0x240B600")]
	private void SetCurBroadCastType(EBroadCastType type)
	{
	}

	[Token(Token = "0x6012D73")]
	[Address(RVA = "0x240D8CC", Offset = "0x240D8CC", VA = "0x240D8CC")]
	public void GoToNav()
	{
	}

	[Token(Token = "0x6012D74")]
	[Address(RVA = "0x240C52C", Offset = "0x240C52C", VA = "0x240C52C")]
	public void ChooseValidNotice()
	{
	}

	[Token(Token = "0x6012D75")]
	[Address(RVA = "0x240D4A8", Offset = "0x240D4A8", VA = "0x240D4A8")]
	private bool IsAllEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6012D76")]
	[Address(RVA = "0x240D618", Offset = "0x240D618", VA = "0x240D618")]
	private bool TryFillGMList()
	{
		return default(bool);
	}

	[Token(Token = "0x6012D77")]
	[Address(RVA = "0x240DCC8", Offset = "0x240DCC8", VA = "0x240DCC8")]
	private void ReplaceRelationIcon()
	{
	}

	[Token(Token = "0x6012D78")]
	[Address(RVA = "0x240DAA4", Offset = "0x240DAA4", VA = "0x240DAA4")]
	private void LogEvent()
	{
	}
}
