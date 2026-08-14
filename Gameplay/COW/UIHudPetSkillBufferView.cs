using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036DA")]
public class UIHudPetSkillBufferView : UIBaseView
{
	[Token(Token = "0x401626F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4016270")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x4016271")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Mask;

	[Token(Token = "0x4016272")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Effect;

	[Token(Token = "0x4016273")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Tips;

	[Token(Token = "0x601683B")]
	[Address(RVA = "0x185291C", Offset = "0x185291C", VA = "0x185291C")]
	public UIHudPetSkillBufferView()
	{
	}

	[Token(Token = "0x601683C")]
	[Address(RVA = "0x1852924", Offset = "0x1852924", VA = "0x1852924", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601683D")]
	[Address(RVA = "0x1852C40", Offset = "0x1852C40", VA = "0x1852C40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
