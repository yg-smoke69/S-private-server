using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003902")]
public class UIPetCommonItemView : UIBaseView
{
	[Token(Token = "0x4017B32")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIButtonUIPetCommonItem;

	[Token(Token = "0x4017B33")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView BaseItemViewUIPetCommonItem;

	[Token(Token = "0x4017B34")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HighLightBG;

	[Token(Token = "0x4017B35")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BG;

	[Token(Token = "0x4017B36")]
	[FieldOffset(Offset = "0x24")]
	public UISprite UnlockIcon;

	[Token(Token = "0x4017B37")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Check;

	[Token(Token = "0x4017B38")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NewTag;

	[Token(Token = "0x6016EAF")]
	[Address(RVA = "0x23F303C", Offset = "0x23F303C", VA = "0x23F303C")]
	public UIPetCommonItemView()
	{
	}

	[Token(Token = "0x6016EB0")]
	[Address(RVA = "0x23F3044", Offset = "0x23F3044", VA = "0x23F3044", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EB1")]
	[Address(RVA = "0x23F33FC", Offset = "0x23F33FC", VA = "0x23F33FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
