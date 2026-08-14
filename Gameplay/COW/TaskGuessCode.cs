using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003ACE")]
public class TaskGuessCode : BaseTask
{
	[Token(Token = "0x4018FC4")]
	[FieldOffset(Offset = "0x48")]
	public int MaxNumber;

	[Token(Token = "0x4018FC5")]
	[FieldOffset(Offset = "0x4C")]
	public int CanInputNumberCount;

	[Token(Token = "0x4018FC6")]
	[FieldOffset(Offset = "0x50")]
	public TaskItemCodeLabelBtn CodeInputItemTemplate;

	[Token(Token = "0x4018FC7")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid CodeInputGrid;

	[Token(Token = "0x4018FC8")]
	[FieldOffset(Offset = "0x58")]
	public List<UILabel> ShowCodeResult;

	[Token(Token = "0x4018FC9")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject FinalNumberNoInputRoot;

	[Token(Token = "0x4018FCA")]
	[FieldOffset(Offset = "0x60")]
	public UILabel FinalResultLabel;

	[Token(Token = "0x4018FCB")]
	[FieldOffset(Offset = "0x64")]
	public string CodeInputSound;

	[Token(Token = "0x4018FCC")]
	[FieldOffset(Offset = "0x68")]
	private ResourceID m_CodeInputSoundRes;

	[Token(Token = "0x4018FCD")]
	[FieldOffset(Offset = "0x6C")]
	private int m_FinalCode;

	[Token(Token = "0x6017496")]
	[Address(RVA = "0x28975D4", Offset = "0x28975D4", VA = "0x28975D4")]
	public TaskGuessCode()
	{
	}

	[Token(Token = "0x6017497")]
	[Address(RVA = "0x28976C0", Offset = "0x28976C0", VA = "0x28976C0", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6017498")]
	[Address(RVA = "0x2897D78", Offset = "0x2897D78", VA = "0x2897D78")]
	public void OnCodeInput(int code, TaskItemCodeLabelBtn codeBtn)
	{
	}

	[Token(Token = "0x6017499")]
	[Address(RVA = "0x28980BC", Offset = "0x28980BC", VA = "0x28980BC")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
