using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034E5")]
public class UIDigitaluniverseBStarMapView : UIBaseView
{
	[Token(Token = "0x4014C7F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnTips;

	[Token(Token = "0x4014C80")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelAssistProgress;

	[Token(Token = "0x4014C81")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelTargetProgress;

	[Token(Token = "0x4014C82")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnTarget;

	[Token(Token = "0x4014C83")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnScale;

	[Token(Token = "0x4014C84")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnShare;

	[Token(Token = "0x4014C85")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnHistory;

	[Token(Token = "0x4014C86")]
	[FieldOffset(Offset = "0x30")]
	public Transform AssistHistoryContainer;

	[Token(Token = "0x4014C87")]
	[FieldOffset(Offset = "0x34")]
	public Transform StarCanvas;

	[Token(Token = "0x4014C88")]
	[FieldOffset(Offset = "0x38")]
	public UINetworkTextureExt TitleCDN;

	[Token(Token = "0x4014C89")]
	[FieldOffset(Offset = "0x3C")]
	public Transform TopRightContainer;

	[Token(Token = "0x4014C8A")]
	[FieldOffset(Offset = "0x40")]
	public UISprite TargetArrow;

	[Token(Token = "0x4014C8B")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid TargetGrid;

	[Token(Token = "0x4014C8C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject TargetContainer;

	[Token(Token = "0x4014C8D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Assist;

	[Token(Token = "0x4014C8E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Target;

	[Token(Token = "0x4014C8F")]
	[FieldOffset(Offset = "0x54")]
	public Transform RecoverTime;

	[Token(Token = "0x4014C90")]
	[FieldOffset(Offset = "0x58")]
	public UISprite ScaleIcon;

	[Token(Token = "0x4014C91")]
	[FieldOffset(Offset = "0x5C")]
	public Transform AssistNoiceContainer;

	[Token(Token = "0x4014C92")]
	[FieldOffset(Offset = "0x60")]
	public Animation StarMapAni;

	[Token(Token = "0x4014C93")]
	[FieldOffset(Offset = "0x64")]
	public UINetworkTextureExt TitleCDNShare;

	[Token(Token = "0x4014C94")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Recover;

	[Token(Token = "0x4014C95")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject LabelRecoverTimeFull;

	[Token(Token = "0x6016261")]
	[Address(RVA = "0x2F1A394", Offset = "0x2F1A394", VA = "0x2F1A394")]
	public UIDigitaluniverseBStarMapView()
	{
	}

	[Token(Token = "0x6016262")]
	[Address(RVA = "0x2F1A39C", Offset = "0x2F1A39C", VA = "0x2F1A39C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016263")]
	[Address(RVA = "0x2F1AC80", Offset = "0x2F1AC80", VA = "0x2F1AC80")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
