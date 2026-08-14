using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B8")]
public class UIHudUGCDebuggerView : UIBaseView
{
	[Token(Token = "0x4016906")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnDrop;

	[Token(Token = "0x4016907")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OpenConsoleBtn;

	[Token(Token = "0x4016908")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton PauseGameBtn;

	[Token(Token = "0x4016909")]
	[FieldOffset(Offset = "0x20")]
	public UIButton OpenGMCmdBtn;

	[Token(Token = "0x401690A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DebugGMPanel;

	[Token(Token = "0x401690B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelGOD;

	[Token(Token = "0x401690C")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelHeal;

	[Token(Token = "0x401690D")]
	[FieldOffset(Offset = "0x30")]
	public UIButton GodBtn;

	[Token(Token = "0x401690E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton HealBuffBtn;

	[Token(Token = "0x401690F")]
	[FieldOffset(Offset = "0x38")]
	public UIButton KillSelfBtn;

	[Token(Token = "0x4016910")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton TeleportBornBtn;

	[Token(Token = "0x4016911")]
	[FieldOffset(Offset = "0x40")]
	public UIButton CloseGMCmdBtn;

	[Token(Token = "0x6016AD3")]
	[Address(RVA = "0x159781C", Offset = "0x159781C", VA = "0x159781C")]
	public UIHudUGCDebuggerView()
	{
	}

	[Token(Token = "0x6016AD4")]
	[Address(RVA = "0x1597824", Offset = "0x1597824", VA = "0x1597824", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AD5")]
	[Address(RVA = "0x1597DE0", Offset = "0x1597DE0", VA = "0x1597DE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
