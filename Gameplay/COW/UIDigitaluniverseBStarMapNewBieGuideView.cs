using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034E2")]
public class UIDigitaluniverseBStarMapNewBieGuideView : UIBaseView
{
	[Token(Token = "0x4014C6F")]
	[FieldOffset(Offset = "0x14")]
	public Animation UIDigitaluniverseBStarMapGuideAni;

	[Token(Token = "0x4014C70")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentWelcome;

	[Token(Token = "0x4014C71")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ContentCongratulation;

	[Token(Token = "0x4014C72")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ContinueBtn;

	[Token(Token = "0x4014C73")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ContentFinger;

	[Token(Token = "0x4014C74")]
	[FieldOffset(Offset = "0x28")]
	public BoxCollider Mask;

	[Token(Token = "0x4014C75")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BottomContainer;

	[Token(Token = "0x4014C76")]
	[FieldOffset(Offset = "0x30")]
	public UILabel welcomKey;

	[Token(Token = "0x4014C77")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SpineContainer;

	[Token(Token = "0x6016258")]
	[Address(RVA = "0x2F19074", Offset = "0x2F19074", VA = "0x2F19074")]
	public UIDigitaluniverseBStarMapNewBieGuideView()
	{
	}

	[Token(Token = "0x6016259")]
	[Address(RVA = "0x2F1907C", Offset = "0x2F1907C", VA = "0x2F1907C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601625A")]
	[Address(RVA = "0x2F194E8", Offset = "0x2F194E8", VA = "0x2F194E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
