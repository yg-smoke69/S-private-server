using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003525")]
public class UIEPWeeklyTaskDetailItemView : UIBaseView
{
	[Token(Token = "0x4014FA7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4014FA8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Desc;

	[Token(Token = "0x4014FA9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Process;

	[Token(Token = "0x4014FAA")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid AwardList;

	[Token(Token = "0x4014FAB")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Operation;

	[Token(Token = "0x4014FAC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BGReceived;

	[Token(Token = "0x4014FAD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BGAwarded;

	[Token(Token = "0x4014FAE")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BGFnished;

	[Token(Token = "0x601631F")]
	[Address(RVA = "0x2A37E48", Offset = "0x2A37E48", VA = "0x2A37E48")]
	public UIEPWeeklyTaskDetailItemView()
	{
	}

	[Token(Token = "0x6016320")]
	[Address(RVA = "0x2A37E50", Offset = "0x2A37E50", VA = "0x2A37E50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016321")]
	[Address(RVA = "0x2A38280", Offset = "0x2A38280", VA = "0x2A38280")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
