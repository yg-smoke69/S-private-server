using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003AD1")]
public class TaskItemCodeLabelBtn : MonoBehaviour
{
	[Token(Token = "0x4018FDC")]
	[FieldOffset(Offset = "0xC")]
	public UILabel NumberLabel;

	[Token(Token = "0x4018FDD")]
	[FieldOffset(Offset = "0x10")]
	public GameObject EnableRoot;

	[Token(Token = "0x4018FDE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject DisableRoot;

	[Token(Token = "0x4018FDF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Btn;

	[Token(Token = "0x4018FE0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ErrorIcon;

	[Token(Token = "0x4018FE1")]
	[FieldOffset(Offset = "0x20")]
	private int CodeNumber;

	[Token(Token = "0x4018FE2")]
	[FieldOffset(Offset = "0x24")]
	private Action<int, TaskItemCodeLabelBtn> inputCallBack;

	[Token(Token = "0x60174AB")]
	[Address(RVA = "0x21DC798", Offset = "0x21DC798", VA = "0x21DC798")]
	public TaskItemCodeLabelBtn()
	{
	}

	[Token(Token = "0x60174AC")]
	[Address(RVA = "0x21DC7A0", Offset = "0x21DC7A0", VA = "0x21DC7A0")]
	public void InitInfo(int code, bool isEnable, Action<int, TaskItemCodeLabelBtn> callBack)
	{
	}

	[Token(Token = "0x60174AD")]
	[Address(RVA = "0x21DC8CC", Offset = "0x21DC8CC", VA = "0x21DC8CC")]
	public void SetErrorState()
	{
	}

	[Token(Token = "0x60174AE")]
	[Address(RVA = "0x21DC92C", Offset = "0x21DC92C", VA = "0x21DC92C")]
	public void OnInput()
	{
	}
}
