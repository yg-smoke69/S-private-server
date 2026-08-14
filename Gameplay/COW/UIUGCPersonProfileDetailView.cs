using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A41")]
public class UIUGCPersonProfileDetailView : UIBaseView
{
	[Token(Token = "0x40189CD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CreateNum;

	[Token(Token = "0x40189CE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LikeNum;

	[Token(Token = "0x40189CF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GameTime;

	[Token(Token = "0x40189D0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PlayNum;

	[Token(Token = "0x40189D1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RoomNum;

	[Token(Token = "0x40189D2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SubscribeNum;

	[Token(Token = "0x40189D3")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite CreateIcon;

	[Token(Token = "0x40189D4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CreatetorName;

	[Token(Token = "0x40189D5")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CreatetorExp;

	[Token(Token = "0x40189D6")]
	[FieldOffset(Offset = "0x38")]
	public UISprite FrontProgress;

	[Token(Token = "0x6017269")]
	[Address(RVA = "0x278EBE4", Offset = "0x278EBE4", VA = "0x278EBE4")]
	public UIUGCPersonProfileDetailView()
	{
	}

	[Token(Token = "0x601726A")]
	[Address(RVA = "0x278EBEC", Offset = "0x278EBEC", VA = "0x278EBEC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601726B")]
	[Address(RVA = "0x278F0F4", Offset = "0x278F0F4", VA = "0x278F0F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
