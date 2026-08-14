using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200395E")]
public class UIRoomChatMessageItemView : UIBaseView
{
	[Token(Token = "0x4018033")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Message;

	[Token(Token = "0x4018034")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Sender;

	[Token(Token = "0x4018035")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Sticker;

	[Token(Token = "0x4018036")]
	[FieldOffset(Offset = "0x20")]
	public UISprite StickerSprite;

	[Token(Token = "0x6016FC1")]
	[Address(RVA = "0x23BAD54", Offset = "0x23BAD54", VA = "0x23BAD54")]
	public UIRoomChatMessageItemView()
	{
	}

	[Token(Token = "0x6016FC2")]
	[Address(RVA = "0x23BAD5C", Offset = "0x23BAD5C", VA = "0x23BAD5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FC3")]
	[Address(RVA = "0x23BB018", Offset = "0x23BB018", VA = "0x23BB018")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
