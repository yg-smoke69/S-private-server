using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A00")]
public class UITopUpEventItemView : UIBaseView
{
	[Token(Token = "0x401874C")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ItemGrid;

	[Token(Token = "0x401874D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject State_CanNotCliam;

	[Token(Token = "0x401874E")]
	[FieldOffset(Offset = "0x1C")]
	public Animation ButtonTopUpAnimation;

	[Token(Token = "0x401874F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GoToTopUpBtn;

	[Token(Token = "0x4018750")]
	[FieldOffset(Offset = "0x24")]
	public GameObject State_CanCliam;

	[Token(Token = "0x4018751")]
	[FieldOffset(Offset = "0x28")]
	public Animation ButtonClaimAnimation;

	[Token(Token = "0x4018752")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton GoToCliamBtn;

	[Token(Token = "0x4018753")]
	[FieldOffset(Offset = "0x30")]
	public GameObject State_Cliamed;

	[Token(Token = "0x4018754")]
	[FieldOffset(Offset = "0x34")]
	public GameObject DiamondCountContainer;

	[Token(Token = "0x4018755")]
	[FieldOffset(Offset = "0x38")]
	public UILabel DiamondCountLabel;

	[Token(Token = "0x60171A6")]
	[Address(RVA = "0x2AF7F0C", Offset = "0x2AF7F0C", VA = "0x2AF7F0C")]
	public UITopUpEventItemView()
	{
	}

	[Token(Token = "0x60171A7")]
	[Address(RVA = "0x2AF7F14", Offset = "0x2AF7F14", VA = "0x2AF7F14", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171A8")]
	[Address(RVA = "0x2AF83EC", Offset = "0x2AF83EC", VA = "0x2AF83EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
