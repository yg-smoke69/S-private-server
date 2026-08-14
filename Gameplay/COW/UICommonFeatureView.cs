using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003476")]
public class UICommonFeatureView : UIBaseView
{
	[Token(Token = "0x40146A3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIContent;

	[Token(Token = "0x40146A4")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BGSprite;

	[Token(Token = "0x40146A5")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton DownLoadBtn;

	[Token(Token = "0x40146A6")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DownloadText;

	[Token(Token = "0x40146A7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton OkBtn;

	[Token(Token = "0x6016116")]
	[Address(RVA = "0x2CDE624", Offset = "0x2CDE624", VA = "0x2CDE624")]
	public UICommonFeatureView()
	{
	}

	[Token(Token = "0x6016117")]
	[Address(RVA = "0x2CDE62C", Offset = "0x2CDE62C", VA = "0x2CDE62C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016118")]
	[Address(RVA = "0x2CDE948", Offset = "0x2CDE948", VA = "0x2CDE948")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
