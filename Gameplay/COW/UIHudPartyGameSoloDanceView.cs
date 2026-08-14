using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D0")]
public class UIHudPartyGameSoloDanceView : UIBaseView
{
	[Token(Token = "0x4016210")]
	[FieldOffset(Offset = "0x14")]
	public Transform ScoreInfo;

	[Token(Token = "0x4016211")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelScore;

	[Token(Token = "0x4016212")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelScorePopWithAnim;

	[Token(Token = "0x4016213")]
	[FieldOffset(Offset = "0x20")]
	public Animation AddScoreAnim;

	[Token(Token = "0x4016214")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnQuitGame;

	[Token(Token = "0x4016215")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoPreGame;

	[Token(Token = "0x4016216")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject GoInvitor;

	[Token(Token = "0x4016217")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GoWaitingTip;

	[Token(Token = "0x4016218")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnInvite;

	[Token(Token = "0x4016219")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteBtnInviteCD;

	[Token(Token = "0x401621A")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject GoInvitePanel;

	[Token(Token = "0x401621B")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnInviteAll;

	[Token(Token = "0x401621C")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnInviteFriends;

	[Token(Token = "0x401621D")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnCloseInvite;

	[Token(Token = "0x401621E")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject GoInGame;

	[Token(Token = "0x401621F")]
	[FieldOffset(Offset = "0x50")]
	public Transform TrCountDownDuringGame;

	[Token(Token = "0x4016220")]
	[FieldOffset(Offset = "0x54")]
	public UILabel LabelCountDownDuringGameKey;

	[Token(Token = "0x4016221")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget labelbgwidget;

	[Token(Token = "0x4016222")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite SpriteCountDownDuringGameWarning;

	[Token(Token = "0x4016223")]
	[FieldOffset(Offset = "0x60")]
	public UIWidget warningwidget;

	[Token(Token = "0x4016224")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LabelCountDownDuringGame;

	[Token(Token = "0x4016225")]
	[FieldOffset(Offset = "0x68")]
	public TweenAlpha TweenAlpha;

	[Token(Token = "0x4016226")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject GoCountDownOnStarting;

	[Token(Token = "0x4016227")]
	[FieldOffset(Offset = "0x70")]
	public UILabel PreCountNum;

	[Token(Token = "0x601681D")]
	[Address(RVA = "0x1843124", Offset = "0x1843124", VA = "0x1843124")]
	public UIHudPartyGameSoloDanceView()
	{
	}

	[Token(Token = "0x601681E")]
	[Address(RVA = "0x184312C", Offset = "0x184312C", VA = "0x184312C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601681F")]
	[Address(RVA = "0x1843974", Offset = "0x1843974", VA = "0x1843974")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
