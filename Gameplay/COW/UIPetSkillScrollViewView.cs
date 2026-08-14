using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003907")]
public class UIPetSkillScrollViewView : UIBaseView
{
	[Token(Token = "0x4017B57")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SelectSkillView;

	[Token(Token = "0x4017B58")]
	[FieldOffset(Offset = "0x18")]
	public UIButton UIMarkClick;

	[Token(Token = "0x4017B59")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NoItemChoose;

	[Token(Token = "0x4017B5A")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList UIPetSkillGrid;

	[Token(Token = "0x4017B5B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CurrentSkill;

	[Token(Token = "0x6016EBE")]
	[Address(RVA = "0x2C4DEAC", Offset = "0x2C4DEAC", VA = "0x2C4DEAC")]
	public UIPetSkillScrollViewView()
	{
	}

	[Token(Token = "0x6016EBF")]
	[Address(RVA = "0x2C4DEB4", Offset = "0x2C4DEB4", VA = "0x2C4DEB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EC0")]
	[Address(RVA = "0x2C4E1B8", Offset = "0x2C4E1B8", VA = "0x2C4E1B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
