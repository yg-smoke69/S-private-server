using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003518")]
public class UIEPChallengeTaskItemView : UIBaseView
{
	[Token(Token = "0x4014F3F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4014F40")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Desc;

	[Token(Token = "0x4014F41")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Process;

	[Token(Token = "0x4014F42")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid AwardList;

	[Token(Token = "0x4014F43")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Operation;

	[Token(Token = "0x4014F44")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BGReceived;

	[Token(Token = "0x4014F45")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BGAwarded;

	[Token(Token = "0x4014F46")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BGFnished;

	[Token(Token = "0x60162F8")]
	[Address(RVA = "0x2BA1B08", Offset = "0x2BA1B08", VA = "0x2BA1B08")]
	public UIEPChallengeTaskItemView()
	{
	}

	[Token(Token = "0x60162F9")]
	[Address(RVA = "0x2BA1B10", Offset = "0x2BA1B10", VA = "0x2BA1B10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162FA")]
	[Address(RVA = "0x2BA1F40", Offset = "0x2BA1F40", VA = "0x2BA1F40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
