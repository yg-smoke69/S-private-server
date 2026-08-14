using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034FE")]
public class UIElitePassChallengeItemView : UIBaseView
{
	[Token(Token = "0x4014DD3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BgSpeical;

	[Token(Token = "0x4014DD4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Desc;

	[Token(Token = "0x4014DD5")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ProcessLabel;

	[Token(Token = "0x4014DD6")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ClaimBtn;

	[Token(Token = "0x4014DD7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton GotoEpBtn;

	[Token(Token = "0x4014DD8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Claimed;

	[Token(Token = "0x4014DD9")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid RewardList;

	[Token(Token = "0x4014DDA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Content;

	[Token(Token = "0x4014DDB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GoTask;

	[Token(Token = "0x4014DDC")]
	[FieldOffset(Offset = "0x38")]
	public UIButton GoTaskBtn;

	[Token(Token = "0x4014DDD")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Lock;

	[Token(Token = "0x4014DDE")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ClaimLabel;

	[Token(Token = "0x4014DDF")]
	[FieldOffset(Offset = "0x44")]
	public UILabel GotoEPLabel;

	[Token(Token = "0x4014DE0")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LockLabel;

	[Token(Token = "0x4014DE1")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ClaimedLabel;

	[Token(Token = "0x4014DE2")]
	[FieldOffset(Offset = "0x50")]
	public UILabel GoTaskLabel;

	[Token(Token = "0x60162AA")]
	[Address(RVA = "0x2A514F0", Offset = "0x2A514F0", VA = "0x2A514F0")]
	public UIElitePassChallengeItemView()
	{
	}

	[Token(Token = "0x60162AB")]
	[Address(RVA = "0x2A514F8", Offset = "0x2A514F8", VA = "0x2A514F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162AC")]
	[Address(RVA = "0x2A51C04", Offset = "0x2A51C04", VA = "0x2A51C04")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
